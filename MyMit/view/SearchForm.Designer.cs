namespace MyMit.view
{
    partial class FormSearchmeeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchmeeting));
            this.dataGridViewEvents01 = new System.Windows.Forms.DataGridView();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents01)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvents01
            // 
            this.dataGridViewEvents01.AllowUserToAddRows = false;
            this.dataGridViewEvents01.AllowUserToDeleteRows = false;
            this.dataGridViewEvents01.AllowUserToOrderColumns = true;
            this.dataGridViewEvents01.AllowUserToResizeColumns = false;
            this.dataGridViewEvents01.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewEvents01.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEvents01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEvents01.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvents01.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewEvents01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents01.ColumnHeadersVisible = false;
            this.dataGridViewEvents01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColTime,
            this.ColSubject});
            this.dataGridViewEvents01.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEvents01.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewEvents01.Location = new System.Drawing.Point(0, 39);
            this.dataGridViewEvents01.MultiSelect = false;
            this.dataGridViewEvents01.Name = "dataGridViewEvents01";
            this.dataGridViewEvents01.ReadOnly = true;
            this.dataGridViewEvents01.RowHeadersVisible = false;
            this.dataGridViewEvents01.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEvents01.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewEvents01.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewEvents01.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewEvents01.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewEvents01.RowTemplate.ReadOnly = true;
            this.dataGridViewEvents01.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEvents01.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewEvents01.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents01.Size = new System.Drawing.Size(475, 410);
            this.dataGridViewEvents01.TabIndex = 12;
            this.dataGridViewEvents01.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvents01_CellClick);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(12, 12);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(376, 20);
            this.textBoxFilter.TabIndex = 13;
            this.textBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyDown);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(394, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColTime
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColTime.FillWeight = 50F;
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.ReadOnly = true;
            // 
            // ColSubject
            // 
            this.ColSubject.HeaderText = "Subject";
            this.ColSubject.Name = "ColSubject";
            this.ColSubject.ReadOnly = true;
            // 
            // FormSearchmeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.dataGridViewEvents01);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearchmeeting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Meeting";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEvents01;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubject;
    }
}