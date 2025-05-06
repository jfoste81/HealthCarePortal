namespace HealthCarePortal.Forms
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
            this.tabControlDoctor = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.groupBoxNotificationsOverview = new System.Windows.Forms.GroupBox();
            this.listViewNotificationsOverview = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxToday = new System.Windows.Forms.GroupBox();
            this.listViewTodayAppointments = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Patients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPagePatients = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewPatients = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageInbox = new System.Windows.Forms.TabPage();
            this.listViewInbox = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNewMessage = new System.Windows.Forms.Button();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.buttonCancelAppointment = new System.Windows.Forms.Button();
            this.buttonEditAppointment = new System.Windows.Forms.Button();
            this.listViewSchedule = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControlDoctor.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            this.groupBoxNotificationsOverview.SuspendLayout();
            this.groupBoxToday.SuspendLayout();
            this.tabPagePatients.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageInbox.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDoctor
            // 
            this.tabControlDoctor.Controls.Add(this.tabPageOverview);
            this.tabControlDoctor.Controls.Add(this.tabPagePatients);
            this.tabControlDoctor.Controls.Add(this.tabPageInbox);
            this.tabControlDoctor.Controls.Add(this.tabPageSchedule);
            this.tabControlDoctor.Location = new System.Drawing.Point(12, 12);
            this.tabControlDoctor.Name = "tabControlDoctor";
            this.tabControlDoctor.SelectedIndex = 0;
            this.tabControlDoctor.Size = new System.Drawing.Size(776, 426);
            this.tabControlDoctor.TabIndex = 0;
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.groupBoxNotificationsOverview);
            this.tabPageOverview.Controls.Add(this.groupBoxToday);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 22);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverview.Size = new System.Drawing.Size(768, 400);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
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
            this.listViewNotificationsOverview.DoubleClick += new System.EventHandler(this.NotificationsOverview_DoubleClick);
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
            // groupBoxToday
            // 
            this.groupBoxToday.Controls.Add(this.listViewTodayAppointments);
            this.groupBoxToday.Location = new System.Drawing.Point(7, 6);
            this.groupBoxToday.Name = "groupBoxToday";
            this.groupBoxToday.Size = new System.Drawing.Size(521, 388);
            this.groupBoxToday.TabIndex = 0;
            this.groupBoxToday.TabStop = false;
            this.groupBoxToday.Text = "Today\'s Schedule";
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
            this.listViewTodayAppointments.Size = new System.Drawing.Size(508, 362);
            this.listViewTodayAppointments.TabIndex = 0;
            this.listViewTodayAppointments.UseCompatibleStateImageBehavior = false;
            this.listViewTodayAppointments.View = System.Windows.Forms.View.Details;
            this.listViewTodayAppointments.DoubleClick += new System.EventHandler(this.ListViewTodayAppointments_DoubleClick);
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
            // tabPagePatients
            // 
            this.tabPagePatients.Controls.Add(this.groupBox1);
            this.tabPagePatients.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatients.Name = "tabPagePatients";
            this.tabPagePatients.Size = new System.Drawing.Size(768, 400);
            this.tabPagePatients.TabIndex = 3;
            this.tabPagePatients.Text = "Patients";
            this.tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewPatients);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient List";
            // 
            // listViewPatients
            // 
            this.listViewPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewPatients.FullRowSelect = true;
            this.listViewPatients.HideSelection = false;
            this.listViewPatients.Location = new System.Drawing.Point(7, 20);
            this.listViewPatients.MultiSelect = false;
            this.listViewPatients.Name = "listViewPatients";
            this.listViewPatients.Size = new System.Drawing.Size(748, 373);
            this.listViewPatients.TabIndex = 0;
            this.listViewPatients.UseCompatibleStateImageBehavior = false;
            this.listViewPatients.View = System.Windows.Forms.View.Details;
            this.listViewPatients.DoubleClick += new System.EventHandler(this.ListViewPatients_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 163;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Age";
            this.columnHeader8.Width = 83;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Gender";
            this.columnHeader9.Width = 139;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Phone";
            this.columnHeader10.Width = 273;
            // 
            // tabPageInbox
            // 
            this.tabPageInbox.Controls.Add(this.listViewInbox);
            this.tabPageInbox.Controls.Add(this.buttonNewMessage);
            this.tabPageInbox.Location = new System.Drawing.Point(4, 22);
            this.tabPageInbox.Name = "tabPageInbox";
            this.tabPageInbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInbox.Size = new System.Drawing.Size(768, 400);
            this.tabPageInbox.TabIndex = 1;
            this.tabPageInbox.Text = "Inbox";
            this.tabPageInbox.UseVisualStyleBackColor = true;
            // 
            // listViewInbox
            // 
            this.listViewInbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewInbox.FullRowSelect = true;
            this.listViewInbox.HideSelection = false;
            this.listViewInbox.Location = new System.Drawing.Point(6, 35);
            this.listViewInbox.MultiSelect = false;
            this.listViewInbox.Name = "listViewInbox";
            this.listViewInbox.Size = new System.Drawing.Size(756, 359);
            this.listViewInbox.TabIndex = 1;
            this.listViewInbox.UseCompatibleStateImageBehavior = false;
            this.listViewInbox.View = System.Windows.Forms.View.Details;
            this.listViewInbox.DoubleClick += new System.EventHandler(this.ListViewInbox_DoubleClick);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Date";
            this.columnHeader11.Width = 141;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "From";
            this.columnHeader12.Width = 174;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Subject";
            this.columnHeader13.Width = 433;
            // 
            // buttonNewMessage
            // 
            this.buttonNewMessage.Location = new System.Drawing.Point(653, 6);
            this.buttonNewMessage.Name = "buttonNewMessage";
            this.buttonNewMessage.Size = new System.Drawing.Size(83, 23);
            this.buttonNewMessage.TabIndex = 0;
            this.buttonNewMessage.Text = "New Message";
            this.buttonNewMessage.UseVisualStyleBackColor = true;
            this.buttonNewMessage.Click += new System.EventHandler(this.ButtonNewMessage_Click);
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.buttonCancelAppointment);
            this.tabPageSchedule.Controls.Add(this.buttonEditAppointment);
            this.tabPageSchedule.Controls.Add(this.listViewSchedule);
            this.tabPageSchedule.Controls.Add(this.listView1);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Size = new System.Drawing.Size(768, 400);
            this.tabPageSchedule.TabIndex = 2;
            this.tabPageSchedule.Text = "Schedule";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.Location = new System.Drawing.Point(653, 370);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAppointment.TabIndex = 3;
            this.buttonCancelAppointment.Text = "Cancel Appt";
            this.buttonCancelAppointment.UseVisualStyleBackColor = true;
            this.buttonCancelAppointment.Click += new System.EventHandler(this.ButtonCancelAppointment_Click);
            // 
            // buttonEditAppointment
            // 
            this.buttonEditAppointment.Location = new System.Drawing.Point(559, 370);
            this.buttonEditAppointment.Name = "buttonEditAppointment";
            this.buttonEditAppointment.Size = new System.Drawing.Size(88, 23);
            this.buttonEditAppointment.TabIndex = 2;
            this.buttonEditAppointment.Text = "Edit Appt";
            this.buttonEditAppointment.UseVisualStyleBackColor = true;
            this.buttonEditAppointment.Click += new System.EventHandler(this.ButtonEditAppointment_Click);
            // 
            // listViewSchedule
            // 
            this.listViewSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.Description});
            this.listViewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.listViewSchedule.FullRowSelect = true;
            this.listViewSchedule.HideSelection = false;
            this.listViewSchedule.Location = new System.Drawing.Point(4, 4);
            this.listViewSchedule.MultiSelect = false;
            this.listViewSchedule.Name = "listViewSchedule";
            this.listViewSchedule.Size = new System.Drawing.Size(761, 360);
            this.listViewSchedule.TabIndex = 1;
            this.listViewSchedule.UseCompatibleStateImageBehavior = false;
            this.listViewSchedule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Date";
            this.columnHeader14.Width = 152;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Time";
            this.columnHeader15.Width = 113;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Patient";
            this.columnHeader16.Width = 170;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 322;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(761, 360);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(669, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // DashboardDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControlDoctor);
            this.Name = "DashboardDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Dashboard";
            this.tabControlDoctor.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            this.groupBoxNotificationsOverview.ResumeLayout(false);
            this.groupBoxToday.ResumeLayout(false);
            this.tabPagePatients.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPageInbox.ResumeLayout(false);
            this.tabPageSchedule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDoctor;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.TabPage tabPageInbox;
        private System.Windows.Forms.TabPage tabPagePatients;
        private System.Windows.Forms.TabPage tabPageSchedule;
        private System.Windows.Forms.GroupBox groupBoxToday;
        private System.Windows.Forms.GroupBox groupBoxNotificationsOverview;
        private System.Windows.Forms.ListView listViewTodayAppointments;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Patients;
        private System.Windows.Forms.ListView listViewNotificationsOverview;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewPatients;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonNewMessage;
        private System.Windows.Forms.ListView listViewInbox;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonEditAppointment;
        private System.Windows.Forms.ListView listViewSchedule;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button buttonCancelAppointment;
        private System.Windows.Forms.ColumnHeader Description;
    }
}