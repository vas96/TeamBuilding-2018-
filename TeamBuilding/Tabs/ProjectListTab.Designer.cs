namespace TeamBuilding.Tabs
{
    partial class ProjectListTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectListTab));
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.NotLikedProject = new ns1.BunifuImageButton();
            this.LikedProject = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.NotLikedProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikedProject)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(294, 23);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(119, 22);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Усі проекти";
            // 
            // NotLikedProject
            // 
            this.NotLikedProject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NotLikedProject.BackColor = System.Drawing.Color.Transparent;
            this.NotLikedProject.Image = ((System.Drawing.Image)(resources.GetObject("NotLikedProject.Image")));
            this.NotLikedProject.ImageActive = null;
            this.NotLikedProject.Location = new System.Drawing.Point(650, 15);
            this.NotLikedProject.Name = "NotLikedProject";
            this.NotLikedProject.Size = new System.Drawing.Size(30, 30);
            this.NotLikedProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NotLikedProject.TabIndex = 8;
            this.NotLikedProject.TabStop = false;
            this.NotLikedProject.Visible = false;
            this.NotLikedProject.Zoom = 15;
            this.NotLikedProject.Click += new System.EventHandler(this.Like_project);
            // 
            // LikedProject
            // 
            this.LikedProject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LikedProject.BackColor = System.Drawing.Color.Transparent;
            this.LikedProject.Image = ((System.Drawing.Image)(resources.GetObject("LikedProject.Image")));
            this.LikedProject.ImageActive = null;
            this.LikedProject.Location = new System.Drawing.Point(615, 15);
            this.LikedProject.Name = "LikedProject";
            this.LikedProject.Size = new System.Drawing.Size(30, 30);
            this.LikedProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LikedProject.TabIndex = 9;
            this.LikedProject.TabStop = false;
            this.LikedProject.Visible = false;
            this.LikedProject.Zoom = 15;
            // 
            // ProjectListTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LikedProject);
            this.Controls.Add(this.NotLikedProject);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "ProjectListTab";
            this.Size = new System.Drawing.Size(700, 983);
            ((System.ComponentModel.ISupportInitialize)(this.NotLikedProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikedProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuImageButton NotLikedProject;
        private ns1.BunifuImageButton LikedProject;
    }
}