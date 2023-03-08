using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing.Drawing2D;

namespace BasicFacebookFeatures
{
    public partial class FormLikedPages : Form
    {
        readonly User m_LoggedInUser;

        public FormLikedPages(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_LoggedInUser == null)
            {
                MessageBox.Show("No logged in user");
                Close();
            }

            new Thread(fetchLikedPages).Start();
        }

        public ICollection<Page> GetLikedPages()
        {
            return this.m_LoggedInUser.LikedPages;
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Invoke(new Action(() =>
            {
                listBoxLikedPages.DisplayMember = "Name";
                try
                {
                    listBoxLikedPages.DataSource = GetLikedPages();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to load liked pages.");
                }
            }));
        }

        private void formLikedPages_Load(object sender, EventArgs e)
        {
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (1 == listBoxLikedPages.SelectedItems.Count)
            {
                Page selectedPage = listBoxLikedPages.SelectedItem as Page;
                pictureBoxPage.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void pictureBoxPage_Click(object sender, EventArgs e)
        {
        }

        private void backGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleLikedPages_Click(object sender, EventArgs e)
        {

        }
    }
}
