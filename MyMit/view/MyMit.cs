using MyMit.controller;
using MyMit.model;
using MyMit.view;
using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyMit
{
    public partial class FormMyMit : Form
    {
        MyMitController controller = null;
        LinkedList<DaySchedule> nextThreeDays = null;
        int userId = 0;

        public FormMyMit(int userId)
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
                        grid.Rows[pos].Cells[1].Value = meetingItem.startTime.ToString("HH:mm")+" - "+ meetingItem.startTime.AddMinutes(meetingItem.durationMinutes).ToString("HH:mm");
                        grid.Rows[pos].Cells[2].Value = meetingItem.subject;
                    }
                }
            }
        }


        private void fillAgenda() {
            if (nextThreeDays != null && nextThreeDays.Count==3) 
            {
                // Preenche dados do primeiro quadrado amarelo
                DaySchedule dayZero = nextThreeDays.ElementAt(0);
                DateTime dayZeroDate = dayZero.day;
                this.dateTimePicker.Value = dayZeroDate; // Altera o time picker (quick jump)
                this.labelDay01.Text = dayZeroDate.Day.ToString(); // Dia
                this.labelWekDay01.Text = dayZeroDate.DayOfWeek.ToString(); // Dia da semana
                this.labelMonth01.Text = dayZeroDate.ToString("MMMM"); // Mes
                this.labelYear.Text = dayZeroDate.Year.ToString(); // Preenche label do ano (que é baseada no ano do primeiro quadrado)
                fillMeetingsGrid(dayZero, this.dataGridViewEvents01); // Preenche o grid com as reunioes do primeio quadrado amarelo


                // Preenche dados do segundo quadrado amarelo
                DaySchedule dayTwo = nextThreeDays.ElementAt(1);
                DateTime dayTwoDate = dayTwo.day;
                this.labelDay02.Text = dayTwoDate.Day.ToString(); // Dia
                this.labelWeekDay02.Text = dayTwoDate.DayOfWeek.ToString(); // Dia da semana
                this.labelMonth02.Text = dayTwoDate.ToString("MMMM"); // Mes
                fillMeetingsGrid(dayTwo, this.dataGridViewEvents02); // Preenche o grid com as reunioes do SEGUNDO quadrado amarelo

                // Preenche dados do terceiro quadrado amarelo
                DaySchedule dayThree = nextThreeDays.ElementAt(2);
                DateTime dayThreeDate = dayThree.day;
                this.labelDay03.Text = dayThreeDate.Day.ToString(); // Dia
                this.labelWeekDay03.Text = dayThreeDate.DayOfWeek.ToString(); // Dia da semana
                this.labelMonth03.Text = dayThreeDate.ToString("MMMM"); // Mes
                fillMeetingsGrid(dayThree, this.dataGridViewEvents03); // Preenche o grid com as reunioes do TERCEIRO quadrado amarelo

            }
        }

        // Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            this.nextThreeDays = this.controller.GetNextDays(DateTime.Now);
            fillAgenda();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            _ = new MeetingView(this.userId).ShowDialog();
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            this.nextThreeDays = this.controller.GetNextDays(DateTime.Now);
            fillAgenda();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            DaySchedule lastDay = this.nextThreeDays.ElementAt(2); // Seleciona o ultimo dia no form
            this.nextThreeDays = this.controller.GetNextDays(lastDay.day.AddDays(1)); // Adiciona 1 dia
            fillAgenda(); // Preenche o form
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            DaySchedule lastDay = this.nextThreeDays.ElementAt(0); // Seleciona o primeiro dia no form
            this.nextThreeDays = this.controller.GetNextDays(lastDay.day.AddDays(-3)); // Subtrai 3 dias
            fillAgenda(); // Preenche o form
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.nextThreeDays = this.controller.GetNextDays(dateTimePicker.Value); // Busca dia selecionado pelo time picker (quick jump)
            fillAgenda(); // Preenche o form
        }

        private void dataGridViewEvents01_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void FormMyMit_Activated(object sender, EventArgs e)
        {
            if (this.nextThreeDays != null) {
                this.nextThreeDays = this.controller.GetNextDays(dateTimePicker.Value);
                fillAgenda();
            }
        }

        private void dataGridViewEvents01_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewEvents01.SelectedRows.Count == 1 && this.dataGridViewEvents01.SelectedRows[0].Cells[0].Value != null)
            {
                int id = Int32.Parse(this.dataGridViewEvents01.SelectedRows[0].Cells[0].Value.ToString());
                List<Meeting> meetings = controller.getMeeting(id);
                List<MeetingInvite> guestList = controller.getMeetingGuests(id);

                _ = new MeetingView(this.userId, meetings.ElementAt(0), guestList).ShowDialog();
            }
        }

        private void dataGridViewEvents02_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewEvents02.SelectedRows.Count == 1 && this.dataGridViewEvents02.SelectedRows[0].Cells[0].Value != null)
            {
                int id = Int32.Parse(this.dataGridViewEvents02.SelectedRows[0].Cells[0].Value.ToString());
                List<Meeting> meetings = controller.getMeeting(id);
                List<MeetingInvite> guestList = controller.getMeetingGuests(id);

                _ = new MeetingView(this.userId, meetings.ElementAt(0), guestList).ShowDialog();
            }
        }

        private void dataGridViewEvents03_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewEvents03.SelectedRows.Count == 1 && this.dataGridViewEvents03.SelectedRows[0].Cells[0].Value != null)
            {
                int id = Int32.Parse(this.dataGridViewEvents03.SelectedRows[0].Cells[0].Value.ToString());
                List<Meeting> meetings = controller.getMeeting(id);
                List<MeetingInvite> guestList = controller.getMeetingGuests(id);

                _ = new MeetingView(this.userId, meetings.ElementAt(0), guestList).ShowDialog();
            }
        }
    }
}
