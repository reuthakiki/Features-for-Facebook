
namespace BasicFacebookFeatures
{
    partial class LoveFinder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoveFinder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxGender = new System.Windows.Forms.CheckedListBox();
            this.buttonSetFilters = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMatchPre = new System.Windows.Forms.Label();
            this.labelMatchHistory = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.listBoxScoreHistory = new System.Windows.Forms.ListBox();
            this.loveFinderTriviaStatisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.buttonMatchCheck = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.textBoxMatchPost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loveFinderTriviaStatisticBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepPink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkedListBoxGender);
            this.panel1.Controls.Add(this.buttonSetFilters);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 169);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.backGroundFinder_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(721, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Heartshape_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(538, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 75);
            this.label3.TabIndex = 22;
            this.label3.Text = "Finder";
            this.label3.Click += new System.EventHandler(this.finderTitle_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "From:";
            this.label7.Click += new System.EventHandler(this.fromTitle_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(838, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "To:";
            this.label6.Click += new System.EventHandler(this.toTitle_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(885, 112);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 26);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDownAge1_ValueChanged_1);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(705, 112);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(91, 26);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDownAge2_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Filters";
            this.label5.Click += new System.EventHandler(this.filterTitle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(536, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Age:";
            this.label2.Click += new System.EventHandler(this.ageTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(202, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gender:";
            this.label1.Click += new System.EventHandler(this.genderTitle_Click);
            // 
            // checkedListBoxGender
            // 
            this.checkedListBoxGender.BackColor = System.Drawing.Color.DeepPink;
            this.checkedListBoxGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxGender.CheckOnClick = true;
            this.checkedListBoxGender.FormattingEnabled = true;
            this.checkedListBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.checkedListBoxGender.Location = new System.Drawing.Point(314, 98);
            this.checkedListBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxGender.Name = "checkedListBoxGender";
            this.checkedListBoxGender.Size = new System.Drawing.Size(184, 69);
            this.checkedListBoxGender.TabIndex = 15;
            this.checkedListBoxGender.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxGender_SelectedIndexChanged);
            // 
            // buttonSetFilters
            // 
            this.buttonSetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetFilters.Location = new System.Drawing.Point(1046, 102);
            this.buttonSetFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetFilters.Name = "buttonSetFilters";
            this.buttonSetFilters.Size = new System.Drawing.Size(154, 45);
            this.buttonSetFilters.TabIndex = 13;
            this.buttonSetFilters.Text = "Set Fiilters";
            this.buttonSetFilters.UseVisualStyleBackColor = true;
            this.buttonSetFilters.Click += new System.EventHandler(this.buttonSetFilters_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.labelMatchPre);
            this.panel2.Controls.Add(this.labelMatchHistory);
            this.panel2.Controls.Add(this.labelScore);
            this.panel2.Controls.Add(this.listBoxScoreHistory);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.buttonMatchCheck);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.buttonStatus);
            this.panel2.Controls.Add(this.textBoxMatchPost);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.hScrollBar1);
            this.panel2.Controls.Add(this.pictureBoxFriend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1266, 821);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.backGruond_Paint);
            // 
            // labelMatchPre
            // 
            this.labelMatchPre.AutoSize = true;
            this.labelMatchPre.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchPre.Location = new System.Drawing.Point(716, 509);
            this.labelMatchPre.Name = "labelMatchPre";
            this.labelMatchPre.Size = new System.Drawing.Size(189, 27);
            this.labelMatchPre.TabIndex = 32;
            this.labelMatchPre.Text = "match precentage:";
            // 
            // labelMatchHistory
            // 
            this.labelMatchHistory.AutoSize = true;
            this.labelMatchHistory.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchHistory.Location = new System.Drawing.Point(961, 471);
            this.labelMatchHistory.Name = "labelMatchHistory";
            this.labelMatchHistory.Size = new System.Drawing.Size(134, 27);
            this.labelMatchHistory.TabIndex = 31;
            this.labelMatchHistory.Text = "match histoy";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelScore.Location = new System.Drawing.Point(769, 572);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(73, 29);
            this.labelScore.TabIndex = 30;
            this.labelScore.Text = "score";
            // 
            // listBoxScoreHistory
            // 
            this.listBoxScoreHistory.DataSource = this.loveFinderTriviaStatisticBindingSource;
            this.listBoxScoreHistory.DisplayMember = "MatchedFriendName";
            this.listBoxScoreHistory.FormattingEnabled = true;
            this.listBoxScoreHistory.ItemHeight = 20;
            this.listBoxScoreHistory.Location = new System.Drawing.Point(936, 509);
            this.listBoxScoreHistory.Name = "listBoxScoreHistory";
            this.listBoxScoreHistory.Size = new System.Drawing.Size(197, 224);
            this.listBoxScoreHistory.TabIndex = 29;
            this.listBoxScoreHistory.ValueMember = "MatchedFriendName";
            this.listBoxScoreHistory.SelectedIndexChanged += new System.EventHandler(this.listBoxScoreHistory_SelectedIndexChanged);
            // 
            // loveFinderTriviaStatisticBindingSource
            // 
            this.loveFinderTriviaStatisticBindingSource.DataSource = typeof(FacebookDesktopAppLogic.LoveFinderTriviaStatistic);
            this.loveFinderTriviaStatisticBindingSource.CurrentChanged += new System.EventHandler(this.loveFinderTriviaStatisticBindingSource_CurrentChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepPink;
            this.label9.Location = new System.Drawing.Point(551, 15);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(443, 51);
            this.label9.TabIndex = 28;
            this.label9.Text = "Matching percentages";
            this.label9.Click += new System.EventHandler(this.MatchPercentageTitle_Click_1);
            // 
            // buttonMatchCheck
            // 
            this.buttonMatchCheck.BackColor = System.Drawing.Color.HotPink;
            this.buttonMatchCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMatchCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMatchCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMatchCheck.Location = new System.Drawing.Point(674, 349);
            this.buttonMatchCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMatchCheck.Name = "buttonMatchCheck";
            this.buttonMatchCheck.Size = new System.Drawing.Size(202, 62);
            this.buttonMatchCheck.TabIndex = 27;
            this.buttonMatchCheck.Text = "Chek your match";
            this.buttonMatchCheck.UseVisualStyleBackColor = false;
            this.buttonMatchCheck.Click += new System.EventHandler(this.buttonMatchCheck_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(86, 466);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(259, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "Post match precentage";
            this.label10.Click += new System.EventHandler(this.postMatchTitle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.checkedListBox2);
            this.groupBox3.Location = new System.Drawing.Point(945, 85);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(242, 258);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "What is your Friend Location?";
            this.groupBox3.Enter += new System.EventHandler(this.groupBoxFriendLocation3_Enter);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(0, 62);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(242, 161);
            this.checkedListBox2.Sorted = true;
            this.checkedListBox2.TabIndex = 13;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(657, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(253, 258);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "what is your friend Birthday?";
            this.groupBox2.Enter += new System.EventHandler(this.groupBoxFriendbirth2_Enter);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 62);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(248, 161);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 13;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_2);
            // 
            // buttonStatus
            // 
            this.buttonStatus.BackColor = System.Drawing.Color.DeepPink;
            this.buttonStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStatus.Location = new System.Drawing.Point(577, 524);
            this.buttonStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(84, 62);
            this.buttonStatus.TabIndex = 22;
            this.buttonStatus.Text = "Post";
            this.buttonStatus.UseVisualStyleBackColor = false;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click_1);
            // 
            // textBoxMatchPost
            // 
            this.textBoxMatchPost.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxMatchPost.Location = new System.Drawing.Point(64, 524);
            this.textBoxMatchPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMatchPost.Multiline = true;
            this.textBoxMatchPost.Name = "textBoxMatchPost";
            this.textBoxMatchPost.Size = new System.Drawing.Size(468, 62);
            this.textBoxMatchPost.TabIndex = 25;
            this.textBoxMatchPost.TextChanged += new System.EventHandler(this.textBoxMatchPost_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.checkedListBox4);
            this.groupBox1.Location = new System.Drawing.Point(398, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(243, 258);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Which page do you prefer the most?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBoxPagePrefer1_Enter);
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Location = new System.Drawing.Point(6, 62);
            this.checkedListBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(243, 161);
            this.checkedListBox4.Sorted = true;
            this.checkedListBox4.TabIndex = 13;
            this.checkedListBox4.SelectedIndexChanged += new System.EventHandler(this.checkedListBox4_SelectedIndexChanged_1);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(128, 335);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(83, 47);
            this.hScrollBar1.TabIndex = 20;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarFinder1_Scroll_1);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(34, 92);
            this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(284, 240);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFriend.TabIndex = 19;
            this.pictureBoxFriend.TabStop = false;
            this.pictureBoxFriend.Click += new System.EventHandler(this.pictureBoxFriend_Click);
            // 
            // LoveFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1266, 990);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoveFinder";
            this.Text = "LoveFinderFeature";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loveFinderTriviaStatisticBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxGender;
        private System.Windows.Forms.Button buttonSetFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonMatchCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.TextBox textBoxMatchPost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxScoreHistory;
        private System.Windows.Forms.BindingSource loveFinderTriviaStatisticBindingSource;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelMatchPre;
        private System.Windows.Forms.Label labelMatchHistory;
    }
}