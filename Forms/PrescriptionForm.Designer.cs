namespace HealthCarePortal.Forms
{
    partial class PrescriptionForm
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
            this.labelMedName = new System.Windows.Forms.Label();
            this.textBoxMedName = new System.Windows.Forms.TextBox();
            this.labelDosage = new System.Windows.Forms.Label();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMedName
            // 
            this.labelMedName.AutoSize = true;
            this.labelMedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMedName.Location = new System.Drawing.Point(31, 31);
            this.labelMedName.Name = "labelMedName";
            this.labelMedName.Size = new System.Drawing.Size(90, 20);
            this.labelMedName.TabIndex = 0;
            this.labelMedName.Text = "Medication:";
            // 
            // textBoxMedName
            // 
            this.textBoxMedName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxMedName.Location = new System.Drawing.Point(127, 27);
            this.textBoxMedName.Name = "textBoxMedName";
            this.textBoxMedName.Size = new System.Drawing.Size(100, 24);
            this.textBoxMedName.TabIndex = 1;
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDosage.Location = new System.Drawing.Point(279, 31);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(69, 20);
            this.labelDosage.TabIndex = 2;
            this.labelDosage.Text = "Dosage:";
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxDosage.Location = new System.Drawing.Point(354, 29);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(100, 24);
            this.textBoxDosage.TabIndex = 3;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNotes.Location = new System.Drawing.Point(31, 72);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(55, 20);
            this.labelNotes.TabIndex = 4;
            this.labelNotes.Text = "Notes:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(35, 105);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(419, 213);
            this.textBoxNotes.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(283, 362);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancel.Location = new System.Drawing.Point(379, 362);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 425);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.textBoxMedName);
            this.Controls.Add(this.labelMedName);
            this.Name = "PrescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrescriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMedName;
        private System.Windows.Forms.TextBox textBoxMedName;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}