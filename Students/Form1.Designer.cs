namespace Students
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.pictureBoxSystem = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxInfor = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxIdentification = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxStudents = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonLastPage = new System.Windows.Forms.Button();
            this.buttonFirstPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPreviusPage = new System.Windows.Forms.Button();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.labelStudentList = new System.Windows.Forms.Label();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.groupBoxTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSystem)).BeginInit();
            this.groupBoxInfor.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).BeginInit();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.groupBoxFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTitle.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBoxTitle.Controls.Add(this.pictureBoxSystem);
            this.groupBoxTitle.Controls.Add(this.labelName);
            this.groupBoxTitle.Location = new System.Drawing.Point(6, -2);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Size = new System.Drawing.Size(872, 61);
            this.groupBoxTitle.TabIndex = 0;
            this.groupBoxTitle.TabStop = false;
            // 
            // pictureBoxSystem
            // 
            this.pictureBoxSystem.Image = global::Students.Properties.Resources._3069198_cap_education_hat_school_112714;
            this.pictureBoxSystem.Location = new System.Drawing.Point(15, 8);
            this.pictureBoxSystem.Name = "pictureBoxSystem";
            this.pictureBoxSystem.Size = new System.Drawing.Size(53, 50);
            this.pictureBoxSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSystem.TabIndex = 2;
            this.pictureBoxSystem.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelName.Font = new System.Drawing.Font("Gisha", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelName.Location = new System.Drawing.Point(257, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(380, 32);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Alejandra\'s Students System";
            // 
            // groupBoxInfor
            // 
            this.groupBoxInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInfor.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBoxInfor.Controls.Add(this.buttonDelete);
            this.groupBoxInfor.Controls.Add(this.buttonCancel);
            this.groupBoxInfor.Controls.Add(this.buttonAdd);
            this.groupBoxInfor.Controls.Add(this.labelEmail);
            this.groupBoxInfor.Controls.Add(this.textBoxEmail);
            this.groupBoxInfor.Controls.Add(this.labelID);
            this.groupBoxInfor.Controls.Add(this.textBoxIdentification);
            this.groupBoxInfor.Controls.Add(this.labelLName);
            this.groupBoxInfor.Controls.Add(this.textBoxLastName);
            this.groupBoxInfor.Controls.Add(this.labelFName);
            this.groupBoxInfor.Controls.Add(this.textBoxFirstName);
            this.groupBoxInfor.Controls.Add(this.groupBox5);
            this.groupBoxInfor.Controls.Add(this.labelInfo);
            this.groupBoxInfor.Location = new System.Drawing.Point(6, 104);
            this.groupBoxInfor.Name = "groupBoxInfor";
            this.groupBoxInfor.Size = new System.Drawing.Size(342, 403);
            this.groupBoxInfor.TabIndex = 1;
            this.groupBoxInfor.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonDelete.Image = global::Students.Properties.Resources.baseline_delete_black_24dp;
            this.buttonDelete.Location = new System.Drawing.Point(135, 273);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(77, 32);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonCancel.Image = global::Students.Properties.Resources.baseline_close_black_24dp;
            this.buttonCancel.Location = new System.Drawing.Point(247, 273);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(77, 32);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonAdd.Image = global::Students.Properties.Resources.baseline_person_add_black_24dp;
            this.buttonAdd.Location = new System.Drawing.Point(15, 272);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(77, 32);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelEmail.Location = new System.Drawing.Point(168, 204);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 15);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Vrinda", 10F);
            this.textBoxEmail.Location = new System.Drawing.Point(168, 224);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(156, 26);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelID.Location = new System.Drawing.Point(6, 204);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(90, 15);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "Identification";
            // 
            // textBoxIdentification
            // 
            this.textBoxIdentification.Font = new System.Drawing.Font("Vrinda", 10F);
            this.textBoxIdentification.Location = new System.Drawing.Point(6, 224);
            this.textBoxIdentification.Multiline = true;
            this.textBoxIdentification.Name = "textBoxIdentification";
            this.textBoxIdentification.Size = new System.Drawing.Size(156, 26);
            this.textBoxIdentification.TabIndex = 3;
            this.textBoxIdentification.TextChanged += new System.EventHandler(this.textBoxIdentification_TextChanged);
            this.textBoxIdentification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdentification_KeyPress);
            // 
            // labelLName
            // 
            this.labelLName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelLName.Location = new System.Drawing.Point(168, 148);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(76, 15);
            this.labelLName.TabIndex = 5;
            this.labelLName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Vrinda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(168, 168);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(156, 26);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // labelFName
            // 
            this.labelFName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelFName.Location = new System.Drawing.Point(6, 148);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(77, 15);
            this.labelFName.TabIndex = 3;
            this.labelFName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Vrinda", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(6, 168);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(156, 26);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxStudents);
            this.groupBox5.Location = new System.Drawing.Point(89, 36);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(147, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // pictureBoxStudents
            // 
            this.pictureBoxStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStudents.Image = global::Students.Properties.Resources._130manwomanstudent2_100617;
            this.pictureBoxStudents.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxStudents.Name = "pictureBoxStudents";
            this.pictureBoxStudents.Size = new System.Drawing.Size(124, 81);
            this.pictureBoxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStudents.TabIndex = 0;
            this.pictureBoxStudents.TabStop = false;
            this.pictureBoxStudents.Click += new System.EventHandler(this.pictureBoxStudents_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelInfo.Location = new System.Drawing.Point(86, 16);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(150, 17);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Student Information";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxList.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBoxList.Controls.Add(this.numericUpDown1);
            this.groupBoxList.Controls.Add(this.labelPage);
            this.groupBoxList.Controls.Add(this.buttonLastPage);
            this.groupBoxList.Controls.Add(this.buttonFirstPage);
            this.groupBoxList.Controls.Add(this.buttonNextPage);
            this.groupBoxList.Controls.Add(this.buttonPreviusPage);
            this.groupBoxList.Controls.Add(this.studentGridView);
            this.groupBoxList.Controls.Add(this.labelStudentList);
            this.groupBoxList.Location = new System.Drawing.Point(354, 104);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(524, 403);
            this.groupBoxList.TabIndex = 2;
            this.groupBoxList.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(25, 357);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelPage
            // 
            this.labelPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.ForeColor = System.Drawing.Color.Teal;
            this.labelPage.Location = new System.Drawing.Point(244, 336);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(45, 17);
            this.labelPage.TabIndex = 10;
            this.labelPage.Text = "Page";
            this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonLastPage
            // 
            this.buttonLastPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLastPage.BackColor = System.Drawing.Color.White;
            this.buttonLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLastPage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLastPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonLastPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLastPage.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLastPage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonLastPage.Image = global::Students.Properties.Resources._1486348528_forward_arrows_arrow_front_go_80452;
            this.buttonLastPage.Location = new System.Drawing.Point(337, 357);
            this.buttonLastPage.Name = "buttonLastPage";
            this.buttonLastPage.Size = new System.Drawing.Size(59, 25);
            this.buttonLastPage.TabIndex = 9;
            this.buttonLastPage.UseVisualStyleBackColor = false;
            this.buttonLastPage.Click += new System.EventHandler(this.buttonLastPage_Click);
            // 
            // buttonFirstPage
            // 
            this.buttonFirstPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonFirstPage.BackColor = System.Drawing.Color.White;
            this.buttonFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFirstPage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFirstPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonFirstPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirstPage.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirstPage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonFirstPage.Image = global::Students.Properties.Resources._1486348529_back_backwards_repeat_arrows_arrow_80455___copia;
            this.buttonFirstPage.Location = new System.Drawing.Point(142, 357);
            this.buttonFirstPage.Name = "buttonFirstPage";
            this.buttonFirstPage.Size = new System.Drawing.Size(59, 25);
            this.buttonFirstPage.TabIndex = 8;
            this.buttonFirstPage.UseVisualStyleBackColor = false;
            this.buttonFirstPage.Click += new System.EventHandler(this.buttonFirstPage_Click);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNextPage.BackColor = System.Drawing.Color.White;
            this.buttonNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextPage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNextPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonNextPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextPage.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextPage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonNextPage.Image = global::Students.Properties.Resources._1486348525_music_forward_front_next_arrow_80457;
            this.buttonNextPage.Location = new System.Drawing.Point(272, 357);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(59, 25);
            this.buttonNextPage.TabIndex = 7;
            this.buttonNextPage.UseVisualStyleBackColor = false;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonPreviusPage
            // 
            this.buttonPreviusPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPreviusPage.BackColor = System.Drawing.Color.White;
            this.buttonPreviusPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreviusPage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPreviusPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.buttonPreviusPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonPreviusPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviusPage.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviusPage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonPreviusPage.Image = global::Students.Properties.Resources._1486348526_arrow_back_backwards_repeat_previous_80453;
            this.buttonPreviusPage.Location = new System.Drawing.Point(207, 357);
            this.buttonPreviusPage.Name = "buttonPreviusPage";
            this.buttonPreviusPage.Size = new System.Drawing.Size(59, 25);
            this.buttonPreviusPage.TabIndex = 6;
            this.buttonPreviusPage.UseVisualStyleBackColor = false;
            this.buttonPreviusPage.Click += new System.EventHandler(this.buttonPreviusPage_Click);
            // 
            // studentGridView
            // 
            this.studentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentGridView.BackgroundColor = System.Drawing.Color.White;
            this.studentGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(6, 36);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.studentGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.studentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGridView.Size = new System.Drawing.Size(512, 283);
            this.studentGridView.TabIndex = 2;
            this.studentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellClick);
            this.studentGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.studentGridView_KeyUp);
            // 
            // labelStudentList
            // 
            this.labelStudentList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelStudentList.AutoSize = true;
            this.labelStudentList.BackColor = System.Drawing.Color.Transparent;
            this.labelStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelStudentList.Location = new System.Drawing.Point(204, 16);
            this.labelStudentList.Name = "labelStudentList";
            this.labelStudentList.Size = new System.Drawing.Size(95, 17);
            this.labelStudentList.TabIndex = 1;
            this.labelStudentList.Text = "Student List";
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFind.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBoxFind.Controls.Add(this.textBoxFind);
            this.groupBoxFind.Controls.Add(this.labelFind);
            this.groupBoxFind.Location = new System.Drawing.Point(6, 58);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(872, 40);
            this.groupBoxFind.TabIndex = 3;
            this.groupBoxFind.TabStop = false;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Font = new System.Drawing.Font("Vrinda", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFind.Location = new System.Drawing.Point(130, 7);
            this.textBoxFind.Multiline = true;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(229, 25);
            this.textBoxFind.TabIndex = 8;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.BackColor = System.Drawing.Color.Transparent;
            this.labelFind.Font = new System.Drawing.Font("Gisha", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFind.ForeColor = System.Drawing.Color.Gold;
            this.labelFind.Location = new System.Drawing.Point(4, 10);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(117, 21);
            this.labelFind.TabIndex = 0;
            this.labelFind.Text = "Find student";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 507);
            this.Controls.Add(this.groupBoxFind);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxInfor);
            this.Controls.Add(this.groupBoxTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students System";
            this.groupBoxTitle.ResumeLayout(false);
            this.groupBoxTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSystem)).EndInit();
            this.groupBoxInfor.ResumeLayout(false);
            this.groupBoxInfor.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).EndInit();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTitle;
        private System.Windows.Forms.GroupBox groupBoxInfor;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxFind;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelStudentList;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxIdentification;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxStudents;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.PictureBox pictureBoxSystem;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button buttonLastPage;
        private System.Windows.Forms.Button buttonFirstPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPreviusPage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

