using System;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing.Drawing2D;

namespace BasicFacebookFeatures
{
    public partial class AlbumsForm : Form
    {
        private readonly User m_LoggedInUser;

        public AlbumsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
        }

        public ICollection<Album> GetUserAlbums()
        {
            return this.m_LoggedInUser.Albums;
        }

        public Image GetAlbumProfilePictureByAlbumIndex(int i_SelectedAlbumIndex)
        {
            return this.m_LoggedInUser.Albums[i_SelectedAlbumIndex].ImageAlbum;
        }

        private void loadAlbumProfilePicture()
        {
            try
            {
                if (listBoxAlbums.SelectedIndex >= 0)
                {
                    pictureBoxAlbum.Image = GetAlbumProfilePictureByAlbumIndex(listBoxAlbums.SelectedIndex);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to load selected album profile picture.");
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_LoggedInUser == null)
            {
                MessageBox.Show("No logged in user");
                Close();
            }

            new Thread(AlbumsUpdate).Start();
        }

        public void AlbumsUpdate()
        {
            listBoxAlbums.Invoke(new Action(() =>
            {
                listBoxAlbums.DisplayMember = "Name";
                try
                {
                    albumBindingSource.DataSource = GetUserAlbums();
                    loadAlbumProfilePicture();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to load groups.");
                }
            }));
        }

        private void formBasicFacebook_Load(object sender, EventArgs e)
        {
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxAlbum.Image = pictureBoxAlbum.ErrorImage;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
