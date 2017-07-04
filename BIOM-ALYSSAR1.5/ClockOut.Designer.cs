namespace BIOM_ALYSSAR1._5
{
    partial class ClockOut
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(881, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.tasksToolStripMenuItem.Text = "Home";
            this.tasksToolStripMenuItem.Click += new System.EventHandler(this.tasksToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID,
            this.name,
            this.division,
            this.timeIn,
            this.timeOut});
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(710, 337);
            this.dataGridView1.TabIndex = 15;
            // 
            // employeeID
            // 
            this.employeeID.HeaderText = "Employee ID";
            this.employeeID.Name = "employeeID";
            this.employeeID.Width = 70;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // division
            // 
            this.division.HeaderText = "Division";
            this.division.Name = "division";
            this.division.Width = 90;
            // 
            // timeIn
            // 
            this.timeIn.HeaderText = "Time In";
            this.timeIn.Name = "timeIn";
            this.timeIn.Width = 120;
            // 
            // timeOut
            // 
            this.timeOut.HeaderText = "Time Out";
            this.timeOut.Name = "timeOut";
            this.timeOut.Width = 120;
            // 
            // ClockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 496);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClockOut";
            this.Text = "ClockOut";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn division;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOut;
    }
}