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
    public partial class FormCadastroTarefa : Form
    {

        public string operacao = "";

        public FormCadastroTarefa()
        {
            InitializeComponent();
        }

        public void AlteraBotoes(int op)
        {
            pDados.Enabled = false;
            btSaveEvent.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExluir.Enabled = false;
            btInserirEvento.Enabled=false;

            if (op == 1) //create
            {
                pDados.Enabled = true;
                btInserirEvento.Enabled = true;
                btSaveEvent.Enabled = true;
            }
            if (op == 2) //read
            {
                pDados.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 3) //update
            {
                pDados.Enabled = true;
                btLocalizar.Enabled = true;
                btAlterar.Enabled = true;
            }
            if (op == 4) //delete
            {
                pDados.Enabled = true;
                btLocalizar.Enabled = true;
                btExluir.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Inserir Eventos
        {
            this.operacao = "Inserir Evento";
            this.AlteraBotoes(1);
        }

        private void button2_Click(object sender, EventArgs e) // Atualizar Eventos
        {
            this.operacao = "Atualiza Evento";
            this.AlteraBotoes(2);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroTarefa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
