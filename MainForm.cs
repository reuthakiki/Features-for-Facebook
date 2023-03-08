using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing.Drawing2D;
using System.Threading;
using Singleton;
namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
         User m_LoggedInUser;
        private readonly LoginConnect r_FacebookAppLogic = Singleton<LoginConnect>.Instance;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(this.pictureProfile.DisplayRectangle);
            this.pictureProfile.Region = new Region(gp);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void logout()
        {

            while (m_LoggedInUser != null)
            {
                try
                {
                    r_FacebookAppLogic.Logout();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured while Logout .\nPlease try again");
                }
            }
 
            if (m_LoggedInUser == null)
            {
                buttonLogout.Text = r_FacebookAppLogic.RemoveUserFullName();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void login()
        {
            LoginResult result = null;

            while (result == null)
            {
                try
                {
                    result = r_FacebookAppLogic.Login();
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured while loggin in.\nPlease try again");
                }
            }

            buttonLogin.Text = r_FacebookAppLogic.GetUserFullName();
            if (result.LoggedInUser != null)
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
        }

        private void fetchUserInfo()
        {
            pictureProfile.LoadAsync(r_FacebookAppLogic.GetUserProfilePictureNormal());
        }

        private void openChildForm(Form i_childForm, object sender)
        {
            i_childForm.TopLevel = false;
            i_childForm.FormBorderStyle = FormBorderStyle.None;
            i_childForm.Dock = DockStyle.Fill;
            this.panelDekstop.Controls.Add(i_childForm);
            this.panelDekstop.Tag = i_childForm;
            i_childForm.BringToFront();
            i_childForm.Show();
        }

        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
        }

        private void buttonFetchGroups_Click(object sender, System.EventArgs e)
        {
            GroupsForm groups;

            groups = r_FacebookAppLogic.GetUserGroups();
            if (groups != null)
            {
                openChildForm(groups, sender);
            }
           
        }

        private void buttonFetchEvents_Click(object sender, System.EventArgs e)
        {
            FormEvents events;

            events = r_FacebookAppLogic.GetUserEvents();
            if (events != null)
            {
                openChildForm(events, sender);
            }
          
        }

        private void buttonFetchLikedPages_Click(object sender, System.EventArgs e)
        {
            FormLikedPages liedPages;

            liedPages = r_FacebookAppLogic.GetLikedPages();
            if(liedPages != null)
            {
                openChildForm(liedPages, sender);
            }

        }

        private void buttonFetchAlbums_Click(object sender, System.EventArgs e)
        {
            AlbumsForm albums;

            albums = r_FacebookAppLogic.GetUserAlbums();
            if (albums != null)
            {
                openChildForm(albums, sender);
            }

        }

        private void buttonPosts_Click(object sender, System.EventArgs e)
        {
            PostsForm posts;

            posts = r_FacebookAppLogic.GetUserPosts();
            if (posts != null)
            {
                openChildForm(posts, sender);
            }

        }

        private void buttonLoveFinder_Click(object sender, System.EventArgs e)
        {
            LoveFinder loveFinder;

            loveFinder = r_FacebookAppLogic.GetUserLoveFinder();
            if (loveFinder != null)
            {
                openChildForm(loveFinder, sender);
            }

        }


        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            FormCheckInReviwes check;

            check = r_FacebookAppLogic.GetUserFormCheckIn();
            if (check != null)
            {
                openChildForm(check, sender);
            }

        }

        private void panelDekstop_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureProfile_Click(object sender, EventArgs e)
        {
        }

        private void backGround_Paint(object sender, PaintEventArgs e)
        {
        }

        private void facebookTitle_Click(object sender, EventArgs e)
        {
        }
    }
}
