using System;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace myCalendar
{
    class DALContato
    {
        private Conexao objConnection;

        public DALContato(Conexao conexao)
        {
            objConnection = conexao;
        }

        public void Incluir(Evento evento)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConnection.ObjetoConexao;
            cmd.CommandText = "insert into Events (task_tittle, task_description, task_date, task_start_date, task_end_date, task_priority, task_status)"+
                              "values (@tittle, @description, @date, @start_date, @end_date, @prioriy, @status" +
                              "); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@tittle", evento.Tittle);
            cmd.Parameters.AddWithValue("@description", evento.Description);
            cmd.Parameters.AddWithValue("@date", evento.Date);
            cmd.Parameters.AddWithValue("@start_date", evento.Start_time);
            cmd.Parameters.AddWithValue("@end_date", evento.End_time);
            cmd.Parameters.AddWithValue("@prioriy", evento.Priority);
            cmd.Parameters.AddWithValue("@status", evento.Status);
            objConnection.Conectar();
            evento.Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
