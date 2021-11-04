namespace myCalendar
{
    partial class FormCadastroTarefa : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pDados = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPrioridade = new System.Windows.Forms.TextBox();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.txtHoraFinal = new System.Windows.Forms.TextBox();
            this.lblHoraFinal = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btInserirEvento = new System.Windows.Forms.Button();
            this.btExluir = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btSaveEvent = new System.Windows.Forms.Button();
            this.pDados.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDados
            // 
            this.pDados.Controls.Add(this.txtStatus);
            this.pDados.Controls.Add(this.lblStatus);
            this.pDados.Controls.Add(this.txtPrioridade);
            this.pDados.Controls.Add(this.lblPrioridade);
            this.pDados.Controls.Add(this.txtHoraFinal);
            this.pDados.Controls.Add(this.lblHoraFinal);
            this.pDados.Controls.Add(this.txtHoraInicio);
            this.pDados.Controls.Add(this.lblHoraInicio);
            this.pDados.Controls.Add(this.txtData);
            this.pDados.Controls.Add(this.lblData);
            this.pDados.Controls.Add(this.txtDescricao);
            this.pDados.Controls.Add(this.lblDescricao);
            this.pDados.Controls.Add(this.txttitulo);
            this.pDados.Controls.Add(this.lblTitulo);
            this.pDados.Location = new System.Drawing.Point(0, 0);
            this.pDados.Name = "pDados";
            this.pDados.Size = new System.Drawing.Size(879, 345);
            this.pDados.TabIndex = 0;
            this.pDados.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(267, 286);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(195, 23);
            this.txtStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(267, 268);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // txtPrioridade
            // 
            this.txtPrioridade.Location = new System.Drawing.Point(12, 286);
            this.txtPrioridade.Name = "txtPrioridade";
            this.txtPrioridade.Size = new System.Drawing.Size(195, 23);
            this.txtPrioridade.TabIndex = 11;
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Location = new System.Drawing.Point(12, 268);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(61, 15);
            this.lblPrioridade.TabIndex = 10;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.Location = new System.Drawing.Point(267, 201);
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.Size = new System.Drawing.Size(195, 23);
            this.txtHoraFinal.TabIndex = 9;
            // 
            // lblHoraFinal
            // 
            this.lblHoraFinal.AutoSize = true;
            this.lblHoraFinal.Location = new System.Drawing.Point(267, 183);
            this.lblHoraFinal.Name = "lblHoraFinal";
            this.lblHoraFinal.Size = new System.Drawing.Size(56, 15);
            this.lblHoraFinal.TabIndex = 8;
            this.lblHoraFinal.Text = "Hora Fim";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(12, 201);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(195, 23);
            this.txtHoraInicio.TabIndex = 7;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(12, 183);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(65, 15);
            this.lblHoraInicio.TabIndex = 6;
            this.lblHoraInicio.Text = "Hora início";
            this.lblHoraInicio.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 151);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(450, 23);
            this.txtData.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 133);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 15);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 94);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(850, 23);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 76);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Click += new System.EventHandler(this.label3_Click);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(12, 40);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(141, 23);
            this.txttitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(37, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btInserirEvento);
            this.pMenu.Controls.Add(this.btExluir);
            this.pMenu.Controls.Add(this.btLocalizar);
            this.pMenu.Controls.Add(this.btAlterar);
            this.pMenu.Controls.Add(this.btSaveEvent);
            this.pMenu.Location = new System.Drawing.Point(0, 351);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(879, 113);
            this.pMenu.TabIndex = 1;
            // 
            // btInserirEvento
            // 
            this.btInserirEvento.Location = new System.Drawing.Point(596, 20);
            this.btInserirEvento.Name = "btInserirEvento";
            this.btInserirEvento.Size = new System.Drawing.Size(126, 68);
            this.btInserirEvento.TabIndex = 4;
            this.btInserirEvento.Text = "Inserir Evento";
            this.btInserirEvento.UseVisualStyleBackColor = true;
            this.btInserirEvento.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExluir
            // 
            this.btExluir.Location = new System.Drawing.Point(453, 20);
            this.btExluir.Name = "btExluir";
            this.btExluir.Size = new System.Drawing.Size(126, 68);
            this.btExluir.TabIndex = 3;
            this.btExluir.Text = "Excluir Evento";
            this.btExluir.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(306, 20);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(126, 68);
            this.btLocalizar.TabIndex = 2;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(157, 20);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(126, 68);
            this.btAlterar.TabIndex = 1;
            this.btAlterar.Text = "Alterar Evento";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btSaveEvent
            // 
            this.btSaveEvent.Location = new System.Drawing.Point(3, 20);
            this.btSaveEvent.Name = "btSaveEvent";
            this.btSaveEvent.Size = new System.Drawing.Size(126, 68);
            this.btSaveEvent.TabIndex = 0;
            this.btSaveEvent.Text = "Salvar Evento";
            this.btSaveEvent.UseVisualStyleBackColor = true;
            // 
            // FormCadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pDados);
            this.Name = "FormCadastroTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tarefas";
            this.Load += new System.EventHandler(this.FormCadastroTarefa_Load);
            this.pDados.ResumeLayout(false);
            this.pDados.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pDados;
        private Panel pMenu;
        private Button btInserirEvento;
        private Button btExluir;
        private Button btLocalizar;
        private Button btAlterar;
        private Button btSaveEvent;
        private Label lblTitulo;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txttitulo;
        private TextBox txtHoraFinal;
        private Label lblHoraFinal;
        private TextBox txtHoraInicio;
        private Label lblHoraInicio;
        private TextBox txtData;
        private Label lblData;
        private TextBox txtStatus;
        private Label lblStatus;
        private TextBox txtPrioridade;
        private Label lblPrioridade;
    }
}