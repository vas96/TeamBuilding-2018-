using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace TeamBuilding.Tabs
{
    public partial class ProjectInfo : UserControl
    {
        public TeamBuildingEntities TeamBuildingEntities =Connection.Instance();
        public ObservableCollection<Users> UsersList;
        public Projects _project = null;
        public ProjectListTab _Project_tab = null;
        public SearchTab _Search_tab = null;

        public ProjectInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(Projects project, ProjectListTab tab)
        {
            _Project_tab = tab;
            _project = project;
            LoadProjectData();
        }
        public void LoadInfo(Projects project, SearchTab tab)
        {
            _Search_tab = tab;
            _project = project;
            LoadProjectData();
        }

        public bool LoadProjectData()
        {
            try
            {
                picture.Image = new Bitmap(@"Pictures\" + _project.PrjtImagePath);
                NameBox.Text = _project.PrjtName;
                CreatedBox.Text = "Created: " + _project.PrjtCreated;
                DescriptionField.Text = _project.PrjtDescription;
                ClassList.Items.Clear();
                foreach (var Class in _project.PrjtClasses)
                {
                    ClassList.Items.Add(Class.Classes.ClassName);
                }
                SkillsList.Items.Clear();
                foreach (var skills in _project.Skills)
                {
                    SkillsList.Items.Add(skills.SklName);
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }

            return true;
        }
        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (_Project_tab != null)
            {
                _Project_tab.Controls.Clear();
                _Project_tab.ShowProjects();
            }
            if (_Search_tab != null)
            {
                _Search_tab.Controls.Remove(this);
            }
            Visible = false;
        }
    }
}