namespace myCalendar
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // This meant to be the first button, o bot�o criar nova tarefa
        {
            formCadastroEventos f = new formCadastroEventos();

            f.ShowDialog(); // exibir o fomruil�rio para o usu�rio
            f.Dispose(); // ap�s fechar a janela com o formul�rio anterior, encerra ele para n�o acumular vari�veis no programa
        }
    }
}