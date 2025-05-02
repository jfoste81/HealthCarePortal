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
    public partial class DashboardDoctorForm : Form
    {
        private readonly Doctor _doctor;
        private List<Patient> _filteredPatients;

        public DashboardDoctorForm(Doctor doctor)
        {
            InitializeComponent();
            _doctor = doctor;
            Text = $"Dr. {_doctor.Name}";

            // Patients tab wiring
            listViewPatients.DoubleClick += ListViewPatients_DoubleClick;

            // Inbox tab wiring
            listViewInbox.DoubleClick += ListViewInbox_DoubleClick;

            // Overview tab wiring 
            listViewNotificationsOverview.View = View.List;
            listViewNotificationsOverview.DoubleClick += NotificationsOverview_DoubleClick;

            // Schedule tab wiring 
            listViewSchedule.DoubleClick += ListViewSchedule_DoubleClick;
            buttonEditAppointment.Click += ButtonEditAppointment_Click;
            buttonCancelAppointment.Click += ButtonCancelAppointment_Click;

            // Logout 
            buttonLogout.Click += (s, e) => {
                Close();
                new LoginForm().Show();
            };

            // Initial load of all tabs
            LoadOverview();
            LoadPatients();
            LoadInbox();
            LoadSchedule();
        }

        // Patients Tab 
        private void LoadPatients(IEnumerable<Patient> patients = null)
        {
            var list = patients?.ToList() ?? _doctor.Patients;
            _filteredPatients = list;
            listViewPatients.Items.Clear();

            foreach (var p in list.OrderBy(p => p.Name))
            {
                var item = new ListViewItem(p.Id.ToString());
                item.SubItems.Add(p.Name);
                item.SubItems.Add(p.Age.ToString());
                item.SubItems.Add(p.Gender);
                item.SubItems.Add(p.Phone);
                listViewPatients.Items.Add(item);
            }
        }

        private void ListViewPatients_DoubleClick(object sender, EventArgs e)
        {
            if (listViewPatients.SelectedIndices.Count == 0) return;
            int idx = listViewPatients.SelectedIndices[0];
            var patient = _filteredPatients[idx];

            using var detail = new PatientDetailForm(_doctor, patient);
            detail.ShowDialog();
            LoadPatients();
        }

        // Inbox Tab 
        private void LoadInbox()
        {
            listViewInbox.Items.Clear();
            foreach (var msg in _doctor.Inbox.OrderByDescending(m => m.Timestamp))
            {
                var item = new ListViewItem(msg.Timestamp.ToString("g"));
                item.SubItems.Add(msg.Author);
                item.SubItems.Add(msg.Subject);
                listViewInbox.Items.Add(item);
            }
        }

        private void ListViewInbox_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedMessageDetail();
        }

        private void ButtonViewReply_Click(object sender, EventArgs e)
        {
            OpenSelectedMessageDetail();
        }

        private void OpenSelectedMessageDetail()
        {
            if (listViewInbox.SelectedIndices.Count == 0) return;
            int idx = listViewInbox.SelectedIndices[0];
            var msg = _doctor.Inbox.OrderByDescending(m => m.Timestamp).ElementAt(idx);

            using var detail = new MessageDetailForm(_doctor, msg);
            detail.ShowDialog();
            LoadInbox();
        }

        // Overview Tab 
        private void LoadOverview()
        {
            // Today's Appointments
            listViewTodayAppointments.Items.Clear();
            var todayAppts = _doctor.Patients
                .SelectMany(p => p.Appointments)
                .Where(a => a.Timestamp.Date == DateTime.Today)
                .OrderBy(a => a.Timestamp);
            foreach (var appt in todayAppts)
            {
                var item = new ListViewItem(appt.Timestamp.ToString("t"));
                item.SubItems.Add(appt.PatientName);
                listViewTodayAppointments.Items.Add(item);
            }

            // Notifications (in single-column ListView)
            listViewNotificationsOverview.Items.Clear();
            foreach (var n in _doctor.Notifications
                                     .OrderByDescending(nf => nf.Timestamp))
            {
                listViewNotificationsOverview.Items.Add(
                  $"{n.Timestamp:g} – {n.Type}: {n.Description}"
                );
            }
        }

        private void NotificationsOverview_DoubleClick(object sender, EventArgs e)
        {
            if (listViewNotificationsOverview.SelectedIndices.Count == 0) return;
            int idx = listViewNotificationsOverview.SelectedIndices[0];
            var notif = _doctor.Notifications
                         .OrderByDescending(n => n.Timestamp)
                         .ElementAt(idx);

            switch (notif.Type)
            {
                case "Message":
                    tabControlDoctor.SelectedTab = tabPageInbox;
                    break;
                case "Appointment":
                    tabControlDoctor.SelectedTab = tabPageSchedule;
                    break;
            }
        }

        // Schedule Tab 
        private void LoadSchedule()
        {
            listViewSchedule.Items.Clear();
            var upcoming = _doctor.Patients
                .SelectMany(p => p.Appointments)
                .Where(a => a.Timestamp >= DateTime.Now)
                .OrderBy(a => a.Timestamp);
            foreach (var appt in upcoming)
            {
                var item = new ListViewItem(appt.Timestamp.ToString("g"));
                item.SubItems.Add(appt.PatientName);
                listViewSchedule.Items.Add(item);
            }
        }

        private void ListViewSchedule_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedAppointment();
        }

        private void ButtonEditAppointment_Click(object sender, EventArgs e)
        {
            EditSelectedAppointment();
        }

        private void ButtonCancelAppointment_Click(object sender, EventArgs e)
        {
            if (listViewSchedule.SelectedIndices.Count == 0) return;
            int idx = listViewSchedule.SelectedIndices[0];
            var apptList = _doctor.Patients
                .SelectMany(p => p.Appointments)
                .OrderBy(a => a.Timestamp)
                .ToList();
            var appt = apptList[idx];

            var confirm = MessageBox.Show(
                $"Cancel appointment on {appt.Timestamp:g} with {appt.PatientName}?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (confirm == DialogResult.Yes)
            {
                // remove from both sides
                var patient = _doctor.Patients.First(p => p.Appointments.Contains(appt));
                patient.Appointments.Remove(appt);
                _doctor.Patients
                       .First(p => p.Id == patient.Id)
                       .Appointments.Remove(appt);

                // add notifications
                patient.Notifications.Add(new Notification(
                    "Appointment",
                    $"Your appointment on {appt.Timestamp:g} was cancelled by Dr. {_doctor.Name}."
                ));
                _doctor.Notifications.Add(new Notification(
                    "Appointment",
                    $"You cancelled the appointment on {appt.Timestamp:g} with {patient.Name}."
                ));

                LoadSchedule();
                LoadOverview();
            }
        }

        private void EditSelectedAppointment()
        {
            if (listViewSchedule.SelectedIndices.Count == 0) return;
            int idx = listViewSchedule.SelectedIndices[0];
            var apptList = _doctor.Patients
                .SelectMany(p => p.Appointments)
                .OrderBy(a => a.Timestamp)
                .ToList();
            var appt = apptList[idx];

            using var form = new AppointmentForm(_doctor, appt);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSchedule();
                LoadOverview();
            }
        }
    }
}
