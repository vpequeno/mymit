namespace MyMit.view
{
    partial class MeetingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingView));
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDropDownDuration = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewGuests = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxAgenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.ColumnTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUser = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panelEditMeeting = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTranscription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMeetingminutes = new System.Windows.Forms.TextBox();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonExportPdf = new System.Windows.Forms.Button();
            this.buttonRec = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxRecord = new System.Windows.Forms.GroupBox();
            this.pictureBoxRecord = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStopPlaying = new System.Windows.Forms.Button();
            this.buttonAttendeeList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.panelEditMeeting.SuspendLayout();
            this.groupBoxRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSubject.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.textBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubject.Location = new System.Drawing.Point(27, 12);
            this.textBoxSubject.MaxLength = 255;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(744, 24);
            this.textBoxSubject.TabIndex = 0;
            this.textBoxSubject.Text = "Subject";
            this.textBoxSubject.Enter += new System.EventHandler(this.textBoxSubject_Enter);
            this.textBoxSubject.Leave += new System.EventHandler(this.textBoxSubject_Leave);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(27, 70);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type:";
            // 
            // comboDropDownDuration
            // 
            this.comboDropDownDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDropDownDuration.FormattingEnabled = true;
            this.comboDropDownDuration.Location = new System.Drawing.Point(166, 69);
            this.comboDropDownDuration.Name = "comboDropDownDuration";
            this.comboDropDownDuration.Size = new System.Drawing.Size(121, 21);
            this.comboDropDownDuration.TabIndex = 9;
            this.comboDropDownDuration.SelectedIndexChanged += new System.EventHandler(this.comboDropDownDuration_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(27, 121);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(150, 21);
            this.comboBoxType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "minutes";
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(293, 70);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.ReadOnly = true;
            this.textBoxMinutes.Size = new System.Drawing.Size(37, 20);
            this.textBoxMinutes.TabIndex = 13;
            this.textBoxMinutes.Text = "0";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(606, 70);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(52, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(664, 70);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(52, 23);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Guests:";
            // 
            // dataGridViewGuests
            // 
            this.dataGridViewGuests.AllowUserToAddRows = false;
            this.dataGridViewGuests.AllowUserToDeleteRows = false;
            this.dataGridViewGuests.AllowUserToOrderColumns = true;
            this.dataGridViewGuests.AllowUserToResizeColumns = false;
            this.dataGridViewGuests.AllowUserToResizeRows = false;
            this.dataGridViewGuests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGuests.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuests.ColumnHeadersVisible = false;
            this.dataGridViewGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnSelected,
            this.ColumnName});
            this.dataGridViewGuests.Location = new System.Drawing.Point(27, 171);
            this.dataGridViewGuests.MultiSelect = false;
            this.dataGridViewGuests.Name = "dataGridViewGuests";
            this.dataGridViewGuests.RowHeadersVisible = false;
            this.dataGridViewGuests.RowHeadersWidth = 82;
            this.dataGridViewGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGuests.Size = new System.Drawing.Size(387, 77);
            this.dataGridViewGuests.TabIndex = 21;
            this.dataGridViewGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuests_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 20;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnSelected
            // 
            this.ColumnSelected.FillWeight = 30F;
            this.ColumnSelected.HeaderText = "Invited";
            this.ColumnSelected.MinimumWidth = 10;
            this.ColumnSelected.Name = "ColumnSelected";
            this.ColumnSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 150;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // textBoxAgenda
            // 
            this.textBoxAgenda.Location = new System.Drawing.Point(28, 281);
            this.textBoxAgenda.Multiline = true;
            this.textBoxAgenda.Name = "textBoxAgenda";
            this.textBoxAgenda.Size = new System.Drawing.Size(743, 244);
            this.textBoxAgenda.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Agenda:";
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AllowUserToAddRows = false;
            this.dataGridViewTasks.AllowUserToDeleteRows = false;
            this.dataGridViewTasks.AllowUserToResizeColumns = false;
            this.dataGridViewTasks.AllowUserToResizeRows = false;
            this.dataGridViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTaskId,
            this.ColumnUser,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewTasks.Location = new System.Drawing.Point(27, 50);
            this.dataGridViewTasks.MultiSelect = false;
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersVisible = false;
            this.dataGridViewTasks.RowHeadersWidth = 82;
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.Size = new System.Drawing.Size(743, 141);
            this.dataGridViewTasks.TabIndex = 25;
            // 
            // ColumnTaskId
            // 
            this.ColumnTaskId.HeaderText = "ID";
            this.ColumnTaskId.MinimumWidth = 10;
            this.ColumnTaskId.Name = "ColumnTaskId";
            this.ColumnTaskId.Visible = false;
            // 
            // ColumnUser
            // 
            this.ColumnUser.FillWeight = 76.14214F;
            this.ColumnUser.HeaderText = "User";
            this.ColumnUser.MinimumWidth = 150;
            this.ColumnUser.Name = "ColumnUser";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 214.6056F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Task";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 300;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tasks:";
            // 
            // panelEditMeeting
            // 
            this.panelEditMeeting.Controls.Add(this.label10);
            this.panelEditMeeting.Controls.Add(this.textBoxTranscription);
            this.panelEditMeeting.Controls.Add(this.label9);
            this.panelEditMeeting.Controls.Add(this.textBoxMeetingminutes);
            this.panelEditMeeting.Controls.Add(this.buttonRemoveTask);
            this.panelEditMeeting.Controls.Add(this.dataGridViewTasks);
            this.panelEditMeeting.Controls.Add(this.buttonAddTask);
            this.panelEditMeeting.Controls.Add(this.label8);
            this.panelEditMeeting.Location = new System.Drawing.Point(1, 531);
            this.panelEditMeeting.Name = "panelEditMeeting";
            this.panelEditMeeting.Size = new System.Drawing.Size(780, 970);
            this.panelEditMeeting.TabIndex = 27;
            this.panelEditMeeting.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 604);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Audio Transcription:";
            // 
            // textBoxTranscription
            // 
            this.textBoxTranscription.Location = new System.Drawing.Point(27, 620);
            this.textBoxTranscription.Multiline = true;
            this.textBoxTranscription.Name = "textBoxTranscription";
            this.textBoxTranscription.Size = new System.Drawing.Size(743, 330);
            this.textBoxTranscription.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Meeting Minutes:";
            // 
            // textBoxMeetingminutes
            // 
            this.textBoxMeetingminutes.Location = new System.Drawing.Point(26, 255);
            this.textBoxMeetingminutes.Multiline = true;
            this.textBoxMeetingminutes.Name = "textBoxMeetingminutes";
            this.textBoxMeetingminutes.Size = new System.Drawing.Size(743, 330);
            this.textBoxMeetingminutes.TabIndex = 28;
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveTask.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveTask.BackgroundImage = global::MyMit.Properties.Resources.btn_remove;
            this.buttonRemoveTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemoveTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveTask.FlatAppearance.BorderSize = 0;
            this.buttonRemoveTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveTask.Location = new System.Drawing.Point(691, 197);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(32, 35);
            this.buttonRemoveTask.TabIndex = 27;
            this.buttonRemoveTask.UseVisualStyleBackColor = false;
            this.buttonRemoveTask.Click += new System.EventHandler(this.buttonRemoveTask_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTask.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddTask.BackgroundImage = global::MyMit.Properties.Resources.btn_add;
            this.buttonAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTask.FlatAppearance.BorderSize = 0;
            this.buttonAddTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTask.Location = new System.Drawing.Point(729, 197);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(40, 35);
            this.buttonAddTask.TabIndex = 26;
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonExportPdf
            // 
            this.buttonExportPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportPdf.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonExportPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExportPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExportPdf.FlatAppearance.BorderSize = 0;
            this.buttonExportPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExportPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExportPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportPdf.Location = new System.Drawing.Point(420, 171);
            this.buttonExportPdf.Name = "buttonExportPdf";
            this.buttonExportPdf.Size = new System.Drawing.Size(69, 45);
            this.buttonExportPdf.TabIndex = 29;
            this.buttonExportPdf.Text = "Meeting Minutes";
            this.buttonExportPdf.UseVisualStyleBackColor = false;
            this.buttonExportPdf.Visible = false;
            this.buttonExportPdf.Click += new System.EventHandler(this.buttonExportPdf_Click);
            // 
            // buttonRec
            // 
            this.buttonRec.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRec.ForeColor = System.Drawing.Color.White;
            this.buttonRec.Location = new System.Drawing.Point(15, 19);
            this.buttonRec.Name = "buttonRec";
            this.buttonRec.Size = new System.Drawing.Size(52, 23);
            this.buttonRec.TabIndex = 30;
            this.buttonRec.Text = "Rec";
            this.buttonRec.UseVisualStyleBackColor = false;
            this.buttonRec.Click += new System.EventHandler(this.buttonRec_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(73, 19);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(52, 23);
            this.buttonStop.TabIndex = 31;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBoxRecord
            // 
            this.groupBoxRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRecord.Controls.Add(this.buttonRec);
            this.groupBoxRecord.Controls.Add(this.buttonStop);
            this.groupBoxRecord.Location = new System.Drawing.Point(606, 220);
            this.groupBoxRecord.Name = "groupBoxRecord";
            this.groupBoxRecord.Size = new System.Drawing.Size(146, 55);
            this.groupBoxRecord.TabIndex = 32;
            this.groupBoxRecord.TabStop = false;
            this.groupBoxRecord.Text = "Record";
            this.groupBoxRecord.Visible = false;
            // 
            // pictureBoxRecord
            // 
            this.pictureBoxRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRecord.Image = global::MyMit.Properties.Resources.recording;
            this.pictureBoxRecord.Location = new System.Drawing.Point(556, 228);
            this.pictureBoxRecord.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRecord.Name = "pictureBoxRecord";
            this.pictureBoxRecord.Size = new System.Drawing.Size(46, 45);
            this.pictureBoxRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRecord.TabIndex = 34;
            this.pictureBoxRecord.TabStop = false;
            this.pictureBoxRecord.Visible = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(606, 171);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(67, 45);
            this.buttonPlay.TabIndex = 35;
            this.buttonPlay.Text = "Play Audio";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Visible = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStopPlaying
            // 
            this.buttonStopPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStopPlaying.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonStopPlaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStopPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStopPlaying.FlatAppearance.BorderSize = 0;
            this.buttonStopPlaying.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStopPlaying.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStopPlaying.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStopPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopPlaying.Location = new System.Drawing.Point(679, 171);
            this.buttonStopPlaying.Name = "buttonStopPlaying";
            this.buttonStopPlaying.Size = new System.Drawing.Size(73, 45);
            this.buttonStopPlaying.TabIndex = 36;
            this.buttonStopPlaying.Text = "Stop Audio";
            this.buttonStopPlaying.UseVisualStyleBackColor = false;
            this.buttonStopPlaying.Visible = false;
            this.buttonStopPlaying.Click += new System.EventHandler(this.buttonStopPlaying_Click);
            // 
            // buttonAttendeeList
            // 
            this.buttonAttendeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAttendeeList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAttendeeList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAttendeeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAttendeeList.FlatAppearance.BorderSize = 0;
            this.buttonAttendeeList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAttendeeList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAttendeeList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttendeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttendeeList.Location = new System.Drawing.Point(491, 171);
            this.buttonAttendeeList.Name = "buttonAttendeeList";
            this.buttonAttendeeList.Size = new System.Drawing.Size(69, 45);
            this.buttonAttendeeList.TabIndex = 37;
            this.buttonAttendeeList.Text = "Attendee List";
            this.buttonAttendeeList.UseVisualStyleBackColor = false;
            this.buttonAttendeeList.Visible = false;
            this.buttonAttendeeList.Click += new System.EventHandler(this.buttonAttendeeList_Click);
            // 
            // MeetingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 454);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAttendeeList);
            this.Controls.Add(this.buttonStopPlaying);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.pictureBoxRecord);
            this.Controls.Add(this.groupBoxRecord);
            this.Controls.Add(this.buttonExportPdf);
            this.Controls.Add(this.panelEditMeeting);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAgenda);
            this.Controls.Add(this.dataGridViewGuests);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboDropDownDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.textBoxSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeetingView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meeting";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.panelEditMeeting.ResumeLayout(false);
            this.panelEditMeeting.PerformLayout();
            this.groupBoxRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDropDownDuration;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewGuests;
        private System.Windows.Forms.TextBox textBoxAgenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Panel panelEditMeeting;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaskId;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonRemoveTask;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxMeetingminutes;
        private System.Windows.Forms.Button buttonExportPdf;
        private System.Windows.Forms.Button buttonRec;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBoxRecord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTranscription;
        private System.Windows.Forms.PictureBox pictureBoxRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStopPlaying;
        private System.Windows.Forms.Button buttonAttendeeList;
    }
}