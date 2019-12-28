﻿namespace PSSC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTask = new System.Windows.Forms.Button();
            this.panelindex = new System.Windows.Forms.Panel();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.TaskChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tasksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.psscdbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psscdbDataSet1 = new PSSC.PsscdbDataSet1();
            this.panelTasks = new System.Windows.Forms.Panel();
            this.kryptonButtonStatusChange = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.kryptonDataGridViewTasks = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authoruidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.developeruidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPower = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tasksTableAdapter = new PSSC.PsscdbDataSet1TableAdapters.TasksTableAdapter();
            this.tableAdapterManager = new PSSC.PsscdbDataSet1TableAdapters.TableAdapterManager();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ModifyButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DeleteButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psscdbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psscdbDataSet1)).BeginInit();
            this.panelTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.panelPower.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-3, -16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 88);
            this.panel1.TabIndex = 1;
            // 
            // buttonTask
            // 
            this.buttonTask.FlatAppearance.BorderSize = 0;
            this.buttonTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTask.ForeColor = System.Drawing.Color.White;
            this.buttonTask.Location = new System.Drawing.Point(-3, 117);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(204, 65);
            this.buttonTask.TabIndex = 0;
            this.buttonTask.Text = "Tasks";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // panelindex
            // 
            this.panelindex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelindex.BackgroundImage")));
            this.panelindex.Location = new System.Drawing.Point(191, 117);
            this.panelindex.Name = "panelindex";
            this.panelindex.Size = new System.Drawing.Size(10, 65);
            this.panelindex.TabIndex = 5;
            // 
            // panelStatistic
            // 
            this.panelStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.panelStatistic.Controls.Add(this.panelDashboard);
            this.panelStatistic.Controls.Add(this.TaskChart);
            this.panelStatistic.Controls.Add(this.panelTasks);
            this.panelStatistic.Location = new System.Drawing.Point(207, 73);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(809, 514);
            this.panelStatistic.TabIndex = 6;
            // 
            // TaskChart
            // 
            this.TaskChart.BackColor = System.Drawing.Color.Transparent;
            this.TaskChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TaskChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.TaskChart.ChartAreas.Add(chartArea4);
            this.TaskChart.DataSource = this.tasksBindingSource1;
            legend4.Name = "Legend1";
            this.TaskChart.Legends.Add(legend4);
            this.TaskChart.Location = new System.Drawing.Point(21, 23);
            this.TaskChart.Name = "TaskChart";
            this.TaskChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.TaskChart.Series.Add(series4);
            this.TaskChart.Size = new System.Drawing.Size(422, 241);
            this.TaskChart.TabIndex = 1;
            this.TaskChart.Text = "chart1";
            // 
            // tasksBindingSource1
            // 
            this.tasksBindingSource1.DataMember = "Tasks";
            this.tasksBindingSource1.DataSource = this.psscdbDataSet1BindingSource;
            // 
            // psscdbDataSet1BindingSource
            // 
            this.psscdbDataSet1BindingSource.DataSource = this.psscdbDataSet1;
            this.psscdbDataSet1BindingSource.Position = 0;
            // 
            // psscdbDataSet1
            // 
            this.psscdbDataSet1.DataSetName = "PsscdbDataSet1";
            this.psscdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelTasks
            // 
            this.panelTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(35)))));
            this.panelTasks.Controls.Add(this.kryptonButtonStatusChange);
            this.panelTasks.Controls.Add(this.comboBoxStatus);
            this.panelTasks.Controls.Add(this.kryptonDataGridViewTasks);
            this.panelTasks.Location = new System.Drawing.Point(16, 15);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.Size = new System.Drawing.Size(742, 378);
            this.panelTasks.TabIndex = 0;
            // 
            // kryptonButtonStatusChange
            // 
            this.kryptonButtonStatusChange.Location = new System.Drawing.Point(155, 271);
            this.kryptonButtonStatusChange.Name = "kryptonButtonStatusChange";
            this.kryptonButtonStatusChange.Size = new System.Drawing.Size(90, 26);
            this.kryptonButtonStatusChange.TabIndex = 2;
            this.kryptonButtonStatusChange.Values.Text = "Change Status";
            this.kryptonButtonStatusChange.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Planned",
            "InWork",
            "Realized",
            "Canceled"});
            this.comboBoxStatus.Location = new System.Drawing.Point(3, 276);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(145, 21);
            this.comboBoxStatus.TabIndex = 1;
            // 
            // kryptonDataGridViewTasks
            // 
            this.kryptonDataGridViewTasks.AutoGenerateColumns = false;
            this.kryptonDataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridViewTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.authoruidDataGridViewTextBoxColumn,
            this.developeruidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.Id});
            this.kryptonDataGridViewTasks.DataSource = this.tasksBindingSource;
            this.kryptonDataGridViewTasks.Location = new System.Drawing.Point(3, 7);
            this.kryptonDataGridViewTasks.MultiSelect = false;
            this.kryptonDataGridViewTasks.Name = "kryptonDataGridViewTasks";
            this.kryptonDataGridViewTasks.ReadOnly = true;
            this.kryptonDataGridViewTasks.Size = new System.Drawing.Size(741, 259);
            this.kryptonDataGridViewTasks.TabIndex = 0;
            this.kryptonDataGridViewTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridViewTasks_CellContentClick);
            this.kryptonDataGridViewTasks.SelectionChanged += new System.EventHandler(this.kryptonDataGridView1_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 240;
            // 
            // authoruidDataGridViewTextBoxColumn
            // 
            this.authoruidDataGridViewTextBoxColumn.DataPropertyName = "Author_uid";
            this.authoruidDataGridViewTextBoxColumn.HeaderText = "Author_uid";
            this.authoruidDataGridViewTextBoxColumn.Name = "authoruidDataGridViewTextBoxColumn";
            this.authoruidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // developeruidDataGridViewTextBoxColumn
            // 
            this.developeruidDataGridViewTextBoxColumn.DataPropertyName = "Developer_uid";
            this.developeruidDataGridViewTextBoxColumn.HeaderText = "Developer_uid";
            this.developeruidDataGridViewTextBoxColumn.Name = "developeruidDataGridViewTextBoxColumn";
            this.developeruidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 90;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.ReadOnly = true;
            this.priorityDataGridViewTextBoxColumn.Width = 70;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.psscdbDataSet1;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(-2, 182);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(204, 65);
            this.buttonDashboard.TabIndex = 9;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 34);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 19);
            this.panel2.TabIndex = 11;
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            // 
            // panelPower
            // 
            this.panelPower.Controls.Add(this.button4);
            this.panelPower.Controls.Add(this.button3);
            this.panelPower.Location = new System.Drawing.Point(54, 551);
            this.panelPower.Name = "panelPower";
            this.panelPower.Size = new System.Drawing.Size(86, 44);
            this.panelPower.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(43, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 34);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(-1, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 34);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(-5, 551);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 61);
            this.panel4.TabIndex = 13;
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(153, 551);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(48, 61);
            this.panel5.TabIndex = 14;
            this.panel5.MouseEnter += new System.EventHandler(this.panel5_MouseEnter);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(-2, 518);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(203, 32);
            this.panel6.TabIndex = 15;
            this.panel6.MouseEnter += new System.EventHandler(this.panel6_MouseEnter);
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TasksTableAdapter = this.tasksTableAdapter;
            this.tableAdapterManager.UpdateOrder = PSSC.PsscdbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black;
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.FlatAppearance.BorderSize = 0;
            this.buttonStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistic.ForeColor = System.Drawing.Color.White;
            this.buttonStatistic.Location = new System.Drawing.Point(-2, 248);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(204, 65);
            this.buttonStatistic.TabIndex = 16;
            this.buttonStatistic.Text = "Statistic";
            this.buttonStatistic.UseVisualStyleBackColor = true;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.groupBox3);
            this.panelDashboard.Controls.Add(this.groupBox1);
            this.panelDashboard.Location = new System.Drawing.Point(9, 6);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(699, 505);
            this.panelDashboard.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ModifyButton);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(31, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Task";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.DeleteButton);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(29, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 61);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Task";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(284, 301);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 25);
            this.AddButton.TabIndex = 0;
            this.AddButton.Values.Text = "Add";
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(179, 301);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(90, 25);
            this.ModifyButton.TabIndex = 1;
            this.ModifyButton.Values.Text = "Modify";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(286, 21);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(90, 25);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Values.Text = "Delete";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task id:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 27);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(275, 20);
            this.textBox5.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(84, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Task id:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(59, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Task Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 109);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(275, 55);
            this.textBox3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Task Description:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(275, 20);
            this.textBox4.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(62, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = " Developer:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(142, 224);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(275, 20);
            this.textBox6.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(92, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Status:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(142, 266);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(275, 20);
            this.textBox7.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(84, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Priority:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1028, 599);
            this.Controls.Add(this.panelindex);
            this.Controls.Add(this.buttonStatistic);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelPower);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonDashboard);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelStatistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psscdbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psscdbDataSet1)).EndInit();
            this.panelTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridViewTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.panelPower.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTask;
        private System.Windows.Forms.Panel panelindex;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelPower;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelTasks;
        private PsscdbDataSet1 psscdbDataSet1;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private PsscdbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridViewTasks;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonStatusChange;
        public PsscdbDataSet1TableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authoruidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn developeruidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.DataVisualization.Charting.Chart TaskChart;
        private System.Windows.Forms.BindingSource tasksBindingSource1;
        private System.Windows.Forms.BindingSource psscdbDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton DeleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ModifyButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AddButton;
    }
}