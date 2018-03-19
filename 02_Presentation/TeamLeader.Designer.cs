namespace _02_Presentation
{
    partial class TeamLeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamLeader));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnTeamEmployees = new System.Windows.Forms.Button();
            this.btnTaskPlanning = new System.Windows.Forms.Button();
            this.pnlTeamEmployees = new System.Windows.Forms.Panel();
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.txtFinishDate = new System.Windows.Forms.MaskedTextBox();
            this.txtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.dgwTask = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnHistoryTAskAdd = new System.Windows.Forms.Button();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridTask = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridDemand = new System.Windows.Forms.DataGridView();
            this.btnTaskCreate = new System.Windows.Forms.Button();
            this.btnDemand = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDemandSubject = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTeamEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTask)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTask)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDemand)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnTeamEmployees);
            this.panel1.Controls.Add(this.btnTaskPlanning);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 445);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 142);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCustomers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomers.Location = new System.Drawing.Point(3, 231);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(194, 43);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Demand";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnTeamEmployees
            // 
            this.btnTeamEmployees.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTeamEmployees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeamEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTeamEmployees.Location = new System.Drawing.Point(3, 191);
            this.btnTeamEmployees.Name = "btnTeamEmployees";
            this.btnTeamEmployees.Size = new System.Drawing.Size(194, 43);
            this.btnTeamEmployees.TabIndex = 1;
            this.btnTeamEmployees.Text = "Team Employees";
            this.btnTeamEmployees.UseVisualStyleBackColor = false;
            this.btnTeamEmployees.Click += new System.EventHandler(this.btnTeamEmployees_Click);
            // 
            // btnTaskPlanning
            // 
            this.btnTaskPlanning.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTaskPlanning.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskPlanning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaskPlanning.Location = new System.Drawing.Point(3, 150);
            this.btnTaskPlanning.Name = "btnTaskPlanning";
            this.btnTaskPlanning.Size = new System.Drawing.Size(194, 43);
            this.btnTaskPlanning.TabIndex = 0;
            this.btnTaskPlanning.Text = "Task Planning";
            this.btnTaskPlanning.UseVisualStyleBackColor = false;
            this.btnTaskPlanning.Click += new System.EventHandler(this.btnTaskPlanning_Click);
            // 
            // pnlTeamEmployees
            // 
            this.pnlTeamEmployees.Controls.Add(this.cmbTaskState);
            this.pnlTeamEmployees.Controls.Add(this.txtFinishDate);
            this.pnlTeamEmployees.Controls.Add(this.txtStartDate);
            this.pnlTeamEmployees.Controls.Add(this.dgwTask);
            this.pnlTeamEmployees.Controls.Add(this.btnAdd);
            this.pnlTeamEmployees.Controls.Add(this.txtDescription);
            this.pnlTeamEmployees.Controls.Add(this.txtProjectId);
            this.pnlTeamEmployees.Controls.Add(this.txtSubject);
            this.pnlTeamEmployees.Controls.Add(this.label3);
            this.pnlTeamEmployees.Controls.Add(this.label7);
            this.pnlTeamEmployees.Controls.Add(this.label5);
            this.pnlTeamEmployees.Controls.Add(this.label4);
            this.pnlTeamEmployees.Controls.Add(this.label16);
            this.pnlTeamEmployees.Controls.Add(this.label2);
            this.pnlTeamEmployees.Location = new System.Drawing.Point(6, 6);
            this.pnlTeamEmployees.Name = "pnlTeamEmployees";
            this.pnlTeamEmployees.Size = new System.Drawing.Size(538, 408);
            this.pnlTeamEmployees.TabIndex = 0;
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Items.AddRange(new object[] {
            "Başlanmadı",
            "Geliştirilecek",
            "Test Edilecek"});
            this.cmbTaskState.Location = new System.Drawing.Point(190, 171);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(171, 21);
            this.cmbTaskState.TabIndex = 7;
            // 
            // txtFinishDate
            // 
            this.txtFinishDate.Location = new System.Drawing.Point(190, 92);
            this.txtFinishDate.Mask = "00/00/0000";
            this.txtFinishDate.Name = "txtFinishDate";
            this.txtFinishDate.Size = new System.Drawing.Size(171, 20);
            this.txtFinishDate.TabIndex = 3;
            this.txtFinishDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(190, 66);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(171, 20);
            this.txtStartDate.TabIndex = 2;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // dgwTask
            // 
            this.dgwTask.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgwTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTask.Location = new System.Drawing.Point(3, 233);
            this.dgwTask.Name = "dgwTask";
            this.dgwTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTask.Size = new System.Drawing.Size(532, 166);
            this.dgwTask.TabIndex = 5;
            this.dgwTask.Click += new System.EventHandler(this.dgwTask_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(286, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(190, 119);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(171, 42);
            this.txtDescription.TabIndex = 4;
            // 
            // txtProjectId
            // 
            this.txtProjectId.Location = new System.Drawing.Point(190, 13);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.ReadOnly = true;
            this.txtProjectId.Size = new System.Drawing.Size(171, 20);
            this.txtProjectId.TabIndex = 0;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(190, 39);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(171, 20);
            this.txtSubject.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(90, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label7.Location = new System.Drawing.Point(97, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Project ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(94, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(92, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Finish Date :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label16.Location = new System.Drawing.Point(125, 171);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 14);
            this.label16.TabIndex = 0;
            this.label16.Text = "State :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(112, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(211, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 445);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlTeamEmployees);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(553, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbEmployee);
            this.tabPage2.Controls.Add(this.btnHistoryTAskAdd);
            this.tabPage2.Controls.Add(this.txtTaskDescription);
            this.tabPage2.Controls.Add(this.txtTaskId);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.gridTask);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(195, 72);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(171, 21);
            this.cmbEmployee.TabIndex = 1;
            // 
            // btnHistoryTAskAdd
            // 
            this.btnHistoryTAskAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHistoryTAskAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHistoryTAskAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistoryTAskAdd.Location = new System.Drawing.Point(291, 172);
            this.btnHistoryTAskAdd.Name = "btnHistoryTAskAdd";
            this.btnHistoryTAskAdd.Size = new System.Drawing.Size(75, 31);
            this.btnHistoryTAskAdd.TabIndex = 3;
            this.btnHistoryTAskAdd.Text = "ADD";
            this.btnHistoryTAskAdd.UseVisualStyleBackColor = false;
            this.btnHistoryTAskAdd.Click += new System.EventHandler(this.btnHistoryTAskAdd_Click);
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(195, 99);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(171, 62);
            this.txtTaskDescription.TabIndex = 2;
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(195, 46);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(171, 20);
            this.txtTaskId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label6.Location = new System.Drawing.Point(95, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Description :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label11.Location = new System.Drawing.Point(88, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 14);
            this.label11.TabIndex = 8;
            this.label11.Text = "Employee ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label8.Location = new System.Drawing.Point(119, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Task ID :";
            // 
            // gridTask
            // 
            this.gridTask.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.gridTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTask.Location = new System.Drawing.Point(6, 247);
            this.gridTask.Name = "gridTask";
            this.gridTask.Size = new System.Drawing.Size(532, 166);
            this.gridTask.TabIndex = 2;
            this.gridTask.Click += new System.EventHandler(this.gridTask_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridDemand);
            this.tabPage3.Controls.Add(this.btnTaskCreate);
            this.tabPage3.Controls.Add(this.btnDemand);
            this.tabPage3.Controls.Add(this.cmbState);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtDemandSubject);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.cmbProject);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.cmbCompany);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(553, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridDemand
            // 
            this.gridDemand.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.gridDemand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDemand.Location = new System.Drawing.Point(6, 247);
            this.gridDemand.Name = "gridDemand";
            this.gridDemand.Size = new System.Drawing.Size(532, 166);
            this.gridDemand.TabIndex = 28;
            this.gridDemand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDemand_CellContentClick);
            this.gridDemand.Click += new System.EventHandler(this.gridDemand_Click);
            // 
            // btnTaskCreate
            // 
            this.btnTaskCreate.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTaskCreate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaskCreate.Location = new System.Drawing.Point(150, 158);
            this.btnTaskCreate.Name = "btnTaskCreate";
            this.btnTaskCreate.Size = new System.Drawing.Size(140, 31);
            this.btnTaskCreate.TabIndex = 5;
            this.btnTaskCreate.Text = "Task Create";
            this.btnTaskCreate.UseVisualStyleBackColor = false;
            this.btnTaskCreate.Click += new System.EventHandler(this.btnTaskCreate_Click);
            // 
            // btnDemand
            // 
            this.btnDemand.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDemand.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDemand.Location = new System.Drawing.Point(296, 158);
            this.btnDemand.Name = "btnDemand";
            this.btnDemand.Size = new System.Drawing.Size(90, 31);
            this.btnDemand.TabIndex = 4;
            this.btnDemand.Text = "ADD";
            this.btnDemand.UseVisualStyleBackColor = false;
            this.btnDemand.Click += new System.EventHandler(this.btnDemand_Click);
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "Yeni Talep ",
            "Hata"});
            this.cmbState.Location = new System.Drawing.Point(215, 128);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(171, 21);
            this.cmbState.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label15.Location = new System.Drawing.Point(162, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "State :";
            // 
            // txtDemandSubject
            // 
            this.txtDemandSubject.Location = new System.Drawing.Point(215, 102);
            this.txtDemandSubject.Name = "txtDemandSubject";
            this.txtDemandSubject.Size = new System.Drawing.Size(171, 20);
            this.txtDemandSubject.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label14.Location = new System.Drawing.Point(147, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 14);
            this.label14.TabIndex = 23;
            this.label14.Text = "Subject :";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(215, 71);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(171, 21);
            this.cmbProject.TabIndex = 1;
            this.cmbProject.Click += new System.EventHandler(this.cmbProject_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label13.Location = new System.Drawing.Point(162, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 14);
            this.label13.TabIndex = 19;
            this.label13.Text = "Proje :";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(215, 44);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(171, 21);
            this.cmbCompany.TabIndex = 0;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label12.Location = new System.Drawing.Point(104, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 14);
            this.label12.TabIndex = 19;
            this.label12.Text = "CompanyName :";
            // 
            // TeamLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 452);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "TeamLeader";
            this.Text = "TeamLeader";
            this.Load += new System.EventHandler(this.TeamLeader_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTeamEmployees.ResumeLayout(false);
            this.pnlTeamEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTask)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTask)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDemand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnTeamEmployees;
        private System.Windows.Forms.Button btnTaskPlanning;
        private System.Windows.Forms.Panel pnlTeamEmployees;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dgwTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProjectId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtFinishDate;
        private System.Windows.Forms.MaskedTextBox txtStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnHistoryTAskAdd;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridTask;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridDemand;
        private System.Windows.Forms.Button btnTaskCreate;
        private System.Windows.Forms.Button btnDemand;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDemandSubject;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}