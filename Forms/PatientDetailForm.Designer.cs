namespace HealthCarePortal.Forms
{
    partial class PatientDetailForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAgeGender = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxHistory = new System.Windows.Forms.GroupBox();
            this.buttonRemovePrescription = new System.Windows.Forms.Button();
            this.buttonEditPrescription = new System.Windows.Forms.Button();
            this.buttonNewPrescription = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveDiagnosis = new System.Windows.Forms.Button();
            this.buttonEditDiagnosis = new System.Windows.Forms.Button();
            this.buttonNewDiagnosis = new System.Windows.Forms.Button();
            this.listViewPrescriptions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelIllness = new System.Windows.Forms.Label();
            this.listViewIllness = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diagnosis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelName.Location = new System.Drawing.Point(35, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name: { }";
            // 
            // labelAgeGender
            // 
            this.labelAgeGender.AutoSize = true;
            this.labelAgeGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAgeGender.Location = new System.Drawing.Point(263, 32);
            this.labelAgeGender.Name = "labelAgeGender";
            this.labelAgeGender.Size = new System.Drawing.Size(118, 20);
            this.labelAgeGender.TabIndex = 1;
            this.labelAgeGender.Text = "Age/Gender: { }";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPhone.Location = new System.Drawing.Point(555, 32);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(77, 20);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone: { }";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmail.Location = new System.Drawing.Point(35, 64);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(70, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email: { }";
            // 
            // groupBoxHistory
            // 
            this.groupBoxHistory.Controls.Add(this.buttonRemovePrescription);
            this.groupBoxHistory.Controls.Add(this.buttonEditPrescription);
            this.groupBoxHistory.Controls.Add(this.buttonNewPrescription);
            this.groupBoxHistory.Controls.Add(this.label1);
            this.groupBoxHistory.Controls.Add(this.buttonRemoveDiagnosis);
            this.groupBoxHistory.Controls.Add(this.buttonEditDiagnosis);
            this.groupBoxHistory.Controls.Add(this.buttonNewDiagnosis);
            this.groupBoxHistory.Controls.Add(this.listViewPrescriptions);
            this.groupBoxHistory.Controls.Add(this.labelIllness);
            this.groupBoxHistory.Controls.Add(this.listViewIllness);
            this.groupBoxHistory.Location = new System.Drawing.Point(39, 87);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Size = new System.Drawing.Size(749, 327);
            this.groupBoxHistory.TabIndex = 4;
            this.groupBoxHistory.TabStop = false;
            this.groupBoxHistory.Text = "Medical History";
            // 
            // buttonRemovePrescription
            // 
            this.buttonRemovePrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonRemovePrescription.Location = new System.Drawing.Point(567, 296);
            this.buttonRemovePrescription.Name = "buttonRemovePrescription";
            this.buttonRemovePrescription.Size = new System.Drawing.Size(75, 23);
            this.buttonRemovePrescription.TabIndex = 9;
            this.buttonRemovePrescription.Text = "Remove";
            this.buttonRemovePrescription.UseVisualStyleBackColor = true;
            this.buttonRemovePrescription.Click += new System.EventHandler(this.buttonRemovePrescription_Click);
            // 
            // buttonEditPrescription
            // 
            this.buttonEditPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonEditPrescription.Location = new System.Drawing.Point(468, 296);
            this.buttonEditPrescription.Name = "buttonEditPrescription";
            this.buttonEditPrescription.Size = new System.Drawing.Size(75, 23);
            this.buttonEditPrescription.TabIndex = 8;
            this.buttonEditPrescription.Text = "Edit";
            this.buttonEditPrescription.UseVisualStyleBackColor = true;
            this.buttonEditPrescription.Click += new System.EventHandler(this.buttonEditPrescription_Click);
            // 
            // buttonNewPrescription
            // 
            this.buttonNewPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonNewPrescription.Location = new System.Drawing.Point(368, 296);
            this.buttonNewPrescription.Name = "buttonNewPrescription";
            this.buttonNewPrescription.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPrescription.TabIndex = 7;
            this.buttonNewPrescription.Text = "New";
            this.buttonNewPrescription.UseVisualStyleBackColor = true;
            this.buttonNewPrescription.Click += new System.EventHandler(this.buttonNewPrescription_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(303, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prescriptions:";
            // 
            // buttonRemoveDiagnosis
            // 
            this.buttonRemoveDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonRemoveDiagnosis.Location = new System.Drawing.Point(195, 296);
            this.buttonRemoveDiagnosis.Name = "buttonRemoveDiagnosis";
            this.buttonRemoveDiagnosis.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveDiagnosis.TabIndex = 5;
            this.buttonRemoveDiagnosis.Text = "Remove";
            this.buttonRemoveDiagnosis.UseVisualStyleBackColor = true;
            this.buttonRemoveDiagnosis.Click += new System.EventHandler(this.buttonRemoveDiagnosis_Click);
            // 
            // buttonEditDiagnosis
            // 
            this.buttonEditDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonEditDiagnosis.Location = new System.Drawing.Point(112, 296);
            this.buttonEditDiagnosis.Name = "buttonEditDiagnosis";
            this.buttonEditDiagnosis.Size = new System.Drawing.Size(61, 23);
            this.buttonEditDiagnosis.TabIndex = 4;
            this.buttonEditDiagnosis.Text = "Edit";
            this.buttonEditDiagnosis.UseVisualStyleBackColor = true;
            this.buttonEditDiagnosis.Click += new System.EventHandler(this.buttonEditDiagnosis_Click);
            // 
            // buttonNewDiagnosis
            // 
            this.buttonNewDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonNewDiagnosis.Location = new System.Drawing.Point(27, 296);
            this.buttonNewDiagnosis.Name = "buttonNewDiagnosis";
            this.buttonNewDiagnosis.Size = new System.Drawing.Size(64, 23);
            this.buttonNewDiagnosis.TabIndex = 3;
            this.buttonNewDiagnosis.Text = "New";
            this.buttonNewDiagnosis.UseVisualStyleBackColor = true;
            this.buttonNewDiagnosis.Click += new System.EventHandler(this.buttonNewDiagnosis_Click);
            // 
            // listViewPrescriptions
            // 
            this.listViewPrescriptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listViewPrescriptions.FullRowSelect = true;
            this.listViewPrescriptions.HideSelection = false;
            this.listViewPrescriptions.Location = new System.Drawing.Point(306, 36);
            this.listViewPrescriptions.MultiSelect = false;
            this.listViewPrescriptions.Name = "listViewPrescriptions";
            this.listViewPrescriptions.Size = new System.Drawing.Size(437, 253);
            this.listViewPrescriptions.TabIndex = 2;
            this.listViewPrescriptions.UseCompatibleStateImageBehavior = false;
            this.listViewPrescriptions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Medication";
            this.columnHeader1.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dosage";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Notes";
            this.columnHeader3.Width = 185;
            // 
            // labelIllness
            // 
            this.labelIllness.AutoSize = true;
            this.labelIllness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelIllness.Location = new System.Drawing.Point(6, 17);
            this.labelIllness.Name = "labelIllness";
            this.labelIllness.Size = new System.Drawing.Size(66, 17);
            this.labelIllness.TabIndex = 1;
            this.labelIllness.Text = "Illnesses:";
            // 
            // listViewIllness
            // 
            this.listViewIllness.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Diagnosis});
            this.listViewIllness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listViewIllness.FullRowSelect = true;
            this.listViewIllness.HideSelection = false;
            this.listViewIllness.Location = new System.Drawing.Point(6, 37);
            this.listViewIllness.MultiSelect = false;
            this.listViewIllness.Name = "listViewIllness";
            this.listViewIllness.Size = new System.Drawing.Size(277, 253);
            this.listViewIllness.TabIndex = 0;
            this.listViewIllness.UseCompatibleStateImageBehavior = false;
            this.listViewIllness.View = System.Windows.Forms.View.Details;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 116;
            // 
            // Diagnosis
            // 
            this.Diagnosis.Text = "Diagnosis";
            this.Diagnosis.Width = 157;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(713, 420);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // PatientDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxHistory);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAgeGender);
            this.Controls.Add(this.labelName);
            this.Name = "PatientDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient Details";
            this.groupBoxHistory.ResumeLayout(false);
            this.groupBoxHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAgeGender;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox groupBoxHistory;
        private System.Windows.Forms.ListView listViewIllness;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Diagnosis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemoveDiagnosis;
        private System.Windows.Forms.Button buttonEditDiagnosis;
        private System.Windows.Forms.Button buttonNewDiagnosis;
        private System.Windows.Forms.ListView listViewPrescriptions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelIllness;
        private System.Windows.Forms.Button buttonRemovePrescription;
        private System.Windows.Forms.Button buttonEditPrescription;
        private System.Windows.Forms.Button buttonNewPrescription;
        private System.Windows.Forms.Button buttonClose;
    }
}