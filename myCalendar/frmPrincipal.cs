namespace myCalendar
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // This meant to be the first button, o botão criar nova tarefa
        {
            formCadastroEventos f = new formCadastroEventos();

            f.ShowDialog(); // exibir o fomruilário para o usuário
            f.Dispose(); // após fechar a janela com o formulário anterior, encerra ele para não acumular variáveis no programa
        }
    }
}