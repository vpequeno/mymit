using MyMit.controller;
using MyMit.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMit.view
{
    public partial class FormSearchmeeting : Form
    {
        MyMitController controller = null;
        LinkedList<DaySchedule> foundMeetings = null;
        int userId = 0;

        public FormSearchmeeting(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.controller = new MyMitController();
        }


        // Metodos e funçoes
        private void fillMeetingsGrid(DaySchedule schedueDay, DataGridView grid)
        {
            grid.Rows.Clear();

            if (schedueDay != null && grid != null && schedueDay.meetings != null)
            {
                for (int i = 0; i < schedueDay.meetings.Count; i++)
                {

                    if (schedueDay.meetings != null)
                    {
                        Meeting meetingItem = schedueDay.meetings.ElementAt(i);

                        int pos = grid.Rows.Add();
                        grid.Rows[pos].Cells[0].Value = meetingItem.id.ToString();
                        grid.Rows[pos].Cells[1].Value = meetingItem.startTime.Date.ToString() + " " + meetingItem.startTime.ToString("HH:mm");
                        grid.Rows[pos].Cells[2].Value = meetingItem.subject;
                    }
                }
            }
        }

        private void fillAgenda()
        {
            if (foundMeetings != null && foundMeetings.Count > 0)
            {
                DaySchedule dayZero = foundMeetings.ElementAt(0);
                DateTime dayZeroDate = dayZero.day;
                fillMeetingsGrid(dayZero, this.dataGridViewEvents01); // Preenche o grid com as reunioes do primeio quadrado amarelo

            }
        }


        private void dataGridViewEvents01_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewEvents01.SelectedRows.Count == 1 && this.dataGridViewEvents01.SelectedRows[0].Cells[0].Value != null)
            {
                int id = Int32.Parse(this.dataGridViewEvents01.SelectedRows[0].Cells[0].Value.ToString());
                List<Meeting> meetings = controller.getMeeting(id);
                List<MeetingInvite> guestList = controller.getMeetingGuests(id);
                List<UserTask> tasks = controller.getMeetingTasks(id);

                _ = new MeetingView(this.userId, meetings.ElementAt(0), tasks, guestList).ShowDialog();
            }
        }

        private void textBoxFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.foundMeetings = this.controller.SearchMeetings(this.userId, this.textBoxFilter.Text);
                fillAgenda();
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.foundMeetings = this.controller.SearchMeetings(this.userId, this.textBoxFilter.Text);
            fillAgenda();
        }
    }
}
