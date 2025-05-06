using HealthCarePortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthCarePortal.Forms
{
    public partial class MessageForm : Form
    {
        private readonly User _sender;
        private readonly User _fixedRecipient;

        public MessageForm(User sender, User recipient = null, string subject = "")
        {
            InitializeComponent();
            _sender = sender;
            _fixedRecipient = recipient;

            // populate the "To" dropdown
            if (_fixedRecipient != null)
            {
                comboBoxTo.Items.Add(_fixedRecipient.Username);
                comboBoxTo.SelectedIndex = 0;
                comboBoxTo.Enabled = false;
            }
            else
            {
                // if sender is a patient, list doctors -> if doctor, vice versa
                var choices = sender is Patient
                ? Portal.Instance.Doctors.Select(d => d.Username)
                    : Portal.Instance.Patients.Select(p => p.Username);

                comboBoxTo.Items.AddRange(choices.ToArray());
            }

            // prefill subject for replies
            textBoxSubject.Text = subject;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string toUser = comboBoxTo.SelectedItem?.ToString() ?? "";
            string subj = textBoxSubject.Text.Trim();
            string body = textBoxBody.Text.Trim();

            if (string.IsNullOrEmpty(toUser)
             || string.IsNullOrEmpty(subj)
             || string.IsNullOrEmpty(body))
            {
                MessageBox.Show(
                  "Please select a recipient, and fill in subject and body.",
                  "Missing Information",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                );
                return;
            }

            // find the recipient object
            var recipient = (User)Portal.Instance.Doctors
                                .FirstOrDefault(d => d.Username == toUser)
                          ?? Portal.Instance.Patients
                                .FirstOrDefault(p => p.Username == toUser);

            if (recipient == null)
            {
                MessageBox.Show(
                  "Could not find the recipient user.",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
                return;
            }

            // create & deliver the message
            var msg = new UserMessage(_sender.Username, subj, body);
            recipient.Inbox.Add(msg);
            recipient.Notifications.Add(new Notification("Message"));

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
