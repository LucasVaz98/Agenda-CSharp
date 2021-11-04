using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCalendar
{
    internal class Event
    {
        public Event()
        {
            this.Id = 1;
            this.Tittle = "";
            this.Description = "";
            this.Start_Date = DateTime.MinValue;
            this.End_Date = DateTime.MinValue;
            this.Date = DateTime.Today;
            this.Priority = 0;
            this.Status = 0;

        }
        public Event(int Id, string Tittle, string Description, DateTime Start_Date, DateTime End_Date, DateTime Date, int Priority, int Status)
        {
            this.Id = Id;
            this.Tittle = Tittle;
            this.Description = Description;
            this.Start_Date = Start_Date;
            this.End_Date = End_Date;
            this.Date=Date;
            this.Priority = Priority;
            this.Status = Status;
        }

        private int task_id;
        public int Id
        {
            get
            {
                return this.Id;
            }
            set 
            {
                this.Id = value;
            }
        }

        
        private string task_tittle;
        public string Tittle
        {
            get { return this.task_tittle; }
            set { this.task_tittle = value;}
        }

        private string task_description;
        public string Description 
        {
            get { return this.task_tittle; }
            set { this.task_tittle = value; }
        }

        private DateTime task_date;
        public DateTime Date
        {
            get { return this.task_date; }
            set { this.task_date = value; }
        }

        private DateTime task_start_date;
        public DateTime Start_Date
        {
            get { return this.task_start_date; }
            set { this.task_start_date = value; }
        }

        private DateTime task_end_date;
        public DateTime End_Date
        {
            get { return this.task_end_date; }
            set { this.task_end_date = value; }
        }

        private int task_priority;
        public int Priority
        {
            get { return this.task_priority; }
            set { this.task_priority = value; }
        }

        private int task_status;
        public int Status
        {
            get { return this.task_status; }
            set { this.task_status = value; }
        }
    }
}
