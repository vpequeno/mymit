using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using MyMit.controller;
using MyMit.model;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace MyMit.services
{
    class PdfService
    {
        PdfDocument document = null;
        private MeetingController controller = null;

        public PdfService()
        {

            // Instancia a classe controller
            this.controller = new MeetingController();
        }

        public void getMeetingSummary(string meeting_subject, List<MeetingInvite> guestList, string agenda, string meeting_minutes)
        {
            // Cria um novo PDF
            this.document = new PdfDocument();
            document.Info.Title = meeting_subject;

            // Cria uma pagina em branco
            PdfPage page = document.AddPage();

            // Cria um objeto XGraphics para dezenho
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font_title = new XFont("Verdana", 20, XFontStyle.BoldItalic);
            XFont font_subtitle = new XFont("Verdana", 17, XFontStyle.Underline);
            XFont font_body = new XFont("Verdana", 15, XFontStyle.Regular);

            // Titulo
            gfx.DrawString(meeting_subject, font_title, XBrushes.DarkSlateGray, 0, 30);

            // Lista de presentes
            gfx.DrawString("Guests:", font_subtitle, XBrushes.DarkSlateGray, 0, 70);

            int line_position = 70; // controla a posiçao vertical de cada linha, sendo que o espaco entre inhas é de 30
            List<User> users = controller.getUserList();
            for (int i = 0; i < users.Count; i++)
            {
                int id = users.ElementAt(i).id;
                string name = users.ElementAt(i).name;

                for (int j = 0; j < guestList.Count; j++)
                {
                    if (id == ((MeetingInvite)guestList.ElementAt(j)).idUser)
                    {
                        string user_attended_meeting = "Faltou";
                        if(((MeetingInvite)guestList.ElementAt(j)).attended)
                            user_attended_meeting = "Presente";

                        line_position = line_position+30;
                        gfx.DrawString(" - " + name + " ("+ user_attended_meeting + ")", font_body, XBrushes.DarkSlateGray, 0, line_position);
                    }

                }
            }

            // Linha em branco
            line_position = line_position + 30;
            gfx.DrawString(" ", font_body, XBrushes.DarkSlateGray, 0, line_position);

            // Agenda
            line_position = line_position + 30;
            gfx.DrawString("Agenda:", font_subtitle, XBrushes.DarkSlateGray, 0, line_position);

            line_position = line_position + 30;
            gfx.DrawString(agenda, font_body, XBrushes.DarkSlateGray, 0, line_position);


            // AgeMeeting Minutesnda
            line_position = line_position + 30;
            gfx.DrawString("Minutes:", font_subtitle, XBrushes.DarkSlateGray, 0, line_position);

            line_position = line_position + 30;
            gfx.DrawString(meeting_minutes, font_body, XBrushes.DarkSlateGray, 0, line_position);


            // Guarda o documento
            const string filename = "MeetingSummary.pdf";
            document.Save(filename);

            // Abre o documento
            Process.Start(filename);
        }

        public void getAttendeeList(string meeting_subject, List<MeetingInvite> guestList)
        {
            // Cria um novo PDF
            this.document = new PdfDocument();
            document.Info.Title = meeting_subject;

            // Cria uma pagina em branco
            PdfPage page = document.AddPage();

            // Cria um objeto XGraphics para dezenho
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font_title = new XFont("Verdana", 20, XFontStyle.BoldItalic);
            XFont font_subtitle = new XFont("Verdana", 17, XFontStyle.Underline);
            XFont font_body = new XFont("Verdana", 15, XFontStyle.Regular);

            // Titulo
            gfx.DrawString(meeting_subject, font_title, XBrushes.DarkSlateGray, 0, 30);

            // Lista de presentes
            gfx.DrawString("Attendance List:", font_subtitle, XBrushes.DarkSlateGray, 0, 70);

            int line_position = 70; // controla a posiçao vertical de cada linha, sendo que o espaco entre inhas é de 30
            List<User> users = controller.getUserList();
            for (int i = 0; i < users.Count; i++)
            {
                int id = users.ElementAt(i).id;
                string name = users.ElementAt(i).name;

                for (int j = 0; j < guestList.Count; j++)
                {
                    line_position = line_position + 30;
                    gfx.DrawString(name+" ____________________________________________________-", font_body, XBrushes.DarkSlateGray, 0, line_position);

                }
            }



            // Guarda o documento
            const string filename = "AttendeeList.pdf";
            document.Save(filename);

            // Abre o documento
            Process.Start(filename);
        }


    }
}
