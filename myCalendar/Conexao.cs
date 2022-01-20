using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Scaffold-DbContext "Data Source=(LocalDb)\Agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" Microsoft.EntityFrameworkCore.SqlServer
 */ 

namespace myCalendar
{
    class Conexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;
        //transaction

        public Conexao(String dadosConexao)
        {
            this._conexao = new SqlConnection();
            this.StringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }

        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value;  }
        }

        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
