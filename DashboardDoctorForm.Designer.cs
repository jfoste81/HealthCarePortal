namespace HealthCarePortal
{
    partial class DashboardDoctorForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBoxToday = new System.Windows.Forms.GroupBox();
            this.groupBoxMessagesOverview = new System.Windows.Forms.GroupBox();
            this.groupBoxNotificationsOverview = new System.Windows.Forms.GroupBox();
            this.listViewTodayAppointments = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Patients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMessagesOverview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewNotificationsOverview = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxToday.SuspendLayout();
            this.groupBoxMessagesOverview.SuspendLayout();
            this.groupBoxNotificationsOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxNotificationsOverview);
            this.tabPage1.Controls.Add(this.groupBoxMessagesOverview);
            this.tabPage1.Controls.Add(this.groupBoxToday);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inbox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Patients";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBoxToday
            // 
            this.groupBoxToday.Controls.Add(this.listViewTodayAppointments);
            this.groupBoxToday.Location = new System.Drawing.Point(7, 6);
            this.groupBoxToday.Name = "groupBoxToday";
            this.groupBoxToday.Size = new System.Drawing.Size(521, 195);
            this.groupBoxToday.TabIndex = 0;
            this.groupBoxToday.TabStop = false;
            this.groupBoxToday.Text = "Today\'s Schedule";
            // 
            // groupBoxMessagesOverview
            // 
            this.groupBoxMessagesOverview.Controls.Add(this.listViewMessagesOverview);
            this.groupBoxMessagesOverview.Location = new System.Drawing.Point(7, 206);
            this.groupBoxMessagesOverview.Name = "groupBoxMessagesOverview";
            this.groupBoxMessagesOverview.Size = new System.Drawing.Size(521, 191);
            this.groupBoxMessagesOverview.TabIndex = 1;
            this.groupBoxMessagesOverview.TabStop = false;
            this.groupBoxMessagesOverview.Text = "Recent Messages";
            // 
            // groupBoxNotificationsOverview
            // 
            this.groupBoxNotificationsOverview.Controls.Add(this.listViewNotificationsOverview);
            this.groupBoxNotificationsOverview.Location = new System.Drawing.Point(535, 7);
            this.groupBoxNotificationsOverview.Name = "groupBoxNotificationsOverview";
            this.groupBoxNotificationsOverview.Size = new System.Drawing.Size(227, 387);
            this.groupBoxNotificationsOverview.TabIndex = 2;
            this.groupBoxNotificationsOverview.TabStop = false;
            this.groupBoxNotificationsOverview.Text = "Notifications";
            // 
            // listViewTodayAppointments
            // 
            this.listViewTodayAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Patients});
            this.listViewTodayAppointments.FullRowSelect = true;
            this.listViewTodayAppointments.HideSelection = false;
            this.listViewTodayAppointments.Location = new System.Drawing.Point(7, 20);
            this.listViewTodayAppointments.MultiSelect = false;
            this.listViewTodayAppointments.Name = "listViewTodayAppointments";
            this.listViewTodayAppointments.Size = new System.Drawing.Size(514, 169);
            this.listViewTodayAppointments.TabIndex = 0;
            this.listViewTodayAppointments.UseCompatibleStateImageBehavior = false;
            this.listViewTodayAppointments.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 131;
            // 
            // Patients
            // 
            this.Patients.Text = "Patients";
            this.Patients.Width = 380;
            // 
            // listViewMessagesOverview
            // 
            this.listViewMessagesOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewMessagesOverview.FullRowSelect = true;
            this.listViewMessagesOverview.HideSelection = false;
            this.listViewMessagesOverview.Location = new System.Drawing.Point(6, 19);
            this.listViewMessagesOverview.MultiSelect = false;
            this.listViewMessagesOverview.Name = "listViewMessagesOverview";
            this.listViewMessagesOverview.Size = new System.Drawing.Size(509, 169);
            this.listViewMessagesOverview.TabIndex = 0;
            this.listViewMessagesOverview.UseCompatibleStateImageBehavior = false;
            this.listViewMessagesOverview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "From";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Subject";
            this.columnHeader3.Width = 251;
            // 
            // listViewNotificationsOverview
            // 
            this.listViewNotificationsOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewNotificationsOverview.FullRowSelect = true;
            this.listViewNotificationsOverview.HideSelection = false;
            this.listViewNotificationsOverview.Location = new System.Drawing.Point(7, 20);
            this.listViewNotificationsOverview.MultiSelect = false;
            this.listViewNotificationsOverview.Name = "listViewNotificationsOverview";
            this.listViewNotificationsOverview.Size = new System.Drawing.Size(220, 361);
            this.listViewNotificationsOverview.TabIndex = 0;
            this.listViewNotificationsOverview.UseCompatibleStateImageBehavior = false;
            this.listViewNotificationsOverview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date/Time";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 122;
            // 
            // DashboardDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "DashboardDoctorForm";
            this.Text = "DashboardDoctorForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxToday.ResumeLayout(false);
            this.groupBoxMessagesOverview.ResumeLayout(false);
            this.groupBoxNotificationsOverview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxMessagesOverview;
        private System.Windows.Forms.GroupBox groupBoxToday;
        private System.Windows.Forms.GroupBox groupBoxNotificationsOverview;
        private System.Windows.Forms.ListView listViewMessagesOverview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewTodayAppointments;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Patients;
        private System.Windows.Forms.ListView listViewNotificationsOverview;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}