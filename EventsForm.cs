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
    public partial class FormEvents : Form
    {
        private readonly User m_LoggedInUser;

        public FormEvents(User i_LoggedInUser)
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

            new Thread(fetchEvents).Start();
        }

        public ICollection<Event> GetEvents()
        {
            return this.m_LoggedInUser.Events;
        }

        private void fetchEvents()
        {
            listBoxEvents.Invoke(new Action(() =>
            {
                listBoxEvents.DisplayMember = "Name";
                try
                {
                   listBoxEvents.DataSource = GetEvents();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to load liked pages.");
                }
            }));
        }
        

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (1 == listBoxEvents.SelectedItems.Count)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                pictureBoxEvent.LoadAsync(selectedEvent.Cover.SourceURL);
            }
        }

        private void formEvents_Load(object sender, EventArgs e)
        {
        }

        private void pictureBoxEvent_Click(object sender, EventArgs e)
        {
        }

        private void labeEvent_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
