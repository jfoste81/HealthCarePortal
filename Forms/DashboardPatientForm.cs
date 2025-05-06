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

namespace HealthCarePortal.Forms
{
    public partial class DashboardPatientForm : Form
    {
        private readonly Patient _patient;
        private List<UserMessage> _displayedMessages;

        public DashboardPatientForm(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            Text = $"Welcome, {_patient.Name}";

            // populate each tab
            LoadOverview();
            LoadMessages();
            LoadAppointments();
            LoadMedicalHistory();
        }

        private void LoadOverview()
        {
            // show next 5 appointments
            listViewOverviewAppointments.Items.Clear();
            foreach (var appt in _patient.Appointments
                                        .OrderBy(a => a.Timestamp)
                                        .Take(5))
            {
                var item = new ListViewItem(appt.Timestamp.ToString("g"));
                item.SubItems.Add(appt.DoctorName);
                listViewOverviewAppointments.Items.Add(item);
            }

            // notifications
            listViewNotifications.Items.Clear();
            foreach (var n in _patient.Notifications.OrderByDescending(nf => nf.Timestamp))
            {
                var item = new ListViewItem(n.Timestamp.ToString("g"));
                item.SubItems.Add(n.Type);
                listViewNotifications.Items.Add(item);
            }
        }

        private void LoadMessages()
        {
            // sort descending 
            _displayedMessages = _patient.Inbox
                                         .OrderByDescending(m => m.Timestamp)
                                         .ToList();

            listViewMessages.Items.Clear();
            foreach (var msg in _displayedMessages)
            {
                var item = new ListViewItem(msg.Timestamp.ToString("g"));
                item.SubItems.Add(msg.Author);
                item.SubItems.Add(msg.Subject);
                listViewMessages.Items.Add(item);
            }
        }

        private void LoadAppointments()
        {
            listViewAppointments.Items.Clear();
            foreach (var appt in _patient.Appointments)
            {
                var item = new ListViewItem(appt.Timestamp.ToString("g"));
                item.SubItems.Add(appt.DoctorName);
                item.SubItems.Add(appt.Description);
                listViewAppointments.Items.Add(item);
            }
        }

        private void LoadMedicalHistory()
        {
            // Illness History
            listViewIllnesses.Items.Clear();
            foreach (var ill in _patient.MedicalHistory
                                         .OrderBy(i => i.DateContracted))
            {
                var item = new ListViewItem(ill.DateContracted.ToShortDateString());
                item.SubItems.Add(ill.Name);
                listViewIllnesses.Items.Add(item);
            }

            // Prescriptions
            listViewPrescriptions.Items.Clear();
            foreach (var rx in _patient.Prescriptions)
            {
                var item = new ListViewItem(rx.Name);
                item.SubItems.Add(rx.Dosage);
                item.SubItems.Add(rx.Description);
                listViewPrescriptions.Items.Add(item);
            }
        }

        private void ListViewOverviewAppointments_DoubleClick(object sender, EventArgs e)
        {
            tabControlDashboard.SelectedTab = tabPageAppointments;
        }

        private void ListViewNotifications_DoubleClick(object sender, EventArgs e)
        {
            if (listViewNotifications.SelectedIndices.Count == 0) return;

            int idx = listViewNotifications.SelectedIndices[0];
            var notif = _patient.Notifications
                         .OrderByDescending(n => n.Timestamp)
                         .ElementAt(idx);

            switch (notif.Type)
            {
                case "Message":
                    tabControlDashboard.SelectedTab = tabPageInbox;
                    break;
                case "Appointment":
                    tabControlDashboard.SelectedTab = tabPageAppointments;
                    break;
                case "MedHistory":
                    tabControlDashboard.SelectedTab = tabPageMedicalHistory;
                    break;
                case "Prescription":
                    tabControlDashboard.SelectedTab = tabPageMedicalHistory;
                    break;
            }
        }

        private void buttonNewMessage_Click(object sender, EventArgs e)
        {
            var form = new MessageForm(_patient, /* recipient */ null);
            if (form.ShowDialog() == DialogResult.OK)
                LoadMessages();
        }

        private void ListViewMessages_DoubleClick(object sender, EventArgs e)
        {
            if (listViewMessages.SelectedIndices.Count == 0) return;

            int idx = listViewMessages.SelectedIndices[0];
            var msg = _displayedMessages[idx];

            using var detail = new MessageDetailForm(_patient, msg);
            detail.ShowDialog();
            LoadMessages();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            var form = new AppointmentForm(_patient);
            if (form.ShowDialog() == DialogResult.OK)
                LoadAppointments();
        }

        private void ButtonCancelAppt_Click(object sender, EventArgs e)
        {
            if (listViewAppointments.SelectedIndices.Count == 0) return;

            int idx = listViewAppointments.SelectedIndices[0];
            var appt = _patient.Appointments
                               .OrderBy(a => a.Timestamp)
                               .ElementAt(idx);

            // comnfirm with user
            var result = MessageBox.Show(
                $"Cancel your appointment on {appt.Timestamp:g} with Dr. {appt.DoctorName}?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result != DialogResult.Yes) return;

            // remove from patient
            _patient.Appointments.Remove(appt);

            // remove from doctor’s schedule
            var doctor = Portal.Instance.Doctors
                             .FirstOrDefault(d => d.Name == appt.DoctorName);
            if (doctor != null)
                doctor.Appointments.RemoveAll(a => a.Id == appt.Id);

            // add notifications
            _patient.Notifications.Add(new Notification("Appointment"));
            if (doctor != null)
                doctor.Notifications.Add(new Notification("Appointment"));

            // refresh UI
            LoadAppointments();
            LoadOverview();
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Close();
            new LoginForm().Show();
        }

        protected override void OnActivated(EventArgs e)
        {
            // reload overview when form goes back into focus
            base.OnActivated(e);
            LoadOverview();
        }
    }
}
