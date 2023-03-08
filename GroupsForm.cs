using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;
using System.Collections.Generic;


namespace BasicFacebookFeatures
{
    public partial class GroupsForm : Form
    {
        readonly User m_LoggedInUser;

        public GroupsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
        }

        public ICollection<Group> GetUserGroups()
        {
            return m_LoggedInUser.Groups;
        }

        private void fetchGroups()
        {
   
            listBoxGroups.Invoke(new Action(() =>
            {
                listBoxGroups.DisplayMember = "Name";
                try
                {
                    listBoxGroups.DataSource = GetUserGroups();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to load groups.");
                }
            }));
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_LoggedInUser == null)
            {
                MessageBox.Show("No logged in user");
                Close();
            }

            new Thread(fetchGroups).Start();
        }
        private void FormGroups_Load(object sender, EventArgs e)
        {
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectedGroup;

            if (1 == listBoxGroups.SelectedItems.Count)
            {
                selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }

        private void pictureBoxGroup_Click(object sender, EventArgs e)
        {

        }

        private void backGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleGroup_Click(object sender, EventArgs e)
        {

        }
    }
}
