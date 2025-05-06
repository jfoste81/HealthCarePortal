namespace HealthCarePortal.Forms
{
    partial class DashboardPatientForm
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
            this.tabControlDashboard = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.listViewNotifications = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelOverviewNotifications = new System.Windows.Forms.Label();
            this.labelOverviewAppointments = new System.Windows.Forms.Label();
            this.listViewOverviewAppointments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPageInbox = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageAppointments = new System.Windows.Forms.TabPage();
            this.buttonCancelAppt = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.listViewAppointments = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageMedicalHistory = new System.Windows.Forms.TabPage();
            this.groupBoxPrescriptions = new System.Windows.Forms.GroupBox();
            this.listViewPrescriptions = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxIllnesses = new System.Windows.Forms.GroupBox();
            this.listViewIllnesses = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlDashboard.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            this.tabPageInbox.SuspendLayout();
            this.tabPageAppointments.SuspendLayout();
            this.tabPageMedicalHistory.SuspendLayout();
            this.groupBoxPrescriptions.SuspendLayout();
            this.groupBoxIllnesses.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDashboard
            // 
            this.tabControlDashboard.Controls.Add(this.tabPageOverview);
            this.tabControlDashboard.Controls.Add(this.tabPageInbox);
            this.tabControlDashboard.Controls.Add(this.tabPageAppointments);
            this.tabControlDashboard.Controls.Add(this.tabPageMedicalHistory);
            this.tabControlDashboard.Location = new System.Drawing.Point(12, 12);
            this.tabControlDashboard.Name = "tabControlDashboard";
            this.tabControlDashboard.SelectedIndex = 0;
            this.tabControlDashboard.Size = new System.Drawing.Size(776, 426);
            this.tabControlDashboard.TabIndex = 0;
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.listViewNotifications);
            this.tabPageOverview.Controls.Add(this.labelOverviewNotifications);
            this.tabPageOverview.Controls.Add(this.labelOverviewAppointments);
            this.tabPageOverview.Controls.Add(this.listViewOverviewAppointments);
            this.tabPageOverview.Controls.Add(this.menuStrip1);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 22);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverview.Size = new System.Drawing.Size(768, 400);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // listViewNotifications
            // 
            this.listViewNotifications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listViewNotifications.FullRowSelect = true;
            this.listViewNotifications.HideSelection = false;
            this.listViewNotifications.Location = new System.Drawing.Point(554, 31);
            this.listViewNotifications.MultiSelect = false;
            this.listViewNotifications.Name = "listViewNotifications";
            this.listViewNotifications.Size = new System.Drawing.Size(208, 350);
            this.listViewNotifications.TabIndex = 5;
            this.listViewNotifications.UseCompatibleStateImageBehavior = false;
            this.listViewNotifications.View = System.Windows.Forms.View.Details;
            this.listViewNotifications.DoubleClick += new System.EventHandler(this.ListViewNotifications_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date/Time";
            this.columnHeader6.Width = 118;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Type";
            this.columnHeader7.Width = 140;
            // 
            // labelOverviewNotifications
            // 
            this.labelOverviewNotifications.AutoSize = true;
            this.labelOverviewNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelOverviewNotifications.Location = new System.Drawing.Point(549, 7);
            this.labelOverviewNotifications.Name = "labelOverviewNotifications";
            this.labelOverviewNotifications.Size = new System.Drawing.Size(96, 20);
            this.labelOverviewNotifications.TabIndex = 4;
            this.labelOverviewNotifications.Text = "Notifications";
            // 
            // labelOverviewAppointments
            // 
            this.labelOverviewAppointments.AutoSize = true;
            this.labelOverviewAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelOverviewAppointments.Location = new System.Drawing.Point(6, 7);
            this.labelOverviewAppointments.Name = "labelOverviewAppointments";
            this.labelOverviewAppointments.Size = new System.Drawing.Size(184, 20);
            this.labelOverviewAppointments.TabIndex = 3;
            this.labelOverviewAppointments.Text = "Upcoming Appointments";
            // 
            // listViewOverviewAppointments
            // 
            this.listViewOverviewAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewOverviewAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listViewOverviewAppointments.FullRowSelect = true;
            this.listViewOverviewAppointments.HideSelection = false;
            this.listViewOverviewAppointments.Location = new System.Drawing.Point(7, 30);
            this.listViewOverviewAppointments.MultiSelect = false;
            this.listViewOverviewAppointments.Name = "listViewOverviewAppointments";
            this.listViewOverviewAppointments.Size = new System.Drawing.Size(540, 351);
            this.listViewOverviewAppointments.TabIndex = 2;
            this.listViewOverviewAppointments.UseCompatibleStateImageBehavior = false;
            this.listViewOverviewAppointments.View = System.Windows.Forms.View.Details;
            this.listViewOverviewAppointments.DoubleClick += new System.EventHandler(this.ListViewOverviewAppointments_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date/Time";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doctor";
            this.columnHeader2.Width = 410;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPageInbox
            // 
            this.tabPageInbox.Controls.Add(this.button2);
            this.tabPageInbox.Controls.Add(this.listViewMessages);
            this.tabPageInbox.Location = new System.Drawing.Point(4, 22);
            this.tabPageInbox.Name = "tabPageInbox";
            this.tabPageInbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInbox.Size = new System.Drawing.Size(768, 400);
            this.tabPageInbox.TabIndex = 1;
            this.tabPageInbox.Text = "Inbox";
            this.tabPageInbox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "New Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNewMessage_Click);
            // 
            // listViewMessages
            // 
            this.listViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewMessages.FullRowSelect = true;
            this.listViewMessages.HideSelection = false;
            this.listViewMessages.Location = new System.Drawing.Point(6, 36);
            this.listViewMessages.MultiSelect = false;
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(756, 330);
            this.listViewMessages.TabIndex = 0;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.Details;
            this.listViewMessages.DoubleClick += new System.EventHandler(this.ListViewMessages_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 233;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "From";
            this.columnHeader4.Width = 162;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Subject";
            this.columnHeader5.Width = 579;
            // 
            // tabPageAppointments
            // 
            this.tabPageAppointments.Controls.Add(this.buttonCancelAppt);
            this.tabPageAppointments.Controls.Add(this.buttonSchedule);
            this.tabPageAppointments.Controls.Add(this.listViewAppointments);
            this.tabPageAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppointments.Name = "tabPageAppointments";
            this.tabPageAppointments.Size = new System.Drawing.Size(768, 400);
            this.tabPageAppointments.TabIndex = 2;
            this.tabPageAppointments.Text = "Appointments";
            this.tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // buttonCancelAppt
            // 
            this.buttonCancelAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonCancelAppt.Location = new System.Drawing.Point(690, 367);
            this.buttonCancelAppt.Name = "buttonCancelAppt";
            this.buttonCancelAppt.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAppt.TabIndex = 2;
            this.buttonCancelAppt.Text = "Cancel Appt";
            this.buttonCancelAppt.UseVisualStyleBackColor = true;
            this.buttonCancelAppt.Click += new System.EventHandler(this.ButtonCancelAppt_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(609, 367);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(75, 23);
            this.buttonSchedule.TabIndex = 1;
            this.buttonSchedule.Text = "New Appt";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // listViewAppointments
            // 
            this.listViewAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.Description});
            this.listViewAppointments.FullRowSelect = true;
            this.listViewAppointments.HideSelection = false;
            this.listViewAppointments.Location = new System.Drawing.Point(3, 3);
            this.listViewAppointments.MultiSelect = false;
            this.listViewAppointments.Name = "listViewAppointments";
            this.listViewAppointments.Size = new System.Drawing.Size(762, 359);
            this.listViewAppointments.TabIndex = 0;
            this.listViewAppointments.UseCompatibleStateImageBehavior = false;
            this.listViewAppointments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date";
            this.columnHeader8.Width = 239;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Doctor";
            this.columnHeader9.Width = 182;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 335;
            // 
            // tabPageMedicalHistory
            // 
            this.tabPageMedicalHistory.Controls.Add(this.groupBoxPrescriptions);
            this.tabPageMedicalHistory.Controls.Add(this.groupBoxIllnesses);
            this.tabPageMedicalHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedicalHistory.Name = "tabPageMedicalHistory";
            this.tabPageMedicalHistory.Size = new System.Drawing.Size(768, 400);
            this.tabPageMedicalHistory.TabIndex = 3;
            this.tabPageMedicalHistory.Text = "Medical History";
            this.tabPageMedicalHistory.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrescriptions
            // 
            this.groupBoxPrescriptions.Controls.Add(this.listViewPrescriptions);
            this.groupBoxPrescriptions.Location = new System.Drawing.Point(389, 13);
            this.groupBoxPrescriptions.Name = "groupBoxPrescriptions";
            this.groupBoxPrescriptions.Size = new System.Drawing.Size(376, 384);
            this.groupBoxPrescriptions.TabIndex = 1;
            this.groupBoxPrescriptions.TabStop = false;
            this.groupBoxPrescriptions.Text = "Prescriptions";
            // 
            // listViewPrescriptions
            // 
            this.listViewPrescriptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listViewPrescriptions.FullRowSelect = true;
            this.listViewPrescriptions.HideSelection = false;
            this.listViewPrescriptions.Location = new System.Drawing.Point(7, 20);
            this.listViewPrescriptions.MultiSelect = false;
            this.listViewPrescriptions.Name = "listViewPrescriptions";
            this.listViewPrescriptions.Size = new System.Drawing.Size(363, 358);
            this.listViewPrescriptions.TabIndex = 0;
            this.listViewPrescriptions.UseCompatibleStateImageBehavior = false;
            this.listViewPrescriptions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Medication";
            this.columnHeader12.Width = 93;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Dosage";
            this.columnHeader13.Width = 102;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Notes";
            this.columnHeader14.Width = 172;
            // 
            // groupBoxIllnesses
            // 
            this.groupBoxIllnesses.Controls.Add(this.listViewIllnesses);
            this.groupBoxIllnesses.Location = new System.Drawing.Point(24, 13);
            this.groupBoxIllnesses.Name = "groupBoxIllnesses";
            this.groupBoxIllnesses.Size = new System.Drawing.Size(359, 384);
            this.groupBoxIllnesses.TabIndex = 0;
            this.groupBoxIllnesses.TabStop = false;
            this.groupBoxIllnesses.Text = "Illnesses";
            // 
            // listViewIllnesses
            // 
            this.listViewIllnesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.listViewIllnesses.FullRowSelect = true;
            this.listViewIllnesses.HideSelection = false;
            this.listViewIllnesses.Location = new System.Drawing.Point(7, 20);
            this.listViewIllnesses.MultiSelect = false;
            this.listViewIllnesses.Name = "listViewIllnesses";
            this.listViewIllnesses.Size = new System.Drawing.Size(346, 358);
            this.listViewIllnesses.TabIndex = 0;
            this.listViewIllnesses.UseCompatibleStateImageBehavior = false;
            this.listViewIllnesses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Date Contracted";
            this.columnHeader10.Width = 152;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Name";
            this.columnHeader11.Width = 249;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(670, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // DashboardPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControlDashboard);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardPatientForm";
            this.tabControlDashboard.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            this.tabPageOverview.PerformLayout();
            this.tabPageInbox.ResumeLayout(false);
            this.tabPageAppointments.ResumeLayout(false);
            this.tabPageMedicalHistory.ResumeLayout(false);
            this.groupBoxPrescriptions.ResumeLayout(false);
            this.groupBoxIllnesses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDashboard;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.TabPage tabPageInbox;
        private System.Windows.Forms.TabPage tabPageAppointments;
        private System.Windows.Forms.TabPage tabPageMedicalHistory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewOverviewAppointments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelOverviewNotifications;
        private System.Windows.Forms.Label labelOverviewAppointments;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listViewNotifications;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.ListView listViewAppointments;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBoxIllnesses;
        private System.Windows.Forms.ListView listViewIllnesses;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox groupBoxPrescriptions;
        private System.Windows.Forms.ListView listViewPrescriptions;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button buttonCancelAppt;
        private System.Windows.Forms.ColumnHeader Description;
    }
}