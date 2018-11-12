using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using TeamBuilding.Tabs;

namespace TeamBuilding
{
    public partial class SettingTab : UserControl
    {
        public TeamBuildingEntities TeamBuildingEntities =Connection.Instance();
        public ObservableCollection<Users> UsersList;
        public Users _user = null;
        private static SettingTab _instance;
        private Panel _currentPanel;
        private String _imagePath = "";
        private Projects ExistedProject = null;
        private Projects _newProject;
        private ProfileTab _tab = null;

        /*
        public static SettingTab Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SettingTab();
                return _instance;
            }
        }
        */

        public SettingTab(Users user, ProfileTab tab)
        {
            InitializeComponent();
            _user = user;
            _currentPanel = panel1;
            _tab = tab;
        }

        private void bunifuThinButton21_Click(object sender, System.EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                panel2.Visible =
                    panel3.Visible =
                        panel4.Visible =
                            panel5.Visible = false;
                if (_currentPanel == panel1 && NameField.Text != "" && SurNameField.Text != "")
                {
                    bunifuTransition1.HideSync(panel1);
                    panel1.Visible = false;

                    panel2.Location = panel1.Location;

                    bunifuTransition1.ShowSync(panel2);
                    _currentPanel = panel2;
                }

                else if (_currentPanel == panel2 && EmailField.Text != "")
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

                    ActionButton.ButtonText = "Finish";
                }

                else if (_currentPanel == panel5 && SkillsList.Items.Count > 0)
                {
                    MessageBox.Show("Ваші персональні дані змінено!");
                    Visible = false;
                    UpdateData();
                    Clear_fields();
                    _tab.LoadUserData(_user);
                }
            }

            catch (Exception exception)
            {
                Clear_fields();
                _currentPanel = panel1;
                MessageBox.Show(exception.ToString());
            }
        }

        public void Clear_fields()
        {
            NameField.Text = "";
            SurNameField.Text = "";
            EmailField.Text = "";
            BioField.Text = "";
            ActionButton.ButtonText = "Next step";
        }

        private void UpdateData()
        {
            _user.Name = NameField.Text;
            _user.LastName = SurNameField.Text;
            _user.RegMail = EmailField.Text;
            _user.Bio = BioField.Text;
            _user.Classes.Clear();
            _user.Skills.Clear();
            if (_imagePath!=_user.PicturePath)
                if (File.Exists(openFileDialog1.FileName))
                {
                    Image Img = new Bitmap(openFileDialog1.FileName);
                    Img.Save(@"Pictures\" + openFileDialog1.SafeFileName);
                    _user.PicturePath = openFileDialog1.SafeFileName;
                }
            for (int i = 0; i < SkillsList.Items.Count; i++)
            {
                Skills skill;
                var check = TeamBuildingEntities.Skills.ToList().Where(k => k.SklName == SkillsList.Items[i].ToString());
                if (check.ToList().Count > 0)
                {
                    _user.Skills.Add(check.ToList()[0]);
                }
                else
                {
                    TeamBuildingEntities.Skills.Add(new Skills()
                    {
                        Projects = new List<Projects>(),
                        SklId = TeamBuildingEntities.Skills.Count() + 1,
                        SklName = SkillsList.Items[i].ToString(),
                        Users = new List<Users>()
                    });
                    //TeamBuildingEntities.SaveChanges();
                    _user.Skills.Add(TeamBuildingEntities.Skills.ToList().Last());
                }
            }

            for (int i = 0; i < ClassList.Items.Count; i++)
                if (ClassList.GetItemChecked(i))
                    _user.Classes.Add(TeamBuildingEntities.Classes.ToList()[i]);
            //TeamBuildingEntities.Entry(TeamBuildingEntities.Users).State=EntityState.Modified;
            TeamBuildingEntities.SaveChanges();
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
                _imagePath = _user.PicturePath;
                SkillsList.Items.Clear();
                NameField.Text = _user.Name;
                SurNameField.Text = _user.LastName;
                EmailField.Text = _user.RegMail;
                BioField.Text = _user.Bio;
                ClassList.Items.Clear();
                foreach (var clas in TeamBuildingEntities.Classes)
                {
                    ClassList.Items.Add(clas.ClassName);
                }
                for (int i = 0; i < _user.Classes.Count; i++)
                {
                    ClassList.SetItemChecked(_user.Classes.ToList()[i].ClassId - 1, true);
                }
                foreach (var VARIABLE in _user.Skills)
                {
                    SkillsList.Items.Add(VARIABLE.SklName);
                }
                Picture.Image = new Bitmap(@"Pictures\"+_user.PicturePath);
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (SkillField.Text != "")
            {
                SkillsList.Items.Add(SkillField.Text);
                SkillField.Text = "";
            }
            else
            {
                MessageBox.Show("Type a skill");
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (SkillsList.SelectedIndex > -1)
            {
                SkillsList.Items.RemoveAt(SkillsList.SelectedIndex);
                SkillsList.SelectedIndex = -1;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}