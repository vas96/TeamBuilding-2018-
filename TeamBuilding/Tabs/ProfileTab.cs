using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace TeamBuilding.Tabs
{
    public partial class ProfileTab : UserControl
    {
        public TeamBuildingEntities TeamBuildingEntities =Connection.Instance();
        public ObservableCollection<Users> UsersList;
        public Users _user = null;

        public ProfileTab()
        {
            InitializeComponent();
        }

        public bool LoadUserData(Users user)
        {
            try
            {
                _user = user;
                Avatar.Image = new Bitmap(@"Pictures\" + _user.PicturePath);
                UserName.Text = _user.Name+" "+_user.LastName;
                JoinIn.Text = "Joined: " + _user.Registered;
                MyProjects.Text = "Project counter: " + _user.Projects1.Count;
                BioField.Text = _user.Bio;
                ClassList.Items.Clear();
                foreach (var Class in _user.Classes)
                {
                    ClassList.Items.Add(Class.ClassName);
                }
                SkillsList.Items.Clear();
                foreach (var skills in _user.Skills)
                {
                    SkillsList.Items.Add(skills.SklName);
                }
                try
                {
                    var userContacts = user.Contacts;
                    {
                        if (userContacts.PublicMail != null)
                            Contacts.Text = "Contacts: Email: " + userContacts.PublicMail + "; ";
                        if (userContacts.Facebook != null)
                            Contacts.Text += "Facebook: " + userContacts.Facebook + "; ";
                        if (userContacts.VKId != null)
                            Contacts.Text += "VK: " + userContacts.VKId + "; ";
                        if (userContacts.Linkedin != null)
                            Contacts.Text += "LinkedIn: " + userContacts.Linkedin + "; ";
                    }
                }

                catch (Exception)
                {
                    Contacts.Text = "Contacts: none";
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            return true;
        }

        public void LoadInfo(Users tag, UserListTab userListTab)
        {
            LoadUserData(tag);
            Settings.Visible = false;
            CreateProject.Visible = false;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            ProjectTab tab = new ProjectTab(this);
            tab.Visible = true;
            tab.StartInfo();
            Controls.Add(tab);
            tab.Dock = DockStyle.Fill;
            tab.BringToFront();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SettingTab tab=new SettingTab(_user,this);
            tab.Visible = true;
            tab.StartInfo();
            Controls.Add(tab);
            tab.Dock = DockStyle.Fill;
            tab.BringToFront();
        }
    }
}