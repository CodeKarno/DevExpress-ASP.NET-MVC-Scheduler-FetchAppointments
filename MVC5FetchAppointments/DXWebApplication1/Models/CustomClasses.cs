using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXWebApplication1.Models {
    public class CustomAppointment {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Subject { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public int Label { get; set; }
        public string Location { get; set; }
        public bool AllDay { get; set; }
        public int EventType { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public int OwnerId { get; set; }
        public int ID { get; set; }

        public string CustomInfo { get; set; }

        public CustomAppointment() {
        }

        public static CustomAppointment CreateCustomAppointment(string subject, object resourceId, int status, int label, int id, DateTime start, DateTime end) {
            CustomAppointment apt = new CustomAppointment();
            apt.ID = id;
            apt.Subject = subject;
            apt.OwnerId = Convert.ToInt32(resourceId);
            apt.StartTime = start;
            apt.EndTime = end;
            apt.Status = status;
            apt.Label = label;
            return apt;
        }
    }
    public class CustomResource {
        public string Name { get; set; }
        public int ResID { get; set; }
        public int Color { get; set; }

        public CustomResource() {

        }

        public static CustomResource CreateCustomResource(int res_id, string caption, int ResColor) {
            CustomResource cr = new CustomResource();
            cr.ResID = res_id;
            cr.Name = caption;
            cr.Color = ResColor;
            return cr;
        }

    }

    public class SchedulerDataObject {
        public List<CustomAppointment> Appointments { get; set; }
        public FetchAppointmentsMethod FetchAppointments { get; set; }
        public List<CustomResource> Resources { get; set; }
    }
}