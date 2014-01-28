namespace HostsFileManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.hostsGrid = new System.Windows.Forms.DataGridView();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.searchText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hostsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // hostsGrid
            // 
            this.hostsGrid.AllowUserToOrderColumns = true;
            this.hostsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hostsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IP,
            this.HostName,
            this.HostID,
            this.GroupField});
            this.hostsGrid.Location = new System.Drawing.Point(35, 108);
            this.hostsGrid.Name = "hostsGrid";
            this.hostsGrid.Size = new System.Drawing.Size(604, 206);
            this.hostsGrid.TabIndex = 1;
            this.hostsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hostsGrid_CellContentClick);
            this.hostsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaveEdit);
            this.hostsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ChooseGroups);
            this.hostsGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DoNothing);
            this.hostsGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.hostsGrid_RowsAdded);
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IpAddress";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.Width = 150;
            // 
            // HostName
            // 
            this.HostName.DataPropertyName = "HostName";
            this.HostName.HeaderText = "HostName";
            this.HostName.Name = "HostName";
            this.HostName.Width = 260;
            // 
            // HostID
            // 
            this.HostID.DataPropertyName = "HostID";
            this.HostID.HeaderText = "HostID";
            this.HostID.Name = "HostID";
            this.HostID.ReadOnly = true;
            this.HostID.Visible = false;
            // 
            // GroupField
            // 
            this.GroupField.DataPropertyName = "(none)";
            this.GroupField.HeaderText = "Group";
            this.GroupField.MaxDropDownItems = 100;
            this.GroupField.Name = "GroupField";
            this.GroupField.Width = 150;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(453, 50);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 20);
            this.searchText.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.R_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Publish";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 483);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.hostsGrid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hosts File Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView hostsGrid;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostID;
        private System.Windows.Forms.DataGridViewComboBoxColumn GroupField;

    }
}

