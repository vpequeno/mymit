using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using MyMit.controller;
using MyMit.custom;
using MyMit.model;
using MyMit.services;
using NAudio.Wave;

namespace MyMit.view
{
    public partial class MeetingView : Form
    {
        private List<MeetingType> meetingType = new List<MeetingType>();
        private MeetingController controller = null;
        private Meeting meeting = null;
        private List<MeetingInvite> guestList = null;
        private List<User> users = null;
        private bool newMeeting = true;
        private bool isRecording = false;
        private int idUser;
        private WaveIn sourceStream = null;
        private WaveFileWriter waveWriter = null;
        private readonly IAudioRecorder recorder;

        // Construtor utilizador para novas reunioes
        public MeetingView(int idUser)
        {
            InitializeComponent();

            // Nova meeting
            this.newMeeting = true;
            this.idUser = idUser;

            // Instancia a classe controller
            this.controller = new MeetingController();

            // Carrega lista de utilizadores
            loadUsersList();

            // Definir o campo de data/hora com o formato dia/mes/ano hora:minuto
            this.dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerStart.CustomFormat = "dd/MM/yyyy hh:mm";

            // Load duration options
            loadDuration();

            // Carregar categorias para a linkedlist e combobox
            loadTypesList();

            // Carrega grid com os utilizadores
            loadUsers();
        }

        // Este contrutor é utilizado quando queremos carregar o form com uma reuniao ja existente
        public MeetingView(int idUser, Meeting meeting, List<UserTask> tasks, List<MeetingInvite> guestList)
        {
            InitializeComponent();

            // Reuniao existente
            this.newMeeting = false;
            this.meeting = meeting;
            this.idUser = idUser;

            // Instancia a classe controller
            this.controller = new MeetingController();

            // Carrega lista de utilizadores
            loadUsersList();

            // Activa o botao de iniciar a reuniao
            buttonStart.Visible = true;

            // Definir o campo de data/hora com o formato dia/mes/ano hora:minuto
            this.dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerStart.CustomFormat = "dd/MM/yyyy HH:mm";

            // Load duration options
            loadDuration();

            // Carregar categorias para a linkedlist e combobox
            loadTypesList();

            // Adiciona a coluna custom de data na grid
            CalendarColumn col = new CalendarColumn();
            int colno = this.dataGridViewTasks.Columns.Add(col);
            this.dataGridViewTasks.Columns[colno].HeaderText = "Deadline";


            // Carrega valores da meeting
            this.dateTimePickerStart.Value = this.meeting.startTime;
            this.textBoxSubject.Text = this.meeting.subject;
            this.textBoxAgenda.Text = this.meeting.agendaDescription;
            this.textBoxMeetingminutes.Text = this.meeting.meetingMinutes;
            selectDuration(this.meeting.durationMinutes);
            selectType(this.meeting.idType);
            loadUsersWithSelected(guestList); // Carrega users na base de dados e marca os selecioandos
            loadTasks(tasks); // Carrega lista de tarefas
            this.panelEditMeeting.Visible = true;

            recorder = new AudioRecorder();
        }

        private void loadUsersList() 
        {
            this.users = controller.getUserList();
        }

        /// <summary>
        /// Adiciona nova linha nas tarefas
        /// </summary>
        private void addTaskToList()
        {
            // Adiciona uma nova linha na grid de tarefas
            int pos = this.dataGridViewTasks.Rows.Add();
            this.dataGridViewTasks.Rows[pos].Cells[3].Value = DateTime.Now;

            // Busca a instancia da celula 0 (lista de users)
            DataGridViewComboBoxCell comboBoxCell = (this.dataGridViewTasks.Rows[pos].Cells[1] as DataGridViewComboBoxCell);

            // Define campos de valor e texto na combobox de users
            comboBoxCell.DisplayMember = "name";
            comboBoxCell.ValueMember = "id";

            // Popula a combobox
            List<User> users = this.users;
            for (int i = 0; i < users.Count; i++)
            {
                comboBoxCell.Items.Add(users.ElementAt(i));
            }


        }

        /// <summary>
        /// Guarda as altereçoes na reuniao
        /// </summary>
        private void saveMeeting()
        {

        }

        /// <summary>
        /// Preenche a combox de tipos com os tipos de reuniao
        /// </summary>
        private void loadTypesList()
        {
            // Define campos de valor e texto na combobox de tipos
            this.comboBoxType.DisplayMember = "name";
            this.comboBoxType.ValueMember = "id";

            // Solicita list ade tipos a classe controller
            // Adiciona lista com resultados na Lista de tipos
            List<MeetingType> types = controller.getTypesList();
            for (int i = 0; i < types.Count; i++)
            {
                meetingType.Add(types.ElementAt(i));
            }

            // Define a lista como fonte para combobox de tipos
            this.comboBoxType.DataSource = this.meetingType;
        }

        /// <summary>
        /// Preenche a lista de utilizadores para serem adicionados ao invite da reuniao
        /// </summary>
        private void loadUsers()
        {
            // Solicita lista de users a classe controller
            // Adiciona lista com resultados na Lista de uers
            List<User> users = this.users;
            for (int i = 0; i < users.Count; i++)
            {
                int pos = this.dataGridViewGuests.Rows.Add();
                this.dataGridViewGuests.Rows[pos].Cells[0].Value = users.ElementAt(i).id;
                this.dataGridViewGuests.Rows[pos].Cells[2].Value = users.ElementAt(i).name;
            }
        }


        /// <summary>
        /// Seleciona convidados
        /// </summary>
        private void loadUsersWithSelected(List<MeetingInvite> guestList)
        {

            List<User> users = this.users;
            for (int i = 0; i < users.Count; i++)
            {
                int pos = this.dataGridViewGuests.Rows.Add();
                this.dataGridViewGuests.Rows[pos].Cells[0].Value = users.ElementAt(i).id;
                this.dataGridViewGuests.Rows[pos].Cells[2].Value = users.ElementAt(i).name;

                for (int j = 0; j < guestList.Count; j++)
                {
                    if (users.ElementAt(i).id == ((MeetingInvite)guestList.ElementAt(j)).idUser)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)this.dataGridViewGuests.Rows[pos].Cells[1];
                        chk.Value = true;
                    }
                }
            }
        }

        /// <summary>
        /// Carrega Lista de tarefas
        /// </summary>
        private void loadTasks(List<UserTask> tasks)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                int idx = this.dataGridViewTasks.Rows.Add();
                this.dataGridViewTasks.Rows[idx].Cells[0].Value = ((UserTask)tasks.ElementAt(i)).Id;
                this.dataGridViewTasks.Rows[idx].Cells[2].Value = ((UserTask)tasks.ElementAt(i)).Description;

                // Busca a instancia da celula 0 (lista de users)
                DataGridViewComboBoxCell comboBoxCell = (this.dataGridViewTasks.Rows[idx].Cells[1] as DataGridViewComboBoxCell);

                // Define campos de valor e texto na combobox de users
                comboBoxCell.DisplayMember = "name";
                comboBoxCell.ValueMember = "id";

                // Popula a combobox
                List<User> users = this.users;
                for (int k = 0; k < users.Count; k++)
                {
                    comboBoxCell.Items.Add(users.ElementAt(k));
                }


                // Seleciona o owner da tarefa
                this.dataGridViewTasks.Rows[idx].Cells[1].Value = ((UserTask)tasks.ElementAt(i)).IdOwner;

                // Seleciona a data
                ((CalendarCell)this.dataGridViewTasks.Rows[idx].Cells[3]).Value = ((UserTask)tasks.ElementAt(i)).Deadline;
            }
        }

        /// <summary>
        /// Seleciona tipo da reuniao, caso a janela esteja sendo aberta para uma reuniao existente
        /// </summary>
        private void selectType(int typeId)
        {
            for (int i = 0; i < this.comboBoxType.Items.Count; i++)
            {
                if (Convert.ToInt32(this.comboBoxType.SelectedItem.GetType().GetProperty("id").GetValue(this.comboBoxType.Items[i], null)) == typeId)
                {
                    this.comboBoxType.SelectedIndex = i;
                    return;
                }
            }
        }


        /// <summary>
        /// Seleciona tempo de duraçao, caso a janela esteja sendo aberta para uma reuniao existente
        /// </summary>
        private void selectDuration(int duration) 
        {
            for (int i=0;  i<this.comboDropDownDuration.Items.Count; i++) 
            {
                if(Convert.ToInt32(this.comboDropDownDuration.SelectedItem.GetType().GetProperty("Value").GetValue(this.comboDropDownDuration.Items[i], null))==duration) 
                {
                    this.comboDropDownDuration.SelectedIndex = i;
                    return;
                }
            }
        }

        /// <summary>
        /// Preenche a combobox de tempo de reuniao
        /// </summary>
        private void loadDuration()
        {
            this.comboDropDownDuration.DisplayMember = "Text";
            this.comboDropDownDuration.ValueMember = "Value";

            int defSelection = this.comboDropDownDuration.Items.Add(new { Text = "0 minutes", Value = 0 });
            this.comboDropDownDuration.Items.Add(new { Text = "1 minute", Value = 1 });
            this.comboDropDownDuration.Items.Add(new { Text = "5 minutes", Value = 5 });
            this.comboDropDownDuration.Items.Add(new { Text = "10 minutes", Value = 10 });
            this.comboDropDownDuration.Items.Add(new { Text = "15 minutes", Value = 15 });
            this.comboDropDownDuration.Items.Add(new { Text = "20 minutes", Value = 20 });
            this.comboDropDownDuration.Items.Add(new { Text = "25 minutes", Value = 25 });
            this.comboDropDownDuration.Items.Add(new { Text = "30 minutes", Value = 30 });
            this.comboDropDownDuration.Items.Add(new { Text = "35 minutes", Value = 35 });
            this.comboDropDownDuration.Items.Add(new { Text = "40 minutes", Value = 40 });
            this.comboDropDownDuration.Items.Add(new { Text = "45 minutes", Value = 45 });
            this.comboDropDownDuration.Items.Add(new { Text = "50 minutes", Value = 50 });
            this.comboDropDownDuration.Items.Add(new { Text = "55 minutes", Value = 55 });
            this.comboDropDownDuration.Items.Add(new { Text = "1 hour", Value = 60 });
            this.comboDropDownDuration.Items.Add(new { Text = "2 hours", Value = 120 });
            this.comboDropDownDuration.Items.Add(new { Text = "3 hours", Value = 180 });
            this.comboDropDownDuration.Items.Add(new { Text = "4 hours", Value = 240 });
            this.comboDropDownDuration.Items.Add(new { Text = "5 hours", Value = 300 });
            this.comboDropDownDuration.Items.Add(new { Text = "6 hours", Value = 360 });
            this.comboDropDownDuration.Items.Add(new { Text = "7 hours", Value = 420 });
            this.comboDropDownDuration.Items.Add(new { Text = "8 hours", Value = 480 });
            this.comboDropDownDuration.Items.Add(new { Text = "9 hours", Value = 540 });
            this.comboDropDownDuration.Items.Add(new { Text = "10 hours", Value = 600 });
            this.comboDropDownDuration.Items.Add(new { Text = "11 hours", Value = 660 });
            this.comboDropDownDuration.Items.Add(new { Text = "12 hours", Value = 720 });
            this.comboDropDownDuration.Items.Add(new { Text = "13 hours", Value = 780 });
            this.comboDropDownDuration.Items.Add(new { Text = "14 hours", Value = 840 });
            this.comboDropDownDuration.Items.Add(new { Text = "15 hours", Value = 900 });
            this.comboDropDownDuration.Items.Add(new { Text = "16 hours", Value = 960 });
            this.comboDropDownDuration.Items.Add(new { Text = "17 hours", Value = 1020 });
            this.comboDropDownDuration.Items.Add(new { Text = "18 hours", Value = 1080 });
            this.comboDropDownDuration.Items.Add(new { Text = "19 hours", Value = 1140 });
            this.comboDropDownDuration.Items.Add(new { Text = "20 hours", Value = 1200 });
            this.comboDropDownDuration.Items.Add(new { Text = "21 hours", Value = 1260 });
            this.comboDropDownDuration.Items.Add(new { Text = "22 hours", Value = 1320 });
            this.comboDropDownDuration.Items.Add(new { Text = "23 hours", Value = 1380 });

            this.comboDropDownDuration.SelectedIndex = defSelection;
        }

        /// <summary>
        /// Valida inputs do utilizador
        /// </summary>
        private bool validateInsetedData()
        {
            String errors = "";
            
            // verifica se a data é no futuro
            if (this.dateTimePickerStart.Value < DateTime.Now)
            {
                errors += "- The meeting date should be in future.\n";
            }



            // verifica se a reuniao tem um titulo
            if (textBoxSubject.Text == "Subject" || textBoxSubject.Text == "")
            {
                errors += "- Please define a subject.\n";
            }



            // verifica se a reuniao tem convidados
            int selectedUsers = 0;
            foreach (DataGridViewRow row in this.dataGridViewGuests.Rows)
            {
                DataGridViewCheckBoxCell chkchecking = row.Cells[1] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chkchecking.Value) == true)
                {
                    selectedUsers++;
                }
            }

            if (selectedUsers == 0)
            {
                errors += "- The meeting has no guests.\n";
            }




            // Verifica se houve algum erro, se sim, mostra  amensagem e returna false
            if (!errors.Equals("")) 
            { 
                MessageBox.Show("The following validation errors were found:\n"+errors, "Validation Error",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

            // Eventos
            private void comboDropDownDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboDropDownDuration.SelectedItem != null)
            {
                int selected = Convert.ToInt32(this.comboDropDownDuration.SelectedItem.GetType().GetProperty("Value").GetValue(this.comboDropDownDuration.SelectedItem, null));
                this.textBoxMinutes.Text = selected.ToString();
            }
        }

        private void startMeeting()
        {
            // Altera a lista de convidados para adicionar a coluna de presenca
            //
            this.dataGridViewGuests.ColumnHeadersVisible = true;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Attendant";
            chk.Name = "attendant";

            int col = this.dataGridViewGuests.Columns.Add(chk);
            this.dataGridViewGuests.Columns[col].Width = 60;

            // Remove users nao convidados
            for (int i = 0; i < this.dataGridViewGuests.Rows.Count; i++)
            {   // Essa porra remove por index...
                if (this.dataGridViewGuests.Rows[i].Cells[1].Value == null)
                {
                    this.dataGridViewGuests.Rows.RemoveAt(i);
                }
            }

            // Mostra o painel de gravaçao
            this.groupBoxRecord.Visible = true;

            // Gere visibilidad eods botoes
            this.buttonStart.Enabled = false;
            this.buttonClose.Enabled = false;
            this.buttonStopMeeting.Visible = true;

        }

        private void stopMeeting()
        {
            // Verifica se a reuniºao está sendo gravada, se sim, para a gravaçao
            if (this.isRecording)
            {
                this.buttonStop.PerformClick();
            }

            // Bloqueia a lista de convidados
            //
            this.dataGridViewGuests.ColumnHeadersVisible = false;
            this.dataGridViewGuests.Enabled = false;

            // Esconde o painel de gravaçao
            this.groupBoxRecord.Visible = false;

            // Gere visibilidad eods botoes
            this.buttonStart.Enabled = false;
            this.buttonClose.Enabled = true;
            this.buttonStopMeeting.Visible = false;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TODO: ID do owner
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (validateInsetedData()) // Se todos os campos forem validados com sucesso... cria a reuniao na base de dados
            {
                if (this.newMeeting)
                {
                    // Carrega string com o ID dos convidados para a reuniao, separados por virgula
                    String selectedusersId = "";
                    bool FirstValue = true;
                    foreach (DataGridViewRow row in this.dataGridViewGuests.Rows)
                    {
                        DataGridViewCheckBoxCell chkchecking = row.Cells[1] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(chkchecking.Value) == true)
                        {
                            if (!FirstValue)
                            {
                                selectedusersId += ", ";
                            }
                            selectedusersId += row.Cells[0].Value;
                            FirstValue = false;
                        }
                    }

                    bool execSucccess = false;
                    execSucccess = controller.addNewMeeting(((MeetingType)comboBoxType.SelectedItem).id, this.idUser, dateTimePickerStart.Value, Int32.Parse(textBoxMinutes.Text), textBoxSubject.Text, textBoxAgenda.Text, selectedusersId);

                    if (!execSucccess) // Se houver erro na criaçao, na base de dados, mostramos uma mensagem de erro
                        MessageBox.Show("Error saving the meeting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    { // reuniao criada com sucesso. Mostra a mensagem e fecha o form de criaçao
                        MessageBox.Show("Meeting created with success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else {
                    // Carrega string com o ID dos convidados para a reuniao, separados por virgula
                    String selectedusersId = "";
                    bool FirstValue = true;
                    foreach (DataGridViewRow row in this.dataGridViewGuests.Rows)
                    {
                        DataGridViewCheckBoxCell chkchecking = row.Cells[1] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(chkchecking.Value) == true)
                        {
                            if (!FirstValue)
                            {
                                selectedusersId += ", ";
                            }
                            selectedusersId += row.Cells[0].Value;
                            FirstValue = false;
                        }
                    }

                    bool execSucccess = false;

                    // Guarda dados da reuniao
                    execSucccess = controller.saveMeeting(meeting.id, ((MeetingType)comboBoxType.SelectedItem).id, dateTimePickerStart.Value, Int32.Parse(textBoxMinutes.Text), textBoxSubject.Text, textBoxAgenda.Text, selectedusersId, textBoxMeetingminutes.Text);


                    // Remove todas as tarefas e adiciona novamente
                    execSucccess = controller.removeAllTasks(meeting.id);

                    // Guarda tarefas
                    for (int i = 0; i < this.dataGridViewTasks.Rows.Count; i++)
                    {
                        string taskuser = this.dataGridViewTasks.Rows[i].Cells[1].Value.ToString();
                        string taskdesc = this.dataGridViewTasks.Rows[i].Cells[2].Value.ToString();
                        DateTime deadline = (DateTime)this.dataGridViewTasks.Rows[i].Cells[3].Value;

                        execSucccess = controller.addMeetingTask(meeting.id, taskuser, taskdesc, deadline);
                    }

                    if (!execSucccess) // Se houver erro na criaçao, na base de dados, mostramos uma mensagem de erro
                        MessageBox.Show("Error saving the meeting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    { // reuniao criada com sucesso. Mostra a mensagem e fecha o form de criaçao
                        MessageBox.Show("Meeting saved with success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

        }

        // Controla o texto da textbox "Subject". 
        // Este event handler é acionado quando a textbox de Subject é selecionada
        // Quando seleciona deixa o texto em branco, se nenhum valor tiver sido inserido pelo utilizador 
        private void textBoxSubject_Enter(object sender, EventArgs e)
        {
            if (textBoxSubject.Text == "Subject")
                textBoxSubject.Text = "";
        }

        // Controla o texto da textbox "Subject". 
        // Este event handler é acionado quando se tira o foco da textbox de Subject
        // Quando sai da textbox, altera o texto para Subject quando o utilizador nºao inseriou nenhum titulo para a reuniºao
        private void textBoxSubject_Leave(object sender, EventArgs e)
        {
            if (textBoxSubject.Text == "")
                textBoxSubject.Text = "Subject";

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            addTaskToList();
        }

        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewTasks.SelectedRows)
            {
                this.dataGridViewTasks.Rows.RemoveAt(item.Index);
            }
        }

        private void buttonExportPdf_Click(object sender, EventArgs e)
        {
            new PdfService();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            startMeeting();
        }


        private void buttonRec_Click(object sender, EventArgs e)
        {
            // inicia flag para o programa saber que a reuniao esta a ser gravada
            this.isRecording = true;

            // Inicia gravacao
            recorder.BeginRecording("tet.wav");


            // gere disponibilidade dos botoes de gravar e parar
            this.buttonStop.Enabled = true;
            this.buttonRec.Enabled = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // ALtera o cursor para "waiting" e bloqueia a janela da app
            this.Cursor = Cursors.WaitCursor;
            this.Enabled = true;

            // Para a gravacao de audio
            recorder.Stop();

            /*
            // Agurarda ate o fim da transcricao
            while (this.audio_recorder.isLoading())
                Thread.Sleep(1000);
 */
            // ALtera o cursor para a seta normal e desbloqueia a janela da app
            this.Enabled = true;
            this.Cursor = Cursors.Default;
 /*
            // Escreve o texto transcrito do audio para o respectivo campo no fim do form
            this.textBoxTranscription.Text = this.audio_recorder.getText();
            */
            // Libera o botao start e bloqueia o botao de stop
            this.buttonStop.Enabled = false;
            this.buttonRec.Enabled = true;

            // desliga flag para o programa saber que a reuniao nao esta mais a ser gravada
            this.isRecording = true;
        }

        private void buttonStopMeeting_Click(object sender, EventArgs e)
        {
            stopMeeting();
        }
    }
}
