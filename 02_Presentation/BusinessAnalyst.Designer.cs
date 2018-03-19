namespace _02_Presentation
{
    partial class BusinessAnalyst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusinessAnalyst));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMyTask = new System.Windows.Forms.Button();
            this.btnTaskPlanning = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.txtTaskDeadline = new System.Windows.Forms.MaskedTextBox();
            this.gridTaskBusiness = new System.Windows.Forms.DataGridView();
            this.txttaskStart = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHistoryTAskAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtFinishDate = new System.Windows.Forms.MaskedTextBox();
            this.txtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.dgwBusiness = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridDemand = new System.Windows.Forms.DataGridView();
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
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTaskBusiness)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBusiness)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDemand)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMyTask);
            this.panel1.Controls.Add(this.btnTaskPlanning);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 435);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 142);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Demand";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnMyTask_Click);
            // 
            // btnMyTask
            // 
            this.btnMyTask.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMyTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMyTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMyTask.Location = new System.Drawing.Point(0, 206);
            this.btnMyTask.Name = "btnMyTask";
            this.btnMyTask.Size = new System.Drawing.Size(207, 49);
            this.btnMyTask.TabIndex = 1;
            this.btnMyTask.Text = "My Task";
            this.btnMyTask.UseVisualStyleBackColor = false;
            this.btnMyTask.Click += new System.EventHandler(this.btnMyTask_Click);
            // 
            // btnTaskPlanning
            // 
            this.btnTaskPlanning.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTaskPlanning.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskPlanning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaskPlanning.Location = new System.Drawing.Point(3, 151);
            this.btnTaskPlanning.Name = "btnTaskPlanning";
            this.btnTaskPlanning.Size = new System.Drawing.Size(204, 49);
            this.btnTaskPlanning.TabIndex = 0;
            this.btnTaskPlanning.Text = "Task Planning";
            this.btnTaskPlanning.UseVisualStyleBackColor = false;
            this.btnTaskPlanning.Click += new System.EventHandler(this.btnTaskPlanning_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbEmployee);
            this.tabPage2.Controls.Add(this.txtTaskDeadline);
            this.tabPage2.Controls.Add(this.gridTaskBusiness);
            this.tabPage2.Controls.Add(this.txttaskStart);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnHistoryTAskAdd);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtTaskDescription);
            this.tabPage2.Controls.Add(this.txtTaskId);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(200, 61);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(171, 21);
            this.cmbEmployee.TabIndex = 1;
            // 
            // txtTaskDeadline
            // 
            this.txtTaskDeadline.Location = new System.Drawing.Point(200, 114);
            this.txtTaskDeadline.Mask = "00/00/0000";
            this.txtTaskDeadline.Name = "txtTaskDeadline";
            this.txtTaskDeadline.Size = new System.Drawing.Size(171, 20);
            this.txtTaskDeadline.TabIndex = 3;
            this.txtTaskDeadline.ValidatingType = typeof(System.DateTime);
            // 
            // gridTaskBusiness
            // 
            this.gridTaskBusiness.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.gridTaskBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTaskBusiness.Location = new System.Drawing.Point(5, 256);
            this.gridTaskBusiness.Name = "gridTaskBusiness";
            this.gridTaskBusiness.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTaskBusiness.Size = new System.Drawing.Size(532, 166);
            this.gridTaskBusiness.TabIndex = 41;
            this.gridTaskBusiness.Click += new System.EventHandler(this.gridTaskBusiness_Click);
            // 
            // txttaskStart
            // 
            this.txttaskStart.Location = new System.Drawing.Point(200, 88);
            this.txttaskStart.Mask = "00/00/0000";
            this.txttaskStart.Name = "txttaskStart";
            this.txttaskStart.Size = new System.Drawing.Size(171, 20);
            this.txttaskStart.TabIndex = 2;
            this.txttaskStart.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label10.Location = new System.Drawing.Point(107, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 14);
            this.label10.TabIndex = 45;
            this.label10.Text = "Finish Date :";
            // 
            // btnHistoryTAskAdd
            // 
            this.btnHistoryTAskAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHistoryTAskAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHistoryTAskAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistoryTAskAdd.Location = new System.Drawing.Point(284, 214);
            this.btnHistoryTAskAdd.Name = "btnHistoryTAskAdd";
            this.btnHistoryTAskAdd.Size = new System.Drawing.Size(87, 31);
            this.btnHistoryTAskAdd.TabIndex = 5;
            this.btnHistoryTAskAdd.Text = "ADD";
            this.btnHistoryTAskAdd.UseVisualStyleBackColor = false;
            this.btnHistoryTAskAdd.Click += new System.EventHandler(this.btnHistoryTAskAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label9.Location = new System.Drawing.Point(98, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 14);
            this.label9.TabIndex = 44;
            this.label9.Text = "Employee ID :";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(200, 140);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(171, 62);
            this.txtTaskDescription.TabIndex = 4;
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(200, 35);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(171, 20);
            this.txtTaskId.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label11.Location = new System.Drawing.Point(109, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 14);
            this.label11.TabIndex = 44;
            this.label11.Text = "Start Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label8.Location = new System.Drawing.Point(129, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 43;
            this.label8.Text = "Task ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label6.Location = new System.Drawing.Point(105, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 42;
            this.label6.Text = "Description :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtFinishDate);
            this.tabPage1.Controls.Add(this.txtStartDate);
            this.tabPage1.Controls.Add(this.dgwBusiness);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.txtProjectId);
            this.tabPage1.Controls.Add(this.txtSubject);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtFinishDate
            // 
            this.txtFinishDate.Location = new System.Drawing.Point(200, 115);
            this.txtFinishDate.Mask = "00/00/0000";
            this.txtFinishDate.Name = "txtFinishDate";
            this.txtFinishDate.Size = new System.Drawing.Size(171, 20);
            this.txtFinishDate.TabIndex = 3;
            this.txtFinishDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(200, 89);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(171, 20);
            this.txtStartDate.TabIndex = 2;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // dgwBusiness
            // 
            this.dgwBusiness.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgwBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBusiness.Location = new System.Drawing.Point(3, 259);
            this.dgwBusiness.Name = "dgwBusiness";
            this.dgwBusiness.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBusiness.Size = new System.Drawing.Size(532, 166);
            this.dgwBusiness.TabIndex = 28;
            this.dgwBusiness.Click += new System.EventHandler(this.dgwBusiness_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(296, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(200, 141);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(171, 62);
            this.txtDescription.TabIndex = 4;
            // 
            // txtProjectId
            // 
            this.txtProjectId.Location = new System.Drawing.Point(200, 36);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(171, 20);
            this.txtProjectId.TabIndex = 0;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(200, 62);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(171, 20);
            this.txtSubject.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(107, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "Description :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label7.Location = new System.Drawing.Point(114, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Project ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(111, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "Start Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label4.Location = new System.Drawing.Point(109, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "Finish Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label2.Location = new System.Drawing.Point(129, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Subject :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(213, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridDemand);
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
            this.tabPage3.Size = new System.Drawing.Size(540, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridDemand
            // 
            this.gridDemand.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.gridDemand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDemand.Location = new System.Drawing.Point(6, 256);
            this.gridDemand.Name = "gridDemand";
            this.gridDemand.Size = new System.Drawing.Size(532, 166);
            this.gridDemand.TabIndex = 39;
            this.gridDemand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDemand_CellContentClick);
            this.gridDemand.Click += new System.EventHandler(this.gridDemand_Click);
            // 
            // btnDemand
            // 
            this.btnDemand.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDemand.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDemand.Location = new System.Drawing.Point(296, 170);
            this.btnDemand.Name = "btnDemand";
            this.btnDemand.Size = new System.Drawing.Size(75, 31);
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
            this.cmbState.Location = new System.Drawing.Point(200, 140);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(171, 21);
            this.cmbState.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label15.Location = new System.Drawing.Point(147, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 14);
            this.label15.TabIndex = 35;
            this.label15.Text = "State :";
            // 
            // txtDemandSubject
            // 
            this.txtDemandSubject.Location = new System.Drawing.Point(200, 114);
            this.txtDemandSubject.Name = "txtDemandSubject";
            this.txtDemandSubject.Size = new System.Drawing.Size(171, 20);
            this.txtDemandSubject.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label14.Location = new System.Drawing.Point(132, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 14);
            this.label14.TabIndex = 33;
            this.label14.Text = "Subject :";
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(200, 83);
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
            this.label13.Location = new System.Drawing.Point(147, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 14);
            this.label13.TabIndex = 29;
            this.label13.Text = "Proje :";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(200, 56);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(171, 21);
            this.cmbCompany.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label12.Location = new System.Drawing.Point(89, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 14);
            this.label12.TabIndex = 30;
            this.label12.Text = "CompanyName :";
            // 
            // BusinessAnalyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 452);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "BusinessAnalyst";
            this.Text = "BusinessAnalyst";
            this.Load += new System.EventHandler(this.BusinessAnalyst_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTaskBusiness)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBusiness)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDemand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaskPlanning;
        private System.Windows.Forms.Button btnMyTask;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.MaskedTextBox txtTaskDeadline;
        private System.Windows.Forms.DataGridView gridTaskBusiness;
        private System.Windows.Forms.MaskedTextBox txttaskStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHistoryTAskAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox txtFinishDate;
        private System.Windows.Forms.MaskedTextBox txtStartDate;
        private System.Windows.Forms.DataGridView dgwBusiness;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtProjectId;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridDemand;
        private System.Windows.Forms.Button btnDemand;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDemandSubject;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}