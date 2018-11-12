namespace TeamBuilding.Tabs
{
    partial class SearchTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTab));
            this.Panel = new System.Windows.Forms.Panel();
            this.LikedProject = new ns1.BunifuImageButton();
            this.NotLikedProject = new ns1.BunifuImageButton();
            this.SearchField = new ns1.BunifuMaterialTextbox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LikedProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotLikedProject)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.AutoSize = true;
            this.Panel.Controls.Add(this.LikedProject);
            this.Panel.Controls.Add(this.NotLikedProject);
            this.Panel.Controls.Add(this.SearchField);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(700, 83);
            this.Panel.TabIndex = 12;
            // 
            // LikedProject
            // 
            this.LikedProject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LikedProject.BackColor = System.Drawing.Color.Transparent;
            this.LikedProject.Image = ((System.Drawing.Image)(resources.GetObject("LikedProject.Image")));
            this.LikedProject.ImageActive = null;
            this.LikedProject.Location = new System.Drawing.Point(593, -5);
            this.LikedProject.Name = "LikedProject";
            this.LikedProject.Size = new System.Drawing.Size(30, 30);
            this.LikedProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LikedProject.TabIndex = 14;
            this.LikedProject.TabStop = false;
            this.LikedProject.Visible = false;
            this.LikedProject.Zoom = 15;
            // 
            // NotLikedProject
            // 
            this.NotLikedProject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NotLikedProject.BackColor = System.Drawing.Color.Transparent;
            this.NotLikedProject.Image = ((System.Drawing.Image)(resources.GetObject("NotLikedProject.Image")));
            this.NotLikedProject.ImageActive = null;
            this.NotLikedProject.Location = new System.Drawing.Point(628, -5);
            this.NotLikedProject.Name = "NotLikedProject";
            this.NotLikedProject.Size = new System.Drawing.Size(30, 30);
            this.NotLikedProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NotLikedProject.TabIndex = 13;
            this.NotLikedProject.TabStop = false;
            this.NotLikedProject.Visible = false;
            this.NotLikedProject.Zoom = 15;
            // 
            // SearchField
            // 
            this.SearchField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchField.HintForeColor = System.Drawing.Color.Empty;
            this.SearchField.HintText = "Пошук...";
            this.SearchField.isPassword = false;
            this.SearchField.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.SearchField.LineIdleColor = System.Drawing.Color.Gray;
            this.SearchField.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.SearchField.LineThickness = 3;
            this.SearchField.Location = new System.Drawing.Point(41, 21);
            this.SearchField.Margin = new System.Windows.Forms.Padding(4);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(370, 44);
            this.SearchField.TabIndex = 12;
            this.SearchField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchField_KeyUp);
            // 
            // SearchTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Panel);
            this.Name = "SearchTab";
            this.Size = new System.Drawing.Size(700, 1000);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LikedProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotLikedProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panel;
        private ns1.BunifuImageButton LikedProject;
        private ns1.BunifuImageButton NotLikedProject;
        private ns1.BunifuMaterialTextbox SearchField;
    }
}
