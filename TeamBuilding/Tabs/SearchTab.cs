using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ns1;

namespace TeamBuilding.Tabs
{
    public partial class SearchTab : UserControl
    {
        private TeamBuildingEntities connection = Connection.Instance();
        public SearchTab()
        {
            InitializeComponent();
        }

        private void Like_project(object sender, EventArgs e)
        {
            BunifuImageButton button = sender as BunifuImageButton;

            if (button==NotLikedProject)
            {
                button.Image = LikedProject.Image;
            }
            else
            {
                button.Image = NotLikedProject.Image;
            }
        }

        private void GetProfileInfo(object sender, object e)
        {
            ProjectInfo tab = new ProjectInfo();
            tab.Visible = true;
            tab.LoadInfo((Projects)(sender as BunifuThinButton2).Tag, this);
            Controls.Add(tab);
            tab.Dock = DockStyle.Fill;
            tab.BringToFront();
        }

        public void SearchField_KeyUp(object sender, KeyEventArgs e)
        {
            while (Controls.Count > 1)
            {
                Control cnt = Controls[Controls.Count - 1];
                if (cnt.Name != "Panel")
                    Controls.Remove(cnt);
            }
            string find_string = SearchField.Text.ToUpper();
            if (find_string != "")
            {
                List<Projects> Find_projects =
                    connection.Projects.ToList().Where(l => l.PrjtName.ToUpper().Contains(find_string)).ToList();
                if (Find_projects.Any())
                {
                    var thinButtonY = 345;
                    var pictureBoxY = 95;
                    var separatorY = 345;
                    var customLabelY = 420;
                    var likeButtonY = 405;
                    foreach (var project in Find_projects)
                    {
                        BunifuThinButton2 thinButton = new BunifuThinButton2 {Name = "thinButton" + project.PrjtId};
                        thinButton.ButtonText = project.PrjtName;
                        thinButton.Size = new Size(655, 55);
                        thinButton.IdleLineColor = Color.White;
                        thinButton.IdleCornerRadius = 1;
                        thinButton.IdleForecolor = Color.Black;
                        thinButton.ActiveCornerRadius = 1;
                        thinButton.ActiveFillColor = Color.White;
                        thinButton.ActiveLineColor = Color.Black;
                        thinButton.ActiveForecolor = Color.FromArgb(12, 185, 102);
                        thinButton.TextAlign = ContentAlignment.MiddleLeft;
                        thinButton.Location = new Point(50, thinButtonY);
                        thinButton.Tag = (object) project;
                        thinButtonY += 400;
                        thinButton.Click += GetProfileInfo;
                        thinButton.Font = new Font("Century Gothic", 12);

                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                        pictureBox.Size = new Size(450, 250);
                        pictureBox.Location = new Point(150, pictureBoxY);
                        if (File.Exists(@"Pictures\" + project.PrjtImagePath))
                            pictureBox.Image = new Bitmap(@"Pictures\" + project.PrjtImagePath);
                        else pictureBox.Image = new Bitmap(@"Pictures\default.jpg");
                        pictureBoxY += 400;

                        BunifuSeparator separator = new BunifuSeparator();
                        separator.Size = new Size(655, 15);
                        separator.LineColor = Color.FromArgb(12, 185, 102);
                        separator.LineThickness = 3;
                        separator.Location = new Point(50, separatorY);
                        separatorY += 400;

                        BunifuCustomLabel customLabel = new BunifuCustomLabel();
                        customLabel.Font = new Font("Century Gothic", 12);
                        customLabel.Text = "Likes: " + project.PjrtLikeCounter;
                        customLabel.Location = new Point(50, customLabelY);
                        customLabelY += 400;

                        BunifuImageButton likeButton = new BunifuImageButton() {Name = "imageButton" + project.PrjtId};
                        likeButton.Zoom = 15;
                        likeButton.Size = new Size(30, 30);
                        likeButton.BackColor = Color.Transparent;
                        likeButton.SizeMode = PictureBoxSizeMode.StretchImage;
                        likeButton.Image = NotLikedProject.Image;
                        likeButton.Location = new Point(675, likeButtonY);
                        likeButtonY += 400;
                        likeButton.Click += new EventHandler(Like_project);

                        Controls.Add(thinButton);
                        Controls.Add(pictureBox);
                        Controls.Add(separator);
                        Controls.Add(customLabel);
                        Controls.Add(likeButton);
                    }
                }
                else
                {
                    BunifuCustomLabel label=new BunifuCustomLabel();
                    label.Text = "Cannot find matches...";
                    label.AutoSize = true;
                    label.Location= new Point(50,95);
                }
            }
        }
    }
}
