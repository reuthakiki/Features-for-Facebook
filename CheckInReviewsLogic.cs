using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookDesktopAppLogic
{
    public class CheckInReviewsLogic
    {
        User m_LoggedInUser;
        readonly List<User> m_ListOfFriendSameCheckIn = new List<User>();
        readonly Group m_Group = new Group();

        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }

            set
            {
                m_LoggedInUser = value;
            }
        }

        public CheckInReviewsLogic(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public void PostReview(bool i_ValidPost, string i_Text, string i_FileName)
        {
            if (i_ValidPost == false)
            {
                 m_Group.PostPhoto(i_FileName, i_Text);
            }
            else
            {
                 m_Group.PostToWall(i_Text);
            }

        }

        public void ListFriend_SelectedIndexChanged()
        {
            bool isEmpty = true;
            bool wasShow = false;

            foreach (User user in m_LoggedInUser.Friends)
            {
                foreach (Checkin checkin in user.Checkins)
                {
                    if (checkin.Place != null)
                    {
                        if (checkin.Place.Name.Equals(m_LoggedInUser.Checkins[0].Place.Name) && !wasShow)
                        {
                            m_ListOfFriendSameCheckIn.Add(user);
                            isEmpty = false;
                            wasShow = true;
                        }
                    }
                }

                wasShow = false;
            }

            groupOfFriend(isEmpty);
        }

        private void groupOfFriend(bool i_isEmpty)
        {
            try
            {
                if (i_isEmpty == false)
                {
                    m_LoggedInUser.Groups.Add(m_Group);
                    m_Group.Members.Clear();
                    foreach (User user in m_ListOfFriendSameCheckIn)
                    {
                        m_Group.Members.Add(user);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Failed to create a group of user friends.");
            }
        }
    }
}