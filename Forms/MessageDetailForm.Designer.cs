namespace HealthCarePortal.Forms
{
    partial class MessageDetailForm
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
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelBody = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.buttonReply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFrom.Location = new System.Drawing.Point(25, 36);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(50, 20);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDate.Location = new System.Drawing.Point(478, 36);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(48, 20);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSubject.Location = new System.Drawing.Point(25, 74);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(71, 20);
            this.labelSubject.TabIndex = 2;
            this.labelSubject.Text = "Subject: ";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSubject.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSubject.Location = new System.Drawing.Point(102, 74);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.ReadOnly = true;
            this.textBoxSubject.Size = new System.Drawing.Size(662, 19);
            this.textBoxSubject.TabIndex = 3;
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBody.Location = new System.Drawing.Point(29, 119);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(78, 20);
            this.labelBody.TabIndex = 4;
            this.labelBody.Text = "Message:";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxBody.Location = new System.Drawing.Point(33, 143);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.ReadOnly = true;
            this.textBoxBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBody.Size = new System.Drawing.Size(731, 249);
            this.textBoxBody.TabIndex = 5;
            // 
            // buttonReply
            // 
            this.buttonReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonReply.Location = new System.Drawing.Point(680, 401);
            this.buttonReply.Name = "buttonReply";
            this.buttonReply.Size = new System.Drawing.Size(70, 37);
            this.buttonReply.TabIndex = 6;
            this.buttonReply.Text = "Reply";
            this.buttonReply.UseVisualStyleBackColor = true;
            this.buttonReply.Click += new System.EventHandler(this.buttonReply_Click);
            // 
            // MessageDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReply);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelFrom);
            this.Name = "MessageDetailForm";
            this.Text = "MessageDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Button buttonReply;
    }
}