namespace TeamBuilding.Tabs
{
    partial class ProjectInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectInfo));
            this.picture = new System.Windows.Forms.PictureBox();
            this.DescriptionField = new System.Windows.Forms.RichTextBox();
            this.DescriptionBox = new ns1.BunifuCustomLabel();
            this.ClassList = new System.Windows.Forms.ListBox();
            this.SkillsList = new System.Windows.Forms.ListBox();
            this.NeedBox = new ns1.BunifuCustomLabel();
            this.SkillsBox = new ns1.BunifuCustomLabel();
            this.CreatedBox = new ns1.BunifuCustomLabel();
            this.CloseButton = new ns1.BunifuThinButton2();
            this.NameBox = new ns1.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(139, 101);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(459, 257);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 7;
            this.picture.TabStop = false;
            // 
            // DescriptionField
            // 
            this.DescriptionField.Location = new System.Drawing.Point(98, 410);
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.ReadOnly = true;
            this.DescriptionField.Size = new System.Drawing.Size(524, 142);
            this.DescriptionField.TabIndex = 13;
            this.DescriptionField.Text = "";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.AutoSize = true;
            this.DescriptionBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionBox.ForeColor = System.Drawing.Color.Black;
            this.DescriptionBox.Location = new System.Drawing.Point(355, 374);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(60, 23);
            this.DescriptionBox.TabIndex = 14;
            this.DescriptionBox.Text = "Опис";
            // 
            // ClassList
            // 
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Location = new System.Drawing.Point(98, 623);
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(230, 160);
            this.ClassList.TabIndex = 15;
            // 
            // SkillsList
            // 
            this.SkillsList.FormattingEnabled = true;
            this.SkillsList.Location = new System.Drawing.Point(392, 623);
            this.SkillsList.Name = "SkillsList";
            this.SkillsList.Size = new System.Drawing.Size(230, 160);
            this.SkillsList.TabIndex = 16;
            // 
            // NeedBox
            // 
            this.NeedBox.AutoSize = true;
            this.NeedBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NeedBox.ForeColor = System.Drawing.Color.Black;
            this.NeedBox.Location = new System.Drawing.Point(144, 584);
            this.NeedBox.Name = "NeedBox";
            this.NeedBox.Size = new System.Drawing.Size(140, 23);
            this.NeedBox.TabIndex = 17;
            this.NeedBox.Text = "Нам потрібні:";
            // 
            // SkillsBox
            // 
            this.SkillsBox.AutoSize = true;
            this.SkillsBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkillsBox.ForeColor = System.Drawing.Color.Black;
            this.SkillsBox.Location = new System.Drawing.Point(420, 584);
            this.SkillsBox.Name = "SkillsBox";
            this.SkillsBox.Size = new System.Drawing.Size(190, 23);
            this.SkillsBox.TabIndex = 18;
            this.SkillsBox.Text = "Необхідні навички:";
            // 
            // CreatedBox
            // 
            this.CreatedBox.AutoSize = true;
            this.CreatedBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatedBox.ForeColor = System.Drawing.Color.Black;
            this.CreatedBox.Location = new System.Drawing.Point(36, 18);
            this.CreatedBox.Name = "CreatedBox";
            this.CreatedBox.Size = new System.Drawing.Size(76, 19);
            this.CreatedBox.TabIndex = 19;
            this.CreatedBox.Text = "Created:";
            // 
            // CloseButton
            // 
            this.CloseButton.ActiveBorderThickness = 1;
            this.CloseButton.ActiveCornerRadius = 1;
            this.CloseButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.CloseButton.ActiveForecolor = System.Drawing.Color.White;
            this.CloseButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.ButtonText = "Вихід";
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.CloseButton.IdleBorderThickness = 1;
            this.CloseButton.IdleCornerRadius = 1;
            this.CloseButton.IdleFillColor = System.Drawing.Color.White;
            this.CloseButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.CloseButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(175)))), ((int)(((byte)(113)))));
            this.CloseButton.Location = new System.Drawing.Point(296, 791);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(119, 40);
            this.CloseButton.TabIndex = 20;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.NameBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.NameBox.BorderThickness = 3;
            this.NameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameBox.Enabled = false;
            this.NameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameBox.isPassword = false;
            this.NameBox.Location = new System.Drawing.Point(139, 50);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(459, 44);
            this.NameBox.TabIndex = 21;
            this.NameBox.Text = "bunifuMetroTexxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxtbox1";
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CreatedBox);
            this.Controls.Add(this.SkillsBox);
            this.Controls.Add(this.NeedBox);
            this.Controls.Add(this.SkillsList);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.DescriptionField);
            this.Controls.Add(this.picture);
            this.Name = "ProjectInfo";
            this.Size = new System.Drawing.Size(700, 854);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.RichTextBox DescriptionField;
        private ns1.BunifuCustomLabel DescriptionBox;
        private System.Windows.Forms.ListBox ClassList;
        private System.Windows.Forms.ListBox SkillsList;
        private ns1.BunifuCustomLabel NeedBox;
        private ns1.BunifuCustomLabel SkillsBox;
        private ns1.BunifuCustomLabel CreatedBox;
        private ns1.BunifuThinButton2 CloseButton;
        private ns1.BunifuMetroTextbox NameBox;
    }
}
