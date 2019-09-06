namespace NPBIOMETRIC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label staff_IDLabel;
            System.Windows.Forms.Label staff_NameLabel;
            System.Windows.Forms.Label registered_NoLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label sSF_NumberLabel;
            System.Windows.Forms.Label date_Of_AppointmentLabel;
            System.Windows.Forms.Label academic_QualificationLabel;
            System.Windows.Forms.Label professional_QualificationLabel;
            System.Windows.Forms.Label position_HeldLabel;
            System.Windows.Forms.Label date_EnlistedLabel;
            System.Windows.Forms.Label remarksLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.table1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceRecDataSet = new NPBIOMETRIC.AttendanceRecDataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enlistDataSet = new NPBIOMETRIC.EnlistDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ADLOT = new System.Windows.Forms.Button();
            this.ADLIN = new System.Windows.Forms.Button();
            this.admintb = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.staff_NameTextBox1 = new System.Windows.Forms.TextBox();
            this.table1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.table1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.staffID = new System.Windows.Forms.TextBox();
            this.staffName = new System.Windows.Forms.TextBox();
            this.regNum = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ssfNum = new System.Windows.Forms.TextBox();
            this.date_Of_AppointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.acadQual = new System.Windows.Forms.TextBox();
            this.profQual = new System.Windows.Forms.TextBox();
            this.position_HeldTextBox = new System.Windows.Forms.TextBox();
            this.date_EnlistedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.fP_ScanTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.remarksTextBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.verifiedTextBox1 = new System.Windows.Forms.TextBox();
            this.table1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceDataSet = new NPBIOMETRIC.attendanceDataSet();
            this.verifiedTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.STAFFMEM = new System.Windows.Forms.Button();
            this.table1TableAdapter = new NPBIOMETRIC.EnlistDataSetTableAdapters.Table1TableAdapter();
            this.tableAdapterManager = new NPBIOMETRIC.EnlistDataSetTableAdapters.TableAdapterManager();
            this.table1TableAdapter2 = new NPBIOMETRIC.AttendanceRecDataSetTableAdapters.Table1TableAdapter();
            this.tableAdapterManager2 = new NPBIOMETRIC.AttendanceRecDataSetTableAdapters.TableAdapterManager();
            this.STUD = new System.Windows.Forms.Button();
            this.essghana = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.table1TableAdapter1 = new NPBIOMETRIC.attendanceDataSetTableAdapters.Table1TableAdapter();
            this.tableAdapterManager1 = new NPBIOMETRIC.attendanceDataSetTableAdapters.TableAdapterManager();
            this.startup = new System.Windows.Forms.GroupBox();
            this.SELECTOR = new System.Windows.Forms.Label();
            this.SUBMITTER = new System.Windows.Forms.Button();
            this.staffrdb = new System.Windows.Forms.RadioButton();
            this.studentrdb = new System.Windows.Forms.RadioButton();
            this.adminrdb = new System.Windows.Forms.RadioButton();
            this.adminstatus = new System.Windows.Forms.Label();
            staff_IDLabel = new System.Windows.Forms.Label();
            staff_NameLabel = new System.Windows.Forms.Label();
            registered_NoLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            sSF_NumberLabel = new System.Windows.Forms.Label();
            date_Of_AppointmentLabel = new System.Windows.Forms.Label();
            academic_QualificationLabel = new System.Windows.Forms.Label();
            professional_QualificationLabel = new System.Windows.Forms.Label();
            position_HeldLabel = new System.Windows.Forms.Label();
            date_EnlistedLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enlistDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingNavigator)).BeginInit();
            this.table1BindingNavigator.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.startup.SuspendLayout();
            this.SuspendLayout();
            // 
            // staff_IDLabel
            // 
            staff_IDLabel.AutoSize = true;
            staff_IDLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            staff_IDLabel.Location = new System.Drawing.Point(24, 46);
            staff_IDLabel.Name = "staff_IDLabel";
            staff_IDLabel.Size = new System.Drawing.Size(46, 13);
            staff_IDLabel.TabIndex = 0;
            staff_IDLabel.Text = "Staff ID:";
            // 
            // staff_NameLabel
            // 
            staff_NameLabel.AutoSize = true;
            staff_NameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            staff_NameLabel.Location = new System.Drawing.Point(24, 85);
            staff_NameLabel.Name = "staff_NameLabel";
            staff_NameLabel.Size = new System.Drawing.Size(63, 13);
            staff_NameLabel.TabIndex = 2;
            staff_NameLabel.Text = "Staff Name:";
            // 
            // registered_NoLabel
            // 
            registered_NoLabel.AutoSize = true;
            registered_NoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            registered_NoLabel.Location = new System.Drawing.Point(24, 125);
            registered_NoLabel.Name = "registered_NoLabel";
            registered_NoLabel.Size = new System.Drawing.Size(78, 13);
            registered_NoLabel.TabIndex = 4;
            registered_NoLabel.Text = "Registered No:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dOBLabel.Location = new System.Drawing.Point(24, 161);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(33, 13);
            dOBLabel.TabIndex = 6;
            dOBLabel.Text = "DOB:";
            // 
            // sSF_NumberLabel
            // 
            sSF_NumberLabel.AutoSize = true;
            sSF_NumberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            sSF_NumberLabel.Location = new System.Drawing.Point(24, 192);
            sSF_NumberLabel.Name = "sSF_NumberLabel";
            sSF_NumberLabel.Size = new System.Drawing.Size(70, 13);
            sSF_NumberLabel.TabIndex = 8;
            sSF_NumberLabel.Text = "SSF Number:";
            // 
            // date_Of_AppointmentLabel
            // 
            date_Of_AppointmentLabel.AutoSize = true;
            date_Of_AppointmentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            date_Of_AppointmentLabel.Location = new System.Drawing.Point(24, 219);
            date_Of_AppointmentLabel.Name = "date_Of_AppointmentLabel";
            date_Of_AppointmentLabel.Size = new System.Drawing.Size(109, 13);
            date_Of_AppointmentLabel.TabIndex = 10;
            date_Of_AppointmentLabel.Text = "Date Of Appointment:";
            // 
            // academic_QualificationLabel
            // 
            academic_QualificationLabel.AutoSize = true;
            academic_QualificationLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            academic_QualificationLabel.Location = new System.Drawing.Point(24, 253);
            academic_QualificationLabel.Name = "academic_QualificationLabel";
            academic_QualificationLabel.Size = new System.Drawing.Size(118, 13);
            academic_QualificationLabel.TabIndex = 12;
            academic_QualificationLabel.Text = "Academic Qualification:";
            // 
            // professional_QualificationLabel
            // 
            professional_QualificationLabel.AutoSize = true;
            professional_QualificationLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            professional_QualificationLabel.Location = new System.Drawing.Point(24, 279);
            professional_QualificationLabel.Name = "professional_QualificationLabel";
            professional_QualificationLabel.Size = new System.Drawing.Size(128, 13);
            professional_QualificationLabel.TabIndex = 14;
            professional_QualificationLabel.Text = "Professional Qualification:";
            // 
            // position_HeldLabel
            // 
            position_HeldLabel.AutoSize = true;
            position_HeldLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            position_HeldLabel.Location = new System.Drawing.Point(26, 318);
            position_HeldLabel.Name = "position_HeldLabel";
            position_HeldLabel.Size = new System.Drawing.Size(72, 13);
            position_HeldLabel.TabIndex = 16;
            position_HeldLabel.Text = "Position Held:";
            // 
            // date_EnlistedLabel
            // 
            date_EnlistedLabel.AutoSize = true;
            date_EnlistedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            date_EnlistedLabel.Location = new System.Drawing.Point(24, 361);
            date_EnlistedLabel.Name = "date_EnlistedLabel";
            date_EnlistedLabel.Size = new System.Drawing.Size(73, 13);
            date_EnlistedLabel.TabIndex = 22;
            date_EnlistedLabel.Text = "Date Enlisted:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(785, 281);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 4;
            remarksLabel.Text = "Remarks:";
            // 
            // table1BindingSource2
            // 
            this.table1BindingSource2.DataMember = "Table1";
            this.table1BindingSource2.DataSource = this.attendanceRecDataSet;
            // 
            // attendanceRecDataSet
            // 
            this.attendanceRecDataSet.DataSetName = "AttendanceRecDataSet";
            this.attendanceRecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.enlistDataSet;
            // 
            // enlistDataSet
            // 
            this.enlistDataSet.DataSetName = "EnlistDataSet";
            this.enlistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.adminstatus);
            this.groupBox2.Controls.Add(this.ADLOT);
            this.groupBox2.Controls.Add(this.ADLIN);
            this.groupBox2.Controls.Add(this.admintb);
            this.groupBox2.Location = new System.Drawing.Point(11, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADMIN ACCESS";
            // 
            // ADLOT
            // 
            this.ADLOT.Location = new System.Drawing.Point(37, 142);
            this.ADLOT.Name = "ADLOT";
            this.ADLOT.Size = new System.Drawing.Size(86, 23);
            this.ADLOT.TabIndex = 6;
            this.ADLOT.Text = "LOG OUT";
            this.ADLOT.UseVisualStyleBackColor = true;
            this.ADLOT.Click += new System.EventHandler(this.button11_Click);
            // 
            // ADLIN
            // 
            this.ADLIN.Location = new System.Drawing.Point(42, 112);
            this.ADLIN.Name = "ADLIN";
            this.ADLIN.Size = new System.Drawing.Size(75, 23);
            this.ADLIN.TabIndex = 1;
            this.ADLIN.Text = "LOG IN";
            this.ADLIN.UseVisualStyleBackColor = true;
            this.ADLIN.Click += new System.EventHandler(this.button1_Click);
            // 
            // admintb
            // 
            this.admintb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admintb.Location = new System.Drawing.Point(20, 64);
            this.admintb.Multiline = true;
            this.admintb.Name = "admintb";
            this.admintb.PasswordChar = '*';
            this.admintb.Size = new System.Drawing.Size(115, 31);
            this.admintb.TabIndex = 0;
            this.admintb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(204, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 560);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.staff_NameTextBox1);
            this.tabPage1.Controls.Add(this.table1BindingNavigator);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(908, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "REGISTER STAFF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // staff_NameTextBox1
            // 
            this.staff_NameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "Staff_Name", true));
            this.staff_NameTextBox1.Location = new System.Drawing.Point(83, 175);
            this.staff_NameTextBox1.Multiline = true;
            this.staff_NameTextBox1.Name = "staff_NameTextBox1";
            this.staff_NameTextBox1.Size = new System.Drawing.Size(210, 41);
            this.staff_NameTextBox1.TabIndex = 8;
            // 
            // table1BindingNavigator
            // 
            this.table1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table1BindingNavigator.BindingSource = this.table1BindingSource;
            this.table1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table1BindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.table1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.table1BindingNavigatorSaveItem});
            this.table1BindingNavigator.Location = new System.Drawing.Point(95, 21);
            this.table1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table1BindingNavigator.Name = "table1BindingNavigator";
            this.table1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table1BindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.table1BindingNavigator.TabIndex = 7;
            this.table1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // table1BindingNavigatorSaveItem
            // 
            this.table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table1BindingNavigatorSaveItem.Image")));
            this.table1BindingNavigatorSaveItem.Name = "table1BindingNavigatorSaveItem";
            this.table1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.table1BindingNavigatorSaveItem.Text = "Save Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "STAFF NAME";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Location = new System.Drawing.Point(379, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(392, 300);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FP SCAN";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(55, 102);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(305, 91);
            this.button7.TabIndex = 0;
            this.button7.Text = "GET BIO DATA";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.imageTextBox);
            this.tabPage2.Controls.Add(this.fP_ScanTextBox);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(908, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FINALIZE REGISTRATION";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.Location = new System.Drawing.Point(563, 439);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(238, 47);
            this.button8.TabIndex = 20;
            this.button8.Text = "COMPLETE REGISTRATION";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(701, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 33);
            this.button6.TabIndex = 3;
            this.button6.Text = "UPLOAD IMAGE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Maroon;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(553, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 34);
            this.button5.TabIndex = 2;
            this.button5.Text = "CANCEL";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(531, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(staff_IDLabel);
            this.groupBox3.Controls.Add(this.staffID);
            this.groupBox3.Controls.Add(staff_NameLabel);
            this.groupBox3.Controls.Add(this.staffName);
            this.groupBox3.Controls.Add(registered_NoLabel);
            this.groupBox3.Controls.Add(this.regNum);
            this.groupBox3.Controls.Add(dOBLabel);
            this.groupBox3.Controls.Add(this.dOBDateTimePicker);
            this.groupBox3.Controls.Add(sSF_NumberLabel);
            this.groupBox3.Controls.Add(this.ssfNum);
            this.groupBox3.Controls.Add(date_Of_AppointmentLabel);
            this.groupBox3.Controls.Add(this.date_Of_AppointmentDateTimePicker);
            this.groupBox3.Controls.Add(academic_QualificationLabel);
            this.groupBox3.Controls.Add(this.acadQual);
            this.groupBox3.Controls.Add(professional_QualificationLabel);
            this.groupBox3.Controls.Add(this.profQual);
            this.groupBox3.Controls.Add(position_HeldLabel);
            this.groupBox3.Controls.Add(this.position_HeldTextBox);
            this.groupBox3.Controls.Add(date_EnlistedLabel);
            this.groupBox3.Controls.Add(this.date_EnlistedDateTimePicker);
            this.groupBox3.Location = new System.Drawing.Point(20, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 444);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STAFF PERSONAL DATA";
            // 
            // staffID
            // 
            this.staffID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "Staff_ID", true));
            this.staffID.Location = new System.Drawing.Point(158, 43);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(200, 20);
            this.staffID.TabIndex = 1;
            // 
            // staffName
            // 
            this.staffName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "Staff_Name", true));
            this.staffName.Location = new System.Drawing.Point(158, 82);
            this.staffName.Name = "staffName";
            this.staffName.Size = new System.Drawing.Size(200, 20);
            this.staffName.TabIndex = 3;
            // 
            // regNum
            // 
            this.regNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "Registered_No", true));
            this.regNum.Location = new System.Drawing.Point(158, 122);
            this.regNum.Name = "regNum";
            this.regNum.Size = new System.Drawing.Size(200, 20);
            this.regNum.TabIndex = 5;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table1BindingSource, "DOB", true));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(158, 157);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dOBDateTimePicker.TabIndex = 7;
            // 
            // ssfNum
            // 
            this.ssfNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "SSF_Number", true));
            this.ssfNum.Location = new System.Drawing.Point(158, 189);
            this.ssfNum.Name = "ssfNum";
            this.ssfNum.Size = new System.Drawing.Size(200, 20);
            this.ssfNum.TabIndex = 9;
            // 
            // date_Of_AppointmentDateTimePicker
            // 
            this.date_Of_AppointmentDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table1BindingSource, "Date_Of_Appointment", true));
            this.date_Of_AppointmentDateTimePicker.Location = new System.Drawing.Point(158, 215);
            this.date_Of_AppointmentDateTimePicker.Name = "date_Of_AppointmentDateTimePicker";
            this.date_Of_AppointmentDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_Of_AppointmentDateTimePicker.TabIndex = 11;
            // 
            // acadQual
            // 
            this.acadQual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "Academic_Qualification", true));
            this.acadQual.Location = new System.Drawing.Point(158, 250);
            this.acadQual.Name = "acadQual";
            this.acadQual.Size = new System.Drawing.Size(200, 20);
            this.acadQual.TabIndex = 13;
            // 
            // profQual
            // 
            this.profQual.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "Professional_Qualification", true));
            this.profQual.Location = new System.Drawing.Point(158, 276);
            this.profQual.Name = "profQual";
            this.profQual.Size = new System.Drawing.Size(200, 20);
            this.profQual.TabIndex = 15;
            // 
            // position_HeldTextBox
            // 
            this.position_HeldTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "Position_Held", true));
            this.position_HeldTextBox.Location = new System.Drawing.Point(158, 314);
            this.position_HeldTextBox.Name = "position_HeldTextBox";
            this.position_HeldTextBox.Size = new System.Drawing.Size(200, 20);
            this.position_HeldTextBox.TabIndex = 17;
            // 
            // date_EnlistedDateTimePicker
            // 
            this.date_EnlistedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table1BindingSource, "Date_Enlisted", true));
            this.date_EnlistedDateTimePicker.Location = new System.Drawing.Point(158, 357);
            this.date_EnlistedDateTimePicker.Name = "date_EnlistedDateTimePicker";
            this.date_EnlistedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_EnlistedDateTimePicker.TabIndex = 23;
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "Image", true));
            this.imageTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageTextBox.Location = new System.Drawing.Point(565, 360);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(26, 20);
            this.imageTextBox.TabIndex = 19;
            // 
            // fP_ScanTextBox
            // 
            this.fP_ScanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource, "FP_Scan", true));
            this.fP_ScanTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fP_ScanTextBox.Location = new System.Drawing.Point(720, 362);
            this.fP_ScanTextBox.Name = "fP_ScanTextBox";
            this.fP_ScanTextBox.Size = new System.Drawing.Size(21, 20);
            this.fP_ScanTextBox.TabIndex = 24;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.remarksTextBox1);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.verifiedTextBox1);
            this.tabPage3.Controls.Add(this.table1DataGridView);
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Controls.Add(remarksLabel);
            this.tabPage3.Controls.Add(this.remarksTextBox);
            this.tabPage3.Controls.Add(this.verifiedTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(908, 534);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "VIEW ATTENDANCE REPORT";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Maroon;
            this.button10.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button10.Location = new System.Drawing.Point(597, 307);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 74);
            this.button10.TabIndex = 2;
            this.button10.Text = "SUBMIT REMARKS";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // remarksTextBox1
            // 
            this.remarksTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource2, "Remarks", true));
            this.remarksTextBox1.Location = new System.Drawing.Point(647, 337);
            this.remarksTextBox1.Name = "remarksTextBox1";
            this.remarksTextBox1.Size = new System.Drawing.Size(34, 20);
            this.remarksTextBox1.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Green;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(614, 157);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 39);
            this.button9.TabIndex = 1;
            this.button9.Text = "VERIFICATION";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // verifiedTextBox1
            // 
            this.verifiedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource2, "Verified", true));
            this.verifiedTextBox1.Location = new System.Drawing.Point(647, 160);
            this.verifiedTextBox1.Name = "verifiedTextBox1";
            this.verifiedTextBox1.Size = new System.Drawing.Size(27, 20);
            this.verifiedTextBox1.TabIndex = 9;
            // 
            // table1DataGridView
            // 
            this.table1DataGridView.AutoGenerateColumns = false;
            this.table1DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.table1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.table1DataGridView.DataSource = this.table1BindingSource2;
            this.table1DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.table1DataGridView.Location = new System.Drawing.Point(51, 103);
            this.table1DataGridView.Name = "table1DataGridView";
            this.table1DataGridView.ReadOnly = true;
            this.table1DataGridView.Size = new System.Drawing.Size(540, 334);
            this.table1DataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Staff_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Staff_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Staff_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Staff_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Time_Arrived";
            this.dataGridViewTextBoxColumn3.HeaderText = "Time_Arrived";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn4.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Verified";
            this.dataGridViewTextBoxColumn5.HeaderText = "Verified";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(752, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DISCREDIT";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(626, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "VERIFY";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource1, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(714, 305);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(169, 83);
            this.remarksTextBox.TabIndex = 5;
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table1";
            this.table1BindingSource1.DataSource = this.attendanceDataSet;
            // 
            // attendanceDataSet
            // 
            this.attendanceDataSet.DataSetName = "attendanceDataSet";
            this.attendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verifiedTextBox
            // 
            this.verifiedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table1BindingSource1, "Verified", true));
            this.verifiedTextBox.Location = new System.Drawing.Point(729, 160);
            this.verifiedTextBox.Multiline = true;
            this.verifiedTextBox.Name = "verifiedTextBox";
            this.verifiedTextBox.Size = new System.Drawing.Size(132, 35);
            this.verifiedTextBox.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage4.Controls.Add(this.reportViewer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(908, 534);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PRINT OUT ATTENDANCE SHEET";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.table1BindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NPBIOMETRIC.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(50, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(796, 389);
            this.reportViewer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "EXIT SYSTEM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // STAFFMEM
            // 
            this.STAFFMEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.STAFFMEM.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STAFFMEM.ForeColor = System.Drawing.Color.Black;
            this.STAFFMEM.Location = new System.Drawing.Point(11, 507);
            this.STAFFMEM.Name = "STAFFMEM";
            this.STAFFMEM.Size = new System.Drawing.Size(185, 86);
            this.STAFFMEM.TabIndex = 5;
            this.STAFFMEM.Text = "STAFF ATTENDANCE SIGN IN";
            this.STAFFMEM.UseVisualStyleBackColor = false;
            this.STAFFMEM.Click += new System.EventHandler(this.button3_Click);
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = false;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table1TableAdapter = this.table1TableAdapter;
            this.tableAdapterManager.UpdateOrder = NPBIOMETRIC.EnlistDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table1TableAdapter2
            // 
            this.table1TableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Table1TableAdapter = this.table1TableAdapter2;
            this.tableAdapterManager2.UpdateOrder = NPBIOMETRIC.AttendanceRecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // STUD
            // 
            this.STUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.STUD.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STUD.Location = new System.Drawing.Point(12, 599);
            this.STUD.Name = "STUD";
            this.STUD.Size = new System.Drawing.Size(183, 80);
            this.STUD.TabIndex = 6;
            this.STUD.Text = "STUDENT MONITOR SIGN IN";
            this.STUD.UseVisualStyleBackColor = false;
            this.STUD.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // essghana
            // 
            this.essghana.AutoSize = true;
            this.essghana.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.essghana.Location = new System.Drawing.Point(199, 10);
            this.essghana.Name = "essghana";
            this.essghana.Size = new System.Drawing.Size(702, 29);
            this.essghana.TabIndex = 7;
            this.essghana.TabStop = true;
            this.essghana.Text = "EXCELLENT SOFTWARE SOLUTIONS (ESS) GHANA";
            this.essghana.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.essghana_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1000, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "THIS SOFTWARE WAS DEVELOPED BY: SELASSIE FORTUNE KOMLA TSADIDEY";
            // 
            // table1TableAdapter1
            // 
            this.table1TableAdapter1.ClearBeforeFill = false;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Table1TableAdapter = this.table1TableAdapter1;
            this.tableAdapterManager1.UpdateOrder = NPBIOMETRIC.attendanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // startup
            // 
            this.startup.Controls.Add(this.SELECTOR);
            this.startup.Controls.Add(this.SUBMITTER);
            this.startup.Controls.Add(this.staffrdb);
            this.startup.Controls.Add(this.studentrdb);
            this.startup.Controls.Add(this.adminrdb);
            this.startup.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startup.Location = new System.Drawing.Point(-1, 48);
            this.startup.Name = "startup";
            this.startup.Size = new System.Drawing.Size(197, 201);
            this.startup.TabIndex = 9;
            this.startup.TabStop = false;
            this.startup.Text = "STARTUP PORTAL";
            // 
            // SELECTOR
            // 
            this.SELECTOR.AutoSize = true;
            this.SELECTOR.Location = new System.Drawing.Point(19, 38);
            this.SELECTOR.Name = "SELECTOR";
            this.SELECTOR.Size = new System.Drawing.Size(159, 17);
            this.SELECTOR.TabIndex = 4;
            this.SELECTOR.Text = "PLEASE SELECT ONE";
            // 
            // SUBMITTER
            // 
            this.SUBMITTER.Location = new System.Drawing.Point(6, 151);
            this.SUBMITTER.Name = "SUBMITTER";
            this.SUBMITTER.Size = new System.Drawing.Size(190, 41);
            this.SUBMITTER.TabIndex = 3;
            this.SUBMITTER.Text = "SUBMIT";
            this.SUBMITTER.UseVisualStyleBackColor = true;
            this.SUBMITTER.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // staffrdb
            // 
            this.staffrdb.AutoSize = true;
            this.staffrdb.Location = new System.Drawing.Point(32, 98);
            this.staffrdb.Name = "staffrdb";
            this.staffrdb.Size = new System.Drawing.Size(71, 21);
            this.staffrdb.TabIndex = 2;
            this.staffrdb.TabStop = true;
            this.staffrdb.Text = "STAFF";
            this.staffrdb.UseVisualStyleBackColor = true;
            // 
            // studentrdb
            // 
            this.studentrdb.AutoSize = true;
            this.studentrdb.Location = new System.Drawing.Point(31, 125);
            this.studentrdb.Name = "studentrdb";
            this.studentrdb.Size = new System.Drawing.Size(94, 21);
            this.studentrdb.TabIndex = 1;
            this.studentrdb.TabStop = true;
            this.studentrdb.Text = "STUDENT";
            this.studentrdb.UseVisualStyleBackColor = true;
            // 
            // adminrdb
            // 
            this.adminrdb.AutoSize = true;
            this.adminrdb.Location = new System.Drawing.Point(32, 71);
            this.adminrdb.Name = "adminrdb";
            this.adminrdb.Size = new System.Drawing.Size(148, 21);
            this.adminrdb.TabIndex = 0;
            this.adminrdb.TabStop = true;
            this.adminrdb.Text = "ADMINISTRATOR";
            this.adminrdb.UseVisualStyleBackColor = true;
            // 
            // adminstatus
            // 
            this.adminstatus.AutoSize = true;
            this.adminstatus.Location = new System.Drawing.Point(25, 29);
            this.adminstatus.Name = "adminstatus";
            this.adminstatus.Size = new System.Drawing.Size(0, 13);
            this.adminstatus.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1276, 736);
            this.Controls.Add(this.startup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.essghana);
            this.Controls.Add(this.STUD);
            this.Controls.Add(this.STAFFMEM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "NP BIOMETRIC ATTENDANCE SYSTEM - REGISTRATION AND SIGN IN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enlistDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingNavigator)).EndInit();
            this.table1BindingNavigator.ResumeLayout(false);
            this.table1BindingNavigator.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.startup.ResumeLayout(false);
            this.startup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox admintb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ADLIN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button STAFFMEM;
        private System.Windows.Forms.GroupBox groupBox3;
        private EnlistDataSet enlistDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private EnlistDataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private EnlistDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox staffID;
        private System.Windows.Forms.TextBox staffName;
        private System.Windows.Forms.TextBox regNum;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox ssfNum;
        private System.Windows.Forms.DateTimePicker date_Of_AppointmentDateTimePicker;
        private System.Windows.Forms.TextBox acadQual;
        private System.Windows.Forms.TextBox profQual;
        private System.Windows.Forms.TextBox position_HeldTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.DateTimePicker date_EnlistedDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox fP_ScanTextBox;
        private attendanceDataSet attendanceDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private attendanceDataSetTableAdapters.Table1TableAdapter table1TableAdapter1;
        private attendanceDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.TextBox verifiedTextBox;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button ADLOT;
        private System.Windows.Forms.BindingNavigator table1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton table1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox staff_NameTextBox1;
        private AttendanceRecDataSet attendanceRecDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource2;
        private AttendanceRecDataSetTableAdapters.Table1TableAdapter table1TableAdapter2;
        private AttendanceRecDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView table1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox remarksTextBox1;
        private System.Windows.Forms.TextBox verifiedTextBox1;
        private System.Windows.Forms.Button STUD;
        private System.Windows.Forms.LinkLabel essghana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox startup;
        private System.Windows.Forms.RadioButton staffrdb;
        private System.Windows.Forms.RadioButton studentrdb;
        private System.Windows.Forms.RadioButton adminrdb;
        private System.Windows.Forms.Label SELECTOR;
        private System.Windows.Forms.Button SUBMITTER;
        private System.Windows.Forms.Label adminstatus;
    }
}

