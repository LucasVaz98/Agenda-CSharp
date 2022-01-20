using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalendar
{
    
    public partial class formCadastroEventos : Form
    {
        public string operacao = "";
        public formCadastroEventos()
        {
            InitializeComponent();
        }

        public void Altera_botoes(int op)
        {
            pDados.Enabled = false; 
            pMenu.Enabled = true;
            btAlterar.Enabled = false;
            btCancelar.Enabled = false;
            btExcluir.Enabled = false;
            btInserirEvento.Enabled = false;
            btLocalizar.Enabled = false;
            btSalvar.Enabled = false;

            if(op == 1) // initiallize the form, waitin if user want to insert new event, or cancel operation
            {
                btCancelar.Enabled = true;
                btInserirEvento.Enabled = true;

                btAlterar.Enabled = false;
                btLocalizar.Enabled = false;
                btExcluir.Enabled = false;
                btSalvar.Enabled = false;
            }
            if (op == 2) //if he wants to insert a new event, enable pDados, save and cancel button
            {
                pDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;

                btAlterar.Enabled = false;
                btExcluir.Enabled = false;
                btInserirEvento.Enabled = false;
                btLocalizar.Enabled = false;
            }
            if (op == 3)
            {
                btExcluir.Enabled = true;
                btAlterar.Enabled = true;
            }
            if (op == 4)
            {
            
            }
            if (op == 5)
            {
            
            }
            if (op == 6)
            {
                // this.Close(); //this just close the for
            }
        }
        
        public void Limpa_campos()
        {
            txtId.Clear();
            txtDescription.Clear();
            txtDate.Clear();
            txtStartDate.Clear();
            txtEndDate.Clear();
            txtPriority.Clear();
            txtStatus.Clear();
        }

        private void formCadastroContato_Load(object sender, EventArgs e)
        {
            this.Altera_botoes(1);
        }

        private void btInserirEvento_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.Altera_botoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //this.Altera_botoes(6); // it's just a different way to do this
            this.Altera_botoes(1);
            Limpa_campos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Evento myNewEvent = new Evento();


            myNewEvent.Description = txtDescription.Text;
            myNewEvent.Date = DateTime.ParseExact(txtDate.Text, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            myNewEvent.Start_time = DateTime.ParseExact(txtStartDate.Text, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            myNewEvent.End_time = DateTime.ParseExact(txtEndDate.Text, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            myNewEvent.Priority = Convert.ToInt32(txtPriority.Text);
            myNewEvent.Status = Convert.ToInt32(txtStatus.Text);

            // insert a new register in database
            String strConexao = "Data Source=(LocalDb)\\Agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            Conexao conexao = new Conexao(strConexao);
            DALEvento DALEvento = new DALEvento(conexao);

            if (this.operacao == "inserir")
            {
                DALEvento.Incluir(myNewEvent);
                MessageBox.Show("Código gerado foi: " + myNewEvent.Id.ToString());
 /*               
                try
                {
                    conexao.Conectar();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }*/
            }
            else
            {
                myNewEvent.Id = Convert.ToInt32(txtId.Text);
            }
        }
    }
}
