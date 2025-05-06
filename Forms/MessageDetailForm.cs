using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCarePortal.Models;

namespace HealthCarePortal.Forms
{
    public partial class MessageDetailForm : Form
    {
        private readonly User _currentUser;
        private readonly UserMessage _message;

        public MessageDetailForm(User currentUser, UserMessage message)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _message = message;

            // populate UI
            labelFrom.Text = $"From: {_message.Author}";
            labelDate.Text = $"Date: {_message.Timestamp:g}";
            textBoxSubject.Text = _message.Subject;
            textBoxBody.Text = _message.Body;
        }

        private void buttonReply_Click(object sender, EventArgs e)
        {
            // look up the original sender as a User
            var recipient = (User)Portal.Instance.Doctors
                                .FirstOrDefault(d => d.Username == _message.Author)
                          ?? Portal.Instance.Patients
                                .FirstOrDefault(p => p.Username == _message.Author);

            if (recipient == null)
            {
                MessageBox.Show(
                  "Could not find the original sender.",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
                return;
            }

            // prefill subject
            string replySubject = "Re: " + _message.Subject;

            // open MessageForm for reply
            using var compose = new MessageForm(
                sender: _currentUser,
                recipient: recipient,
                subject: replySubject
            );

            if (compose.ShowDialog() == DialogResult.OK)
            {
                // if the user sent the message, close this form
                Close();
            }   
        }
    }
}
