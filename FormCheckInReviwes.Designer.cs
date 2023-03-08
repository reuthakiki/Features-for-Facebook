
namespace BasicFacebookFeatures
{
    partial class FormCheckInReviwes
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listFriend = new System.Windows.Forms.ListBox();
            this.checkIn = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.postofscore = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.scoreOnPlace = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listOfFriend = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreOnPlace)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1465, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.background_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(390, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 62);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check In Review";
            this.label2.Click += new System.EventHandler(this.checkInTitle_Click);
            // 
            // listFriend
            // 
            this.listFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listFriend.FormattingEnabled = true;
            this.listFriend.ItemHeight = 22;
            this.listFriend.Location = new System.Drawing.Point(26, 218);
            this.listFriend.Name = "listFriend";
            this.listFriend.Size = new System.Drawing.Size(281, 246);
            this.listFriend.TabIndex = 35;
            this.listFriend.SelectedIndexChanged += new System.EventHandler(this.listFriend_SelectedIndexChanged);
            // 
            // checkIn
            // 
            this.checkIn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkIn.AutoSize = true;
            this.checkIn.BackColor = System.Drawing.Color.Transparent;
            this.checkIn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn.Location = new System.Drawing.Point(3, 11);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(198, 21);
            this.checkIn.TabIndex = 25;
            this.checkIn.Text = "The last check in of User is:";
            this.checkIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(508, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(320, 40);
            this.button5.TabIndex = 26;
            this.button5.Text = "Click me to see my last check in! :)";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.checkInStart_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1164, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "User name:";
            this.label13.Click += new System.EventHandler(this.nameUserProfile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1124, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 162);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBoxProfile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.postofscore);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.scoreOnPlace);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1465, 616);
            this.panel3.TabIndex = 31;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.backGround2_Paint);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SlateBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(1124, 538);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 43);
            this.button7.TabIndex = 35;
            this.button7.Text = "Post";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(872, 362);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 57);
            this.button6.TabIndex = 34;
            this.button6.Text = "Click to add a photo from check in place";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonAddPic_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(855, 434);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBoxPlace_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(431, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Recommendations post for the group:";
            this.label10.Click += new System.EventHandler(this.titlePost_Click);
            // 
            // postofscore
            // 
            this.postofscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postofscore.FormattingEnabled = true;
            this.postofscore.HorizontalScrollbar = true;
            this.postofscore.ItemHeight = 22;
            this.postofscore.Location = new System.Drawing.Point(435, 434);
            this.postofscore.Name = "postofscore";
            this.postofscore.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.postofscore.Size = new System.Drawing.Size(373, 136);
            this.postofscore.TabIndex = 31;
            this.postofscore.SelectedIndexChanged += new System.EventHandler(this.postofscore_SelectedIndexChanged_1);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(559, 313);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 47);
            this.button8.TabIndex = 27;
            this.button8.Text = "confirm";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(474, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(550, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "Rate the place score according to your recent experience there:";
            this.label12.Click += new System.EventHandler(this.rateScoreTitle_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(478, 257);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(311, 24);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Mark V if recommend, otherwise without";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkRecommend_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(474, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(353, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "In general Do you recommend the place?";
            this.label11.Click += new System.EventHandler(this.recommendTitle_Click);
            // 
            // scoreOnPlace
            // 
            this.scoreOnPlace.BackColor = System.Drawing.Color.LightSteelBlue;
            this.scoreOnPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreOnPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.scoreOnPlace.Location = new System.Drawing.Point(677, 170);
            this.scoreOnPlace.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.scoreOnPlace.Name = "scoreOnPlace";
            this.scoreOnPlace.Size = new System.Drawing.Size(107, 30);
            this.scoreOnPlace.TabIndex = 23;
            this.scoreOnPlace.ValueChanged += new System.EventHandler(this.scoreOnPlace_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lavender;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 90);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1465, 106);
            this.panel4.TabIndex = 32;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.backGround_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1254, 44);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hello Dear User Here you will able to open a Group Review on your last checked in" +
    " with your friends who also checked it in the same place\r\n please push the butto" +
    "n to start !";
            this.label5.Click += new System.EventHandler(this.reviewCheckIn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Lavender;
            this.panel5.Controls.Add(this.listOfFriend);
            this.panel5.Controls.Add(this.listFriend);
            this.panel5.Controls.Add(this.checkIn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 196);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 510);
            this.panel5.TabIndex = 33;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.backGround1_Paint);
            // 
            // listOfFriend
            // 
            this.listOfFriend.AutoSize = true;
            this.listOfFriend.BackColor = System.Drawing.Color.Lavender;
            this.listOfFriend.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfFriend.Location = new System.Drawing.Point(8, 141);
            this.listOfFriend.Name = "listOfFriend";
            this.listOfFriend.Size = new System.Drawing.Size(311, 60);
            this.listOfFriend.TabIndex = 36;
            this.listOfFriend.Text = "List of friends who also check in to the same\r\nplace (In addition they are member" +
    "s of the\r\ngroup created with the user):";
            this.listOfFriend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.listOfFriend.Click += new System.EventHandler(this.listOfFriendTitle_Click);
            // 
            // FormCheckInReviwes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 706);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCheckInReviwes";
            this.Text = "FormCheckIn";
            this.Load += new System.EventHandler(this.formCheckIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreOnPlace)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label checkIn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox postofscore;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown scoreOnPlace;
        private System.Windows.Forms.ListBox listFriend;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label listOfFriend;
    }
}