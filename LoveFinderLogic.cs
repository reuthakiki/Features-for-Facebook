using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    class LoveFinderLogic
    {
        private readonly User m_LoggedInUser;
        private User m_RandomFriend;
        readonly List<string> m_RighhtAnswers = new List<string>();

        private static readonly List<string> Q1LikedPagesAnswers = new List<string>()
        {
            "bibi", "Cows", "Pokimon Fans", "The Best Diet", "Eilat is the best city", "shiri Maimon", "Maple Story",
        };

        private static readonly List<string> Q2BirthdayAnswers = new List<string>()
        {
            "21/4/1996", "20/8/1995", "1/1/1997", "15/3/1995", "8/7/1990", "11/2/1987", "3/5/1996",
        };

        private static readonly List<string> Q3LocationAnswers = new List<string>()
        {
            "Ashdod", "Haifa", "Eilat", "Tberia", "London", "Mexico", "Natanya",
        };

        public LoveFinderLogic(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public User GetRandomFriend(List<User> i_Friends)
        {
            User randomFriend = null;
            Random rand = new Random();

            if (i_Friends.Count != 0)
            {
                randomFriend = i_Friends[rand.Next(0, i_Friends.Count)];
            }

            m_RandomFriend = randomFriend;

            return randomFriend;
        }

        public void GetWishedFilteredFriends(int i_GenderNumber, int i_FromAge, int i_ToAge, ref List<User> io_Friends) //1male 2female 3both
        {
            if (i_GenderNumber != 2)
            {
                filterByGender(ref io_Friends, i_GenderNumber);
            }

            filterByAge(ref io_Friends, i_FromAge, i_ToAge);
        }

        private void filterByGender(ref List<User> io_FilteredFriends, int i_GenderNumber)
        {
            io_FilteredFriends = io_FilteredFriends.Where(
                user =>
                user.Gender != null &&
                ((i_GenderNumber == 1 && user.Gender == User.eGender.female)
                || (i_GenderNumber == 0 && user.Gender == User.eGender.male))).ToList();
        }

        private void filterByAge(ref List<User> io_FilteredFriends, int i_FromAge, int i_ToAge)
        {
            io_FilteredFriends = io_FilteredFriends.Where(user =>
            user.Birthday != null &&
            (DateTime.Now - DateTime.Parse(
                user.Birthday, new System.Globalization.CultureInfo("en-US"))).Days / 365 >= i_FromAge &&
            (DateTime.Now - DateTime.Parse(
                user.Birthday, new System.Globalization.CultureInfo("en-US"))).Days / 365 <= i_ToAge)
                .ToList();
        }

        public List<string> GetAnswesForQuestion1()
        {
            Random rand;
            int index;
            string likedPageName;
            string[] subStrings;

            m_RighhtAnswers.Clear();
            rand = new Random();
            index = rand.Next(0, m_RandomFriend.LikedPages.Count);
            likedPageName = m_RandomFriend.LikedPages[index].ToString();
            subStrings = likedPageName.Split(':');
            subStrings = subStrings[1].Split(',');
            m_RighhtAnswers.Add(subStrings[0]);
            return GetQuestionAnswers(new List<string>(Q1LikedPagesAnswers), subStrings[0]);
        }

        public List<string> GetAnswesForQuestion2()
        {
            m_RighhtAnswers.Add(m_RandomFriend.Birthday.ToString());
            return GetQuestionAnswers(new List<string>(Q2BirthdayAnswers), m_RandomFriend.Birthday.ToString());
        }

        public List<string> GetAnswesForQuestion3()
        {
            string location;
            string[] subStrings;

            location = m_RandomFriend.Location.ToString();
            subStrings = location.Split(',');
            subStrings = location.Split('(');
            m_RighhtAnswers.Add(subStrings[0]);
            return GetQuestionAnswers(new List<string>(Q3LocationAnswers), subStrings[0]);
        }

        public List<string> GetQuestionAnswers(List<string> i_Answers, string i_RightAnswer)
        {
            List<string> answers = null;
            Random rand;
            int answersIndex;

            if (i_RightAnswer != null)
            {
                rand = new Random();
                answers = new List<string>();

                answers.Add(i_RightAnswer);
                for (int index = 0; index < 3; index++)
                {
                    answersIndex = rand.Next(0, i_Answers.Count);
                    if (i_RightAnswer != i_Answers[answersIndex])
                    {
                        answers.Add(i_Answers[answersIndex]);
                    }
                    else
                    {
                        index--;
                    }

                    i_Answers.RemoveAt(answersIndex);
                }
            }

            return answers;
        }

        public string MatchChecker(string i_Answer1, string i_Answer2, string i_Answer3)
        {
            int numberOfRightAnswers = rightAnswersChecker(i_Answer1, i_Answer2, i_Answer3);
            int matchPrecntage = matchPrecntageCalcuate(numberOfRightAnswers);
            string result = string.Format("You and {0} have {1}% Matching percentages", m_RandomFriend.Name, matchPrecntage);
            return result;
        }

        private int rightAnswersChecker(string i_Answer1, string i_Answer2, string i_Answer3)
        {
            int count = 0;

            for (int index = 0; index < 3; index++)
            {
                if (m_RighhtAnswers[index] == i_Answer1 ||
                   m_RighhtAnswers[index] == i_Answer2 ||
                   m_RighhtAnswers[index] == i_Answer3)
                {
                    count++;
                }
            }

            return count;
        }

        private int matchPrecntageCalcuate(int i_NumbersOfRightAnswers)
        {
            return (int)Math.Ceiling((decimal)(100 / m_RighhtAnswers.Count * i_NumbersOfRightAnswers));
        }
    }
}
