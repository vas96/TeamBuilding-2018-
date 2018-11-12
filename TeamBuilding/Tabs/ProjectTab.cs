using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TeamBuilding.Tabs;

namespace TeamBuilding
{
    public partial class ProjectTab : UserControl
    {
        public TeamBuildingEntities TeamBuildingEntities = Connection.Instance();
        public ObservableCollection<Users> UsersList;

        private static ProjectTab _instance;
        private Panel _currentPanel;
        private String _imagePath = "";
        private Projects ExistedProject = null;
        private Projects _newProject;
        private ProfileTab _tab;
        int index;

        //        public static ProjectTab Instance
        //        {
        //            get
        //            {
        //                if (_instance == null)
        //                    _instance = new ProjectTab(TODO);
        //                return _instance;
        //            }
        //        }

        public ProjectTab(ProfileTab tab)
        {
            _tab = tab;
            InitializeComponent();
            _currentPanel = panel1;
        }

        private void bunifuThinButton21_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (_currentPanel == panel1 && NameField.Text != "")
                {
                    bunifuTransition1.HideSync(panel1);
                    panel1.Visible = false;

                    panel2.Location = panel1.Location;

                    bunifuTransition1.ShowSync(panel2);
                    _currentPanel = panel2;
                }

                else if (_currentPanel == panel2 && DescriptionField.Text != "")
                {
                    bunifuTransition1.HideSync(panel2);
                    panel2.Visible = false;

                    panel3.Location = panel2.Location;

                    bunifuTransition1.ShowSync(panel3);
                    _currentPanel = panel3;
                }

                else if (_currentPanel == panel3)
                {
                    bunifuTransition1.HideSync(panel3);
                    panel3.Visible = false;

                    panel4.Location = panel3.Location;

                    bunifuTransition1.ShowSync(panel4);
                    _currentPanel = panel4;
                }

                else if (_currentPanel == panel4)
                {
                    bunifuTransition1.HideSync(panel4);
                    panel4.Visible = false;

                    panel5.Location = panel4.Location;

                    bunifuTransition1.ShowSync(panel5);
                    _currentPanel = panel5;

                    bunifuThinButton21.ButtonText = "Finish";
                }

                else if (_currentPanel == panel5 && SkillList.Items.Count > 0)
                {
                    MessageBox.Show("Project sueccesfully added");
                    Visible = false;
                    Projects NewProject = CreateBaseForProject();
                    CreateOrUpdate(NewProject);
                    Clear_fields();
                }
            }

            catch (Exception exception)
            {
                Clear_fields();
                MessageBox.Show(exception.ToString());
            }
        }

        public void Clear_fields()
        {
            NameField.Text = "";
            DescriptionField.Text = "";
            bunifuThinButton21.ButtonText = "Next step";
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (File.Exists(openFileDialog1.FileName))
                {
                    Picture.Image = new Bitmap(openFileDialog1.FileName);
                    _imagePath = openFileDialog1.SafeFileName;
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        public void StartInfo()
        {
            try
            {
                foreach (var clas in TeamBuildingEntities.Classes)
                {
                    ClassList.Items.Add(clas.ClassName);
                }
                Picture.Image = new Bitmap(@"Pictures\default.jpg");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != "")
            {
                SkillList.Items.Add(bunifuMaterialTextbox1.Text);
                bunifuMaterialTextbox1.Text = "";
            }
            else
            {
                MessageBox.Show("Type a skill");
            }
        }

        private Projects CreateBaseForProject()
        {
            try
            {
                UsersList = new ObservableCollection<Users>(TeamBuildingEntities.Users);

                int projectId;
                if (ExistedProject == null)
                {

                    var project =
                        TeamBuildingEntities.Projects.FirstOrDefaultAsync();
                    projectId = (project.Result == null) ? 0 : project.Id;
                }
                else
                    projectId = ExistedProject.PrjtId;

                if (!File.Exists(openFileDialog1.FileName) && ExistedProject == null)
                    _imagePath = "default.jpg";

                _newProject = new Projects()
                {
                    PrjtId = projectId,
                    PrjtName = NameField.Text,
                    PrjtDescription = DescriptionField.Text,
                    PrjtCreated =
                        (ExistedProject == null) ? Convert.ToDateTime(DateTime.Today) : ExistedProject.PrjtCreated,
                    PrjtImagePath = _imagePath,
                    PrjtCreatedBy =
                        (ExistedProject == null)
                            ? UsersList[StartUp.SelectedUser - 1].UsrId
                            : ExistedProject.PrjtCreatedBy,
                    PjrtLikeCounter = (ExistedProject == null) ? 0 : ExistedProject.PjrtLikeCounter
                };

                _newProject.Users2.Clear();
                _newProject.Users2.Add(UsersList[StartUp.SelectedUser - 1]);

                if (File.Exists(openFileDialog1.FileName) ||
                    ExistedProject != null && ExistedProject.PrjtImagePath != _imagePath)
                {
                    Image Img = new Bitmap(openFileDialog1.FileName);
                    Img.Save(@"Pictures\" + openFileDialog1.SafeFileName);
                }

                if (ExistedProject != null)
                {
                    ExistedProject.PrjtClasses.Clear();
                    ExistedProject.Skills.Clear();
                }

                for (int i = 0; i < SkillList.Items.Count; i++)
                {
                    Skills skill;
                    var check = TeamBuildingEntities.Skills.ToList().Where(k => k.SklName == SkillList.Items[i].ToString());
                    if (check.ToList().Count > 0)
                    {
                        _newProject.Skills.Add(check.ToList()[0]);
                    }
                    else
                    {
                        TeamBuildingEntities.Skills.Add(new Skills()
                        {
                            Projects = new List<Projects>(),
                            SklId = TeamBuildingEntities.Skills.Count() + 1,
                            SklName = SkillList.Items[i].ToString(),
                            Users = new List<Users>()
                        });
                        TeamBuildingEntities.SaveChanges();
                        _newProject.Skills.Add(TeamBuildingEntities.Skills.ToList().Last());
                    }
                }

                for (int i = 0; i < ClassList.Items.Count; i++)
                    if (ClassList.GetItemChecked(i))
                        _newProject.PrjtClasses.Add(new PrjtClasses()
                        {
                            ClClassId = i,
                            ClPrjtId = _newProject.PrjtId,
                            ClPeopleNeeded = "1",
                            Classes = TeamBuildingEntities.Classes.ToList()[i],
                            Projects = _newProject
                        });
                TeamBuildingEntities.SaveChanges();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            return _newProject;
        }

        private void CreateOrUpdate(Projects newProject)
        {
            if (ExistedProject != null)//якшо обновляєм - то старий видаляєм
                TeamBuildingEntities.Projects.Remove(ExistedProject);
            TeamBuildingEntities.Projects.Add(newProject);
            if (ExistedProject != null)//якшо обновили - то нову ссилку для юзера
                UsersList[StartUp.SelectedUser - 1].Projects1.Add(newProject);
            if (ExistedProject == null)
            {
                UsersList[StartUp.SelectedUser - 1].Projects1.Add(newProject);
            }
            //тово гівно треба для дебага
            try
            {
                TeamBuildingEntities.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show(validationError.PropertyName +
                                        validationError.ErrorMessage);
                    }
                }
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (SkillList.SelectedIndex > -1)
            {
                SkillList.Items.RemoveAt(SkillList.SelectedIndex);
                SkillList.SelectedIndex = -1;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = ClassList.SelectedIndex;

            bunifuTransition1.HideSync(panel4);
            panel4.Visible = false;

            panel5.Location = panel4.Location;

            bunifuTransition1.ShowSync(panel5);
            _currentPanel = panel5;

            bunifuThinButton21.ButtonText = "Finish";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bunifuTransition1.HideSync(panel3);
            panel3.Visible = false;

            panel4.Location = panel3.Location;

            bunifuTransition1.ShowSync(panel4);
            _currentPanel = panel4;

        }
    }
}