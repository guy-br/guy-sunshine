using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace B15_Ex01_Ziv_302678313_Guy_200433423
{
    public partial class FormFaceBookApp : Form
    {
        User m_LoggedInUser;

        public FormFaceBookApp()
        {
            FacebookService.s_CollectionLimit = 250;
            InitializeComponent();
        }

        private void enableAllButtons()
        {
            buttonCheckIn.Enabled = true;
            buttonEvents.Enabled = true;
            buttonNewsFeed.Enabled = true;
            buttonPost.Enabled = true;
            buttonTopCheckIn.Enabled = true;
            buttonUploadPicture.Enabled = true;
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            loginAndInit();
        }
        
        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("438802336275081",
                "user_about_me", "publish_actions", "user_friends", "friends_about_me", "publish_stream", "user_events", "read_stream",
                "user_status", "user_activities", "friends_activities",
                    "user_birthday", "friends_birthday",
                    "user_checkins", "friends_checkins",
                    "user_education_history", "friends_education_history",
                    "user_events", "friends_events",
                    "user_groups" , "friends_groups",
                    "user_hometown", "friends_hometown",
                    "user_interests", "friends_interests",
                    "user_likes", "friends_likes",
                    "user_location", "friends_location",
                    "user_notes", "friends_notes",
                    "user_online_presence", "friends_online_presence",
                    "user_photo_video_tags", "friends_photo_video_tags",
                    "user_photos", "friends_photos",
                    "user_photos", "friends_photos",
                    "user_relationships", "friends_relationships",
                    "user_relationship_details","friends_relationship_details",
                    "user_religion_politics","friends_religion_politics",
                    "user_status", "friends_status",
                    "user_videos", "friends_videos",
                    "user_website", "friends_website",
                    "user_work_history", "friends_work_history",
                    "email",
                    "read_friendlists",
                    "read_insights",
                    "read_mailbox",
                    "read_requests",
                    "read_stream",
                    "xmpp_login",

                    "create_event",
                    "rsvp_event",
                    "sms",
                    "publish_checkins",
                    "manage_friendlists",
                    "manage_pages");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                buttonLogin.Dispose();
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
                enableAllButtons();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
          }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fetchUserInfo()
        {
            profilePic.LoadAsync(m_LoggedInUser.PictureLargeURL);
            profileNameLabel.Text = m_LoggedInUser.Name;
            fetchUserFriendsList();
            fetchUserAbout(labelUserDetails, m_LoggedInUser);
            fetchUserGroupsList();
        }

        private void fetchUserFriendsList()
        {
            listBoxFriends.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
            }
        }

        private void fetchUserAbout(Label i_LabelDetails, User i_User)
        {
            i_LabelDetails.Text = string.Empty;
            if (!string.IsNullOrEmpty(i_User.Email))
            {
                i_LabelDetails.Text += "Email: " + i_User.Email + "\n";
            }

            if (!string.IsNullOrEmpty(i_User.Birthday))
            {
                i_LabelDetails.Text += "Birthday: " + i_User.Birthday + "\n";
            }

            if (!string.IsNullOrEmpty(i_User.Gender.ToString()))
            {
                i_LabelDetails.Text += "Gender: " + i_User.Gender + "\n";
            }

            if (i_User.Educations != null)
            {
                if (!string.IsNullOrEmpty(i_User.Educations[i_User.Educations.Length - 1].School.Name))
                {
                    i_LabelDetails.Text += "Education: " + i_User.Educations[i_User.Educations.Length - 1].School.Name + "\n";
                }
            }

            if (i_User.Hometown != null)
            {
                if (!string.IsNullOrEmpty(i_User.Hometown.Name))
                {
                    i_LabelDetails.Text += "HomeTown: " + i_User.Hometown.Name + "\n";
                }
            }

            if (!string.IsNullOrEmpty(i_User.RelationshipStatus.ToString()))
            {
                i_LabelDetails.Text += i_User.RelationshipStatus.ToString();
            }
        }

        private void fetchUserGroupsList()
        {
            listBoxGroups.DisplayMember = "Name";
            foreach (Group group in m_LoggedInUser.Groups)
            {
                listBoxGroups.Items.Add(group);
            }
        }

        private void labelGroups_Click(object sender, EventArgs e)
        {

        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPicturePath.Text))
            {
                m_LoggedInUser.PostPhoto(textBoxPicturePath.Text, postTextBox.Text);
                textBoxPicturePath.Text = string.Empty;
            }
            else
            {
                m_LoggedInUser.PostStatus(postTextBox.Text);
            }
            if (MessageBox.Show(
                            "Your post has been successfully posted.",
                            "successfully posted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.None) == DialogResult.Cancel)
            {
                this.Close();
            }
            
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            fetchUserEvents();
        }

        private void fetchUserEvents()
        {
            listBoxEvents.DisplayMember = "Name";
            foreach (Event userEvent in m_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(userEvent);
            }
        }

        private void buttonNewsFeed_Click(object sender, EventArgs e)
        {
            fetchUserNewsFeed();
        }

        private void fetchUserNewsFeed()
        {
            foreach (Post post in m_LoggedInUser.NewsFeed)
            {
                if (post.Message != null)
                {
                    listBoxNewsFeed.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxNewsFeed.Items.Add(post.Caption);
                }
                else
                {
                    listBoxNewsFeed.Items.Add(string.Format("[{0}]", post.Type));
                }
            }
        }

        private void displayDetailsOfSelectedFriend(ListBox i_ListBox)
        {
            if (i_ListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = i_ListBox.SelectedItem as User;
                if (selectedFriend.PictureLargeURL != null)
                {
                    pictureBoxObject.LoadAsync(selectedFriend.PictureLargeURL);
                }
                else
                {
                    pictureBoxObject.Image = pictureBoxObject.ErrorImage;
                }
                fetchUserAbout(labelObjectDetail, selectedFriend);
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            fetchUserCheckins();
        }

        private void fetchUserCheckins()
        {
            foreach (Status status in m_LoggedInUser.Statuses)
            {
                if (!String.IsNullOrEmpty(status.ToString()) && status.Place != null)
                {
                    String locationStatus = status + "   at " + status.Place.Location.City + " ," + status.Place.Location.Country;
                    listBoxCheckIns.Items.Add(locationStatus);
                }
            }	
        }

        private struct topCheckInNode
        {
            public String myCity;
            public int count; 

            public topCheckInNode(String i_city)
            {
                this.myCity = i_city;
                this.count = 1;
            }
        }

        private void buttonTopCheckIn_Click(object sender, EventArgs e)
        {
            bool doesCityExists = false;
            List<topCheckInNode> cityListBox = new List<topCheckInNode>();

            //foreach (User friend in m_LoggedInUser.Friends)
            //{
                foreach (Status status in this.m_LoggedInUser.Statuses)
                {
                        if (!String.IsNullOrEmpty(status.ToString()) && status.Place != null)
                        {
                            foreach (topCheckInNode node in cityListBox)
                            {
                                if (status.Place.Location.City == node.myCity && doesCityExists == false)
                                {
                                    doesCityExists = true;
                                    topCheckInNode tempNode = node;
                                    tempNode.count++;
                                   
                                }
                            }
                            if (doesCityExists == false)
                            {
                                topCheckInNode newCityNode = new topCheckInNode(status.Place.Location.City);
                                cityListBox.Add(newCityNode);
                            }
                        }
                    }	 
            //}
            List<topCheckInNode> SortedList = cityListBox.OrderBy(o=>o.count).ToList();

            foreach (topCheckInNode node in SortedList)
            {
                if (!String.IsNullOrEmpty(node.myCity.ToString()))
                {
                    String locationStatus = node.myCity + " , " + node.count + " of your friends been there";
                    listBoxTopCheckin.Items.Add(locationStatus);
                }
            }	
        }

        private void buttonUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPicture = new OpenFileDialog();

            openPicture.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openPicture.ShowDialog() == DialogResult.OK)
            {
                textBoxPicturePath.Text = openPicture.FileName;
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayDetailsOfSelectedFriend(sender as ListBox);
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormGroupDetails groupDetailsForm = new FormGroupDetails(listBoxGroups.SelectedItem as Group);
            groupDetailsForm.ShowDialog();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event facebbokEvent = listBoxEvents.SelectedItem as Event;

            if (facebbokEvent.PictureLargeURL != null)
            {
                pictureBoxObject.LoadAsync(facebbokEvent.PictureLargeURL);
            }
            else
            {
                pictureBoxObject.Image = pictureBoxObject.ErrorImage;
            }

            labelObjectDetail.Text = string.Empty;
            if (!String.IsNullOrEmpty(facebbokEvent.Name))
            {
                labelObjectDetail.Text += "Name: " + facebbokEvent.Name + "\n";
            }

            if (!String.IsNullOrEmpty(facebbokEvent.Description))
            {
                labelObjectDetail.Text += "Description: " + facebbokEvent.Description + "\n"; ;
            }

            if (!String.IsNullOrEmpty(facebbokEvent.StartTime.ToString()))
            {
                labelObjectDetail.Text += "Start Time: " + facebbokEvent.StartTime.ToString() + "\n"; ;
            }

            if (!String.IsNullOrEmpty(facebbokEvent.EndTime.ToString()))
            {
                labelObjectDetail.Text += "End Time: " + facebbokEvent.EndTime.ToString() + "\n"; ;
            }
        }
    }
}
