using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing.Drawing2D;

namespace BasicFacebookFeatures
{
    public partial class PostsForm : Form
    {
        readonly User m_LoggedInUser;

        public PostsForm(User i_LoggedInUser)
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

            new Thread(fetchPosts).Start();
        }

        public ICollection<string> GetUserPosts()
        {
            List<string> posts = new List<string>();

            foreach (Post post in this.m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    posts.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    posts.Add(post.Caption);
                }
                else
                {
                    posts.Add($"A {post.Type} without a message");
                }
            }

            return posts;
        }

        private void fetchPosts()
        {
            try
            {
                ICollection<string> posts = GetUserPosts();

                if (posts.Count == 0)
                {
                    listBoxPosts.Invoke(new Action(() =>
                    {
                        listBoxPosts.Items.Add("No Posts");
                        listBoxPosts.Enabled = false;
                    }));
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.DataSource = posts));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load user posts.");
            }
        }

        private void formPosts_Load(object sender, EventArgs e)
        {
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Status postedStatus;

            try
            {
                postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void backGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private void postTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
