using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace TeamBuilding.Tabs
{
    public partial class ActivityTab : UserControl
    {
        public TeamBuildingEntities TeamBuildingEntities =Connection.Instance();
        public ObservableCollection<Users> UsersList = new ObservableCollection<Users>();
        public ObservableCollection<LikedProjects> LikedProjects = new ObservableCollection<LikedProjects>();
        public Users _user = null;

        private List<ListBox> ListBoxes;
        private int selectedUser = StartUp.SelectedUser - 1;
        private int i = 0;

        public ActivityTab()
        {
            InitializeComponent();
        }

        public void LoadProjects(Users user)
        {
           // ProjectTab.Instance.Hide();
            _user = user;
            var chosenUser = user;
            ListBoxes = new List<ListBox>();

            foreach (var control in Controls)
            {
                if (control is ListBox)
                    ListBoxes.Add((ListBox) control);
            }

            foreach (var listBox in ListBoxes)
            {
                listBox.Items.Clear();
            }

            try
            {
                foreach (var project in chosenUser.Projects2)
                {
                    listBox1.Items.Add(project.PrjtName);
                }

                foreach (var project in chosenUser.Projects1)
                {
                    listBox2.Items.Add(project.PrjtName);
                }

                var list = TeamBuildingEntities.LikedProjects.Where(b => b.LkdUserId == chosenUser.UsrId);
                foreach (var project in list)
                {
                    listBox3.Items.Add(TeamBuildingEntities.Projects.Where(g=>g.PrjtId==project.LkdPrjtId).First().PrjtName);
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                _user.Projects2.Remove(_user.Projects2.ToList()[listBox1.SelectedIndex]);
                TeamBuildingEntities.SaveChanges();
                LoadProjects(_user);
            }

            catch (Exception)
            {
                MessageBox.Show("Choose a project");
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                //Controls.Add(ProjectTab.Instance);
               // ProjectTab.Instance.Dock = DockStyle.Fill;
               // ProjectTab.Instance.BringToFront();
            }

            catch (Exception)
            {
                MessageBox.Show("Choose a project");
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                TeamBuildingEntities.Skills.ToList()[selectedUser].Projects.Remove(
                    _user.Projects.ToList()[listBox2.SelectedIndex]);
                TeamBuildingEntities.Projects.Remove(
                    _user.Projects.ToList()[listBox2.SelectedIndex]);
                TeamBuildingEntities.SaveChanges();
                LoadProjects(_user);
            }

            catch (Exception)
            {
                MessageBox.Show("Choose a project");
            }
        }
    }
}