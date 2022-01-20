using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCalendar
{
    public class Evento
    {
        // isso é um construtor, que está inicializando os campos daminha classe com os valores padrões
        public Evento()
        {
            this.Id = 0;
            this.Tittle = "";
            this.Description = "";
            this.Date = new DateTime();
            this.Start_time = new DateTime();
            this.End_time = new DateTime();
            this.Priority = 0;
            this.Status = 0;
        }

        //Aqui estou atribuindo os valores para cada campo da classe Evento que criei em um outro construtor
        public Evento(int id, string tittle, string description, DateTime date, DateTime start_date, DateTime end_date, int status, int priority)
        {
            this.Id = id;
            this.Tittle = tittle;
            this.Description = description;
            this.Date = date;
            this.Start_time = start_date;
            this.End_time = end_date;
            this.Status = status;
            this.Priority = priority;
        }


        private int evnt_id;
        public int Id
        {
            get { return this.evnt_id; }
            set { this.evnt_id = value; }
        }

        private string evnt_tittle;
        public string Tittle
        {
            get { return this.evnt_tittle; }
            set { this.evnt_tittle = value; }
        }

        private string evnt_description;
        public string Description
        {
            get { return this.evnt_description; }
            set { this.evnt_description = value; }
        }

        private DateTime evnt_date;
        public DateTime Date
        {
            get { return this.evnt_date; }
            set { this.evnt_date = value; }
        }

        private DateTime evnt_start_time;
        public DateTime Start_time
        {
            get { return this.evnt_start_time; }
            set { this.evnt_start_time = value; }
        }

        private DateTime evnt_end_time;
        public DateTime End_time
        {
            get { return this.evnt_end_time; }
            set { this.evnt_end_time = value; }
        }

        private int evnt_priority;
        public int Priority
        {
            get { return this.evnt_priority; }
            set { this.evnt_priority = value; }
        }

        private int evnt_status;
        public int Status
        {
            get { return this.evnt_status; }
            set { this.evnt_status = value; }
        }

    }
}
