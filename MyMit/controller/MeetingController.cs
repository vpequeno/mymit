using MyMit.model;
using MyMit.services;
using Syncfusion.Windows.Forms.Tools.Win32API;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMit.controller
{
    /*
    Classe controller para a view de reunioes
    */
    class MeetingController
    {
        private SqlDatabaseService databaseService = null;

        public MeetingController() 
        {
            // Iniciar conexao na base de dados
            this.databaseService = new SqlDatabaseService();
        }

        /// <summary>
        /// Envia query para execuçao e recebe lista com tipos de reuniao
        /// </summary>
        /// <returns>
        /// Retorna uma lista com elementos os tipos de reuniao do tipo MeetingType
        /// </returns>
        public List<MeetingType> getTypesList()
        {
            return databaseService.GetData<MeetingType>("SELECT id, name FROM vMeetingTypes");
        }

        /// <summary>
        /// Envia query para execuçao e recebe lista com informaçao de um utilizador especifico
        /// </summary>
        /// <param name="id">Interito com o id do utilizador.</param>
        /// <returns>
        /// Retorna uma lista com elementos do tipo de User
        /// </returns>
        public List<User> getUserInformation(int id)
        {
            return databaseService.GetData<User>("SELECT [Id],[IDProfilePicture],[Name],[Email],[Password],[IsAdmin],[IsAdmin],[ProfilePicture] FROM [dbo].[vUserInformation] WHERE id=" + id.ToString());
        }


        /// <summary>
        /// Envia query para execuçao e recebe lista com todos os utilizadore
        /// </summary>
        /// <returns>
        /// Retorna uma lista com todos os utilizadores
        /// </returns>
        public List<User> getUserList()
        {
            return databaseService.GetData<User>("SELECT [Id],[IDProfilePicture],[Name],[Email],[Password],[IsAdmin],[Active],[ProfilePicture] FROM [dbo].[vUserInformation]");
        }

        /// <summary>
        /// Adiciona uma nova reuniao
        /// </summary>
        /// <returns>
        /// True ou False
        /// </returns>
        public bool addNewMeeting(int idType, int idOwner, DateTime start, int duration, String subject, String agenda, String invitedList)
        {
             return databaseService.WriteData("EXEC [dbo].[addMeeting] @idType = " + idType.ToString() + ", @idOwner = " + idOwner.ToString() + ", @startday = N'" + start.ToString("yyyy/MM/dd HH:mm") + "', @duration = " + duration + ", @subject = N'" + subject + "', @agenda = N'" + agenda + "', @inviteList = N'"+ invitedList + "'");
        }


        /// <summary>
        /// Guarda alteraçoes uma reuniao
        /// </summary>
        /// <returns>
        /// True ou False
        /// </returns>
        public bool saveMeeting(int idMeeting, int idType, DateTime start, int duration, String subject, String agenda, String invitedList, String minutes)
        {
            return databaseService.WriteData("EXEC [dbo].[saveMeeting] @idMeeting = " + idMeeting.ToString() + ", @idType = " + idType.ToString() + ", @startday = N'" + start.ToString("yyyy/MM/dd HH:mm") + "', @duration = " + duration + ", @subject = N'" + subject + "', @agenda = N'" + agenda + "', @inviteList = N'" + invitedList + "', @minutes = N'" + minutes + "'");
        }

        /// <summary>
        /// Remove todas as tarefas de uma reuniao
        /// </summary>
        /// <returns>
        /// True ou False
        /// </returns>
        public bool removeAllTasks(int idMeeting)
        {
            return databaseService.WriteData("DELETE FROM UserTask WHERE idMeeting = " + idMeeting.ToString());
        }

        /// <summary>
        /// Adiciona uma tarefa relacionada com um reuniao
        /// </summary>
        /// <returns>
        /// True ou False
        /// </returns>
        public bool addMeetingTask(int idMeeting, string taskOwner, string description, DateTime deadline)
        {
            return databaseService.WriteData("INSERT INTO[dbo].[UserTask] ([IdMeeting],[IdOwner],[Description],[Deadline]) VALUES (" + idMeeting.ToString() + "," + taskOwner.ToString() + ", '" + description + "','" + deadline.ToString("yyyy/MM/dd") + "')");
        }
    }
}
