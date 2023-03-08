using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookDesktopAppLogic;
namespace BasicFacebookFeatures
{
    public partial class FormCheckInReviwes : Form
    {
        readonly User m_LoggedInUser;
        readonly CheckInReviewsLogic m_CheckInReviewsLogic;
        readonly List<User> m_ListOfFriendSameCheckIn = new List<User>();
        readonly Group m_Group = new Group();
        string m_FileNameForUpdate;

        public User LoggedInUser { get; set; }
        internal FormCheckInReviwes()
        {
        }

        public FormCheckInReviwes(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_CheckInReviewsLogic = new CheckInReviewsLogic(m_LoggedInUser);
        }

        private void formCheckIn_Load(object sender, EventArgs e)
        {
        }

        private void background_Paint(object sender, PaintEventArgs e)
        {
        }

        private void checkInStart_Click(object sender, EventArgs e)
        {
            if (button5.Enabled)
            {
                label13.Text = m_LoggedInUser.Name;
                pictureBox1.LoadAsync(m_LoggedInUser.PictureNormalURL);
                checkIn.Text = m_LoggedInUser.Checkins[0].ToString();
                listFriend_SelectedIndexChanged(sender, e);
                button5.Enabled = false;
            }
        }

        private void scoreOnPlace_ValueChanged(object sender, EventArgs e)
        {
        }

        private void backGround2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (postofscore.Text != null)
            {
                postofscore_SelectedIndexChanged(sender, e);
                button8.Enabled = false;
                button8.Visible = false;
                scoreOnPlace.Enabled = false;
                checkBox2.Enabled = false;
            }
            else
            {
                button8.Enabled = false;
                button8.Visible = false;
            }
        }

        private void postofscore_SelectedIndexChanged(object sender, EventArgs e)
        {
            string score;
            string recommend;
            string text;

            try
            {
                postofscore.Items.Clear();
                score = scoreOnPlace.Value.ToString();
                recommend = "do not recommend";
                if (checkBox2.Checked)
                {
                    recommend = "recommend";
                }

                text = string.Format(
                    "My score on my last experience at {0} is:" +
                    " {1}." +
                    " And in general I {2} this place ", m_LoggedInUser.Checkins[0].Place.Name, score, recommend);
                postofscore.Items.Add(text);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to post in group of user friends.");
            }
        }

        private void buttonAddPic_Click(object sender, EventArgs e)
        {
            if (button7.Enabled)
            {
                openFileDialog1.ShowDialog();
                m_FileNameForUpdate = openFileDialog1.FileName;
                pictureBox2.LoadAsync(m_FileNameForUpdate);
                pictureBox2.Enabled = false;
            }
        }

        void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                m_CheckInReviewsLogic.PostReview(pictureBox2.Enabled, postofscore.Text, m_FileNameForUpdate);
            }
            catch
            {
                button7.Enabled = false;
                button6.Visible = false;
            }
        }

        private void listFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isEmpty = true;
            bool wasShow = false;

            listFriend.Items.Clear();
            foreach (User user in m_LoggedInUser.Friends)
            {
                foreach (Checkin checkin in user.Checkins)
                {
                    if (checkin.Place != null)
                    {
                        if (checkin.Place.Name.Equals(m_LoggedInUser.Checkins[0].Place.Name) && !wasShow)
                        {
                            m_ListOfFriendSameCheckIn.Add(user);
                            listFriend.Items.Add(user.Name);
                            isEmpty = false;
                            wasShow = true;
                        }
                    }
                }

                wasShow = false;
            }

            if (listFriend.Items.Count == 0)
            {
                MessageBox.Show("No friends with same check in :(");
            }

            listFriend.Enabled = false;
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

        private void checkRecommend_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
        }

        private void backGround1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void listOfFriendTitle_Click(object sender, EventArgs e)
        {
        }

        private void rateScoreTitle_Click(object sender, EventArgs e)
        {
        }

        private void reviewCheckIn_Click(object sender, EventArgs e)
        {
        }

        private void postofscore_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void nameUserProfile_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {

        }

        private void checkInTitle_Click(object sender, EventArgs e)
        {

        }

        private void backGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recommendTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPlace_Click(object sender, EventArgs e)
        {

        }

        private void titlePost_Click(object sender, EventArgs e)
        {

        }
    }
}