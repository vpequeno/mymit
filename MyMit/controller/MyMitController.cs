using MyMit.model;
using MyMit.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMit.controller
{
    class MyMitController
    {
        DateTime todayDate = new DateTime();
        private SqlDatabaseService databaseService = null;

        public MyMitController()
        {
            this.todayDate = DateTime.Now;
            this.databaseService = new SqlDatabaseService();
        }

        public DateTime TodayDate { get => todayDate; set => todayDate = value; }


        /// <summary>
        /// Retorna lista com os proximos 3 dias de reuniao
        /// </summary>
        /// <returns>
        /// Retorna uma lista com DaySchedule
        /// </returns>
        public LinkedList<DaySchedule> GetNextDays(DateTime startDate)
        {
            LinkedList<DaySchedule> nextDays = new LinkedList<DaySchedule>();

            // Cria lista com as atividades dos proximos 3 dias
            for (int i = 0; i < 3; i++)
            {
                // Incrementa o dia (baseado no valor de i. Quando i=0 mantem o dia inicial)
                DateTime dayToFetch = startDate.AddDays(i);

                // Busca lista de reunioes na base de dados para um determinado dia
                List<Meeting> meetings = getMeetingList(dayToFetch);

                // Adiciona item na lista de reunioes do dia especificado
                nextDays.AddLast(new DaySchedule(dayToFetch, meetings));
            }

            return nextDays;
        }


        /// <summary>
        /// Verifica username e password do user
        /// </summary>
        /// <returns>
        /// retorn true se o login funcionou
        /// </returns>
          public int verifyUserAccess(string username, string password)
        {
            List<User> usr = databaseService.GetData<User>("SELECT [Id],[IDProfilePicture],[Name],[Email],[Password],[IsAdmin],[Active],[ProfilePicture] FROM [dbo].[vUserInformation] WHERE [Active]=1 AND [Email]='" + username + "' AND [Password]='" + password + "'");
            if (usr.Count > 0)
                return ((User)usr.ElementAt(0)).id;
            else
                return 0;
        }

        /// <summary>
        /// Envia query para execuçao e recebe lista com todos os utilizadore
        /// </summary>
        /// <returns>
        /// Retorna uma lista com todos as reunioes de um determinado dia
        /// </returns>
        public List<Meeting> getMeetingList(DateTime dayToFetch)
        {
            return this.databaseService.GetData<Meeting>("SELECT [ID],[IDType] ,[IDOwner],[StartTime],[DurationMinutes],[Subject],[AgendaDescription],[MeetingMinutes],[AudioFile] ,[AudioTranscription],[SignatureFile],[Closed] FROM [dbo].[Meeting]  WHERE [StartTime]  BETWEEN CAST(convert(varchar, '" + dayToFetch.ToString("yyyy/MM/dd") + "', 120) AS DATE) AND DATEADD(DAY, 1, CAST(convert(varchar, '" + dayToFetch.ToString("yyyy/MM/dd") + "', 120) AS DATE))");
        }

        /// <summary>
        /// Envia query para execuçao e recebe lista com com um unico item - A meeting solicitada pelo ID
        /// </summary>
        /// <param>
        /// Inteiro com o ID da meeting
        /// </param>
        /// <returns>
        /// Retorna uma lista com um elemento - a Meeting solicitada
        /// </returns>
        public List<Meeting> getMeeting(int meetingId)
        {
            return this.databaseService.GetData<Meeting>("SELECT [ID],[IDType] ,[IDOwner],[StartTime],[DurationMinutes],[Subject],[AgendaDescription],[MeetingMinutes],[AudioFile] ,[AudioTranscription],[SignatureFile],[Closed] FROM [dbo].[Meeting]  WHERE [id]=" + meetingId.ToString());
        }

        /// <summary>
        /// Envia query para execuçao e recebe lista com os convidados de uma meeting
        /// </summary>
        /// <param>
        /// Inteiro com o ID da meeting
        /// </param>
        /// <returns>
        /// Retorna uma lista com os convidados de uma reuniao
        /// </returns>
        public List<MeetingInvite> getMeetingGuests(int meetingId)
        {
            return this.databaseService.GetData<MeetingInvite>("SELECT [Id],[IdMeeting],[IdUser],[Attended] FROM [MyMit].[dbo].[MeetingInvite] WHERE [IdMeeting]=" + meetingId.ToString());
        }


        /// <summary>
        /// Envia query para execuçao e recebe lista com as tarefas de uma meeting
        /// </summary>
        /// <param>
        /// Inteiro com o ID da meeting
        /// </param>
        /// <returns>
        /// Retorna uma lista com as tarefas associadas a uma reuniao
        /// </returns>
        public List<UserTask> getMeetingTasks(int meetingId)
        {
            return this.databaseService.GetData<UserTask>("SELECT [Id],[IdMeeting],[IdOwner],[Description],[Deadline] FROM [dbo].[UserTask] WHERE [IdMeeting]=" + meetingId.ToString());
        }

    }
}
