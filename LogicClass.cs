using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class LogicClass
    {
        public LoveFinder LoveFinder { get; set; }
        public FormCheckInReviwes CheckIn { get; set; }
        
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        private LogicClass()
        {
            LoveFinder = new LoveFinder();
            CheckIn = new FormCheckInReviwes();
        }

        public User LoggedInUser 
        {
            get
            {
                return m_LoggedInUser;
            }
            set
            {
                if (value != null)
                {
                    //this.m_LoginResult = value;
                    this.m_LoggedInUser = this.LoginResult.LoggedInUser;
                }
            }
        }

        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }

            set
            {
                if (value != null)
                {
                    this.m_LoginResult = value;
                    this.m_LoggedInUser = this.LoginResult.LoggedInUser;
                }
            }
        }

        public LoginResult Login()
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "417946052800966",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos",
                    "groups_access_member_info");


            m_LoggedInUser = LoginResult.LoggedInUser;
            LoveFinder.LoggedInUser = m_LoggedInUser;
            CheckIn.LoggedInUser = m_LoggedInUser;

            return LoginResult;
        }

        public void Logout()
        {
            FacebookService.LogoutWithUI();
        }

        public string removeUserFullName()
        {
            return "Login";
        }
        public string GetUserFullName()
        {
           // return this.m_LoggedInUser.Name;
             return $"Logged in as {this.LoggedInUser.Name}";
        }

        public string GetUserProfilePictureNormal()
        {
            return this.m_LoggedInUser.PictureNormalURL;
        }

        public GroupsForm GetUserGroups()
        {
            if (m_LoggedInUser != null)
            {
                return new GroupsForm(m_LoggedInUser);
                //openChildForm(groups, sender);
            }
            else
            {
                return null;
            }
        }

        public FormEvents GetUserEvents()
        {
            if (m_LoggedInUser != null)
            {
                return new FormEvents(m_LoggedInUser);
                //openChildForm(groups, sender);
            }
            else
            {
                return null;
            }
        }

        public FormLikedPages GetLikedPages()
        {
            if (m_LoggedInUser != null)
            {
                return new FormLikedPages(m_LoggedInUser);
            }
            else
            {
                return null;
            }
        }

        public AlbumsForm GetUserAlbums()
        {
            if (m_LoggedInUser != null)
            {
                return new AlbumsForm(m_LoggedInUser);
            }
            else
            {
                return null;
            }
        }


        public PostsForm GetUserPosts()
        {
            if (m_LoggedInUser != null)
            {
                return new PostsForm(m_LoggedInUser);
            }
            else
            {
                return null;
            }

        }

        public LoveFinder GetUserLoveFinder()
        {
            if (m_LoggedInUser != null)
            {
                return new LoveFinder(m_LoggedInUser);
            }
            else
            {
                return null;
            }
        }

        public FormCheckInReviwes GetUserFormCheckIn()
        {
            if (m_LoggedInUser != null)
            {
                return new FormCheckInReviwes(m_LoggedInUser);
            }
            else
            {
                return null;
            }
        }
   
    }
}
