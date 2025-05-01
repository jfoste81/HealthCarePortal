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

namespace HealthCarePortal
{
    public partial class DashboardPatientForm : Form
    {
        private readonly Patient _patient;

        public DashboardPatientForm(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            Text = $"Welcome, {_patient.Name}";

            // Populate each tab
            LoadOverview();
            LoadMessages();
            LoadAppointments();
            LoadMedicalHistory();
            LoadNotifications();
        }

        private void LoadOverview()
        {
            // e.g. show next 3 appointments
            listViewOverviewAppointments.Items.Clear();
            foreach (var appt in _patient.Appointments
                                        .OrderBy(a => a.Timestamp)
                                        .Take(3))
            {
                var item = new ListViewItem(appt.Timestamp.ToString("g"));
                item.SubItems.Add(appt.DoctorName);
                listViewOverviewAppointments.Items.Add(item);
            }

            // recent notifications
            listViewNotifications.Items.Clear();
            foreach (var n in _patient.Notifications
                                     .OrderByDescending(nf => nf.Timestamp)
                                     .Take(3))
            {
                var item = new ListViewItem(n.Timestamp.ToString("g"));
                item.SubItems.Add(n.Type);
                listViewNotifications.Items.Add(item);
            }
        }

        private void LoadMessages()
        {
            listViewMessages.Items.Clear();
            foreach (var msg in _patient.Inbox)
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

        private void LoadNotifications()
        {
            listViewNotifications.Items.Clear();
            foreach (var n in _patient.Notifications)
            {
                var item = new ListViewItem(n.Timestamp.ToString("g"));
                item.SubItems.Add(n.Type);
                item.SubItems.Add(n.Description);
                listViewNotifications.Items.Add(item);
            }
        }

        // Event handlers
        //private void buttonNewMessage_Click(object sender, EventArgs e)
        //{
        //    var form = new MessageForm(_patient, /* recipient */ null);
        //    if (form.ShowDialog() == DialogResult.OK)
        //        LoadMessages();
        //}

        //private void buttonSchedule_Click(object sender, EventArgs e)
        //{
        //    var form = new AppointmentForm(_patient);
        //    if (form.ShowDialog() == DialogResult.OK)
        //        LoadAppointments();
        //}

        //private void buttonEditAppointment_Click(object sender, EventArgs e)
        //{
        //    if (listViewAppointments.SelectedItems.Count == 0) return;
        //    var appt = _patient.Appointments[listViewAppointments.SelectedIndices[0]];
        //    var form = new AppointmentForm(_patient, appt);
        //    if (form.ShowDialog() == DialogResult.OK)
        //        LoadAppointments();
        //}

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Close();
            new LoginForm().Show();
        }
    }
}
