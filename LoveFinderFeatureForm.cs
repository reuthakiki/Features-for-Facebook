using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookDesktopAppLogic;
using System.Threading;
using System.Data;
using System.Linq;


namespace BasicFacebookFeatures
{
    public partial class LoveFinder : Form
    {
        readonly User m_LoggedInUser;
        readonly LoveFinderLogic m_FinderLogic;

        public User LoggedInUser { get; set; }

        internal LoveFinder()
        {
        }

        public LoveFinder(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_FinderLogic = new LoveFinderLogic(m_LoggedInUser);
        }

        private void loadTriviaScores()
        {
            listBoxScoreHistory.Invoke(new Action(() =>
            loveFinderTriviaStatisticBindingSource.DataSource = m_FinderLogic.LoadTriviaScores()));
        }

        private void clearFriendInfo()
        {
            pictureBoxFriend.Image = null;
        }

        private void filterFriends()
        {
            labelScore.Visible = false;
            List<User> filteredFriends = new List<User>(m_LoggedInUser.Friends);
            int genderNumber;

            clearFriendInfo();
            try
            {
                genderNumber = checkedListBoxGender.SelectedIndex;
                m_FinderLogic.GetWishedFilteredFriends(genderNumber, (int)numericUpDown2.Value, (int)numericUpDown1.Value, ref filteredFriends);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to get user friends list.");
            }

            if (filteredFriends.Count != 0)
            {
               fetchUserFriendInfo(filteredFriends);
            }
            else
            {
                MessageBox.Show("No Matching Friends :(");
            }
        }

        private void fetchUserFriendInfo(List<User> i_FilteredFriends)
        {
            User friend = new User();

            friend = m_FinderLogic.GetRandomMatchFriend(i_FilteredFriends);
            pictureBoxFriend.LoadAsync(friend.PictureNormalURL);
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            checkedListBox4.Items.Clear();
            fetchAnswers();

            hideTriviaComponents();
            new Thread(loadTriviaScores).Start();

        }

        private void fetchAnswers()
        {
            fetchAnswersQ1();
            fetchAnswersQ2();
            fetchAnswersQ3();
        }

        private void fetchAnswersQ1()
        {
            List<string> answers = m_FinderLogic.GetAnswesForQuestion1();

            for (int index = 0; index < 4; index++)
            {
                checkedListBox4.Items.Add(answers[index]);
            }
        }

        private void fetchAnswersQ2()
        {
            List<string> answers = m_FinderLogic.GetAnswesForQuestion2();

            for (int index = 0; index < 4; index++)
            {
                checkedListBox1.Items.Add(answers[index]);
            }
        }

        private void fetchAnswersQ3()
        {
            List<string> answers = m_FinderLogic.GetAnswesForQuestion3();

            for (int index = 0; index < 4; index++)
            {
                checkedListBox2.Items.Add(answers[index]);
            }
        }

        private void backGruond_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void buttonMatchCheck_Click(object sender, EventArgs e)
        {
            matchShow();
        }

        private void hideTriviaComponents()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            buttonMatchCheck.Visible = false;
            labelMatchPre.Visible = false;
            labelScore.Visible = false;
        }

        private void matchShow()
        {
            int totalRightAnswers = 0;
            int enabledTriviaQuestions = getEnabledTriviaQuestionsNumber();

            textBoxMatchPost.Text = m_FinderLogic.MatchChecker(checkedListBox4.CheckedItems[0].ToString(), checkedListBox1.CheckedItems[0].ToString(),
            checkedListBox2.CheckedItems[0].ToString(), ref totalRightAnswers);
            textBoxMatchPost.ForeColor = Color.Black;
            labelScore.Text = $"{totalRightAnswers}%";

            labelScore.Visible = true;
            loveFinderTriviaStatisticBindingSource.Add(m_FinderLogic.GetTriviaGameStatistic(totalRightAnswers, enabledTriviaQuestions));
            m_FinderLogic.SaveTriviaScores();
        }

        private int getEnabledTriviaQuestionsNumber()
        {
            int counter = 0;

            foreach (GroupBox groupBox in panel2.Controls.OfType<GroupBox>())
            {
                if (groupBox.Enabled)
                {
                    ++counter;
                }
            }

            return counter;
        }

        private void checkListBoxCheckedItem(CheckedListBox i_Checkbox)
        {
            for (int index = 0; index < i_Checkbox.Items.Count; index++)
            {
                if (index != i_Checkbox.SelectedIndex)
                {
                    i_Checkbox.SetItemChecked(index, false);
                }
                else
                {
                    i_Checkbox.SetItemChecked(index, true);
                }
            }
        }

        private void checkedListBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            checkListBoxCheckedItem(checkedListBox4);
        }

        private void checkedListBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            checkListBoxCheckedItem(checkedListBox1);
        }

        private void groupBoxFriendbirth2_Enter(object sender, EventArgs e)
        {
        }

        private void checkedListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            checkListBoxCheckedItem(checkedListBox2);
        }

        private void hScrollBarFinder1_Scroll_1(object sender, ScrollEventArgs e)
        {
            filterFriends();
            disposeTriviaComponents();

        }

        private void disposeTriviaComponents()
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            buttonMatchCheck.Visible = true;
            labelMatchPre.Visible = true;
        }

        private void buttonStatus_Click_1(object sender, EventArgs e)
        {
            if(0 == textBoxMatchPost.Text.Length)
            {
                MessageBox.Show("please answer the trivia to match and post");
            }
            else
            {
                 postStatus();
            }
        }

        private void postStatus()
        {
            Status postedStatus;

            try
            {
                postedStatus = LoggedInUser.PostStatus(textBoxMatchPost.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSetFilters_Click(object sender, EventArgs e)
        {
            filterFriends();
            disposeTriviaComponents();
        }

        private void numericUpDownAge1_ValueChanged_1(object sender, EventArgs e)
        {
        }

        private void checkedListBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkListBoxCheckedItem(checkedListBoxGender);
        }

        private void backGroundFinder_Paint(object sender, PaintEventArgs e)
        {
        }

        private void finderTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void Heartshape_Click_1(object sender, EventArgs e)
        {

        }

        private void filterTitle_Click(object sender, EventArgs e)
        {

        }

        private void genderTitle_Click(object sender, EventArgs e)
        {

        }

        private void ageTitle_Click(object sender, EventArgs e)
        {

        }

        private void fromTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDownAge2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void toTitle_Click(object sender, EventArgs e)
        {

        }

        private void MatchPercentageTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxFriend_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxPagePrefer1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxFriendLocation3_Enter(object sender, EventArgs e)
        {

        }

        private void postMatchTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMatchPost_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void loveFinderTriviaStatisticBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listBoxScoreHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
