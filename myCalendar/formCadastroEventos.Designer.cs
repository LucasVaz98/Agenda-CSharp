namespace myCalendar
{
    partial class formCadastroEventos
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
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btInserirEvento = new System.Windows.Forms.Button();
            this.pDados.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDados
            // 
            this.pDados.Controls.Add(this.txtPriority);
            this.pDados.Controls.Add(this.txtStatus);
            this.pDados.Controls.Add(this.txtEndDate);
            this.pDados.Controls.Add(this.txtStartDate);
            this.pDados.Controls.Add(this.txtDate);
            this.pDados.Controls.Add(this.lblPriority);
            this.pDados.Controls.Add(this.lblStatus);
            this.pDados.Controls.Add(this.lblEndDate);
            this.pDados.Controls.Add(this.lblStartDate);
            this.pDados.Controls.Add(this.lblData);
            this.pDados.Controls.Add(this.lblDescription);
            this.pDados.Controls.Add(this.txtDescription);
            this.pDados.Controls.Add(this.txtId);
            this.pDados.Controls.Add(this.lblId);
            this.pDados.Location = new System.Drawing.Point(12, 12);
            this.pDados.Name = "pDados";
            this.pDados.Size = new System.Drawing.Size(660, 285);
            this.pDados.TabIndex = 0;
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(501, 182);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(100, 23);
            this.txtPriority.TabIndex = 13;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(129, 177);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 23);
            this.txtStatus.TabIndex = 12;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(477, 101);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 23);
            this.txtEndDate.TabIndex = 11;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(248, 101);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 23);
            this.txtStartDate.TabIndex = 10;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(53, 101);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 23);
            this.txtDate.TabIndex = 9;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(434, 190);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(61, 15);
            this.lblPriority.TabIndex = 8;
            this.lblPriority.Text = "Prioridade";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(84, 185);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(477, 81);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(108, 15);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "Data de Finalização";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(259, 81);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(79, 15);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Data de Início";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(84, 81);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 15);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(123, 13);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(58, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Descrição";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(187, 10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(470, 23);
            this.txtDescription.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(35, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(65, 23);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btCancelar);
            this.pMenu.Controls.Add(this.btSalvar);
            this.pMenu.Controls.Add(this.btExcluir);
            this.pMenu.Controls.Add(this.btAlterar);
            this.pMenu.Controls.Add(this.btLocalizar);
            this.pMenu.Controls.Add(this.btInserirEvento);
            this.pMenu.Location = new System.Drawing.Point(12, 303);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(660, 54);
            this.pMenu.TabIndex = 1;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(573, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(84, 43);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(464, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(84, 43);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(350, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(84, 43);
            this.btExcluir.TabIndex = 5;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(226, 3);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(84, 43);
            this.btAlterar.TabIndex = 4;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(109, 3);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(84, 43);
            this.btLocalizar.TabIndex = 3;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // btInserirEvento
            // 
            this.btInserirEvento.Location = new System.Drawing.Point(3, 3);
            this.btInserirEvento.Name = "btInserirEvento";
            this.btInserirEvento.Size = new System.Drawing.Size(84, 43);
            this.btInserirEvento.TabIndex = 2;
            this.btInserirEvento.Text = "Inserir";
            this.btInserirEvento.UseVisualStyleBackColor = true;
            this.btInserirEvento.Click += new System.EventHandler(this.btInserirEvento_Click);
            // 
            // formCadastroEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pDados);
            this.Name = "formCadastroEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.formCadastroContato_Load);
            this.pDados.ResumeLayout(false);
            this.pDados.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pDados;
        private Panel pMenu;
        private Button btInserirEvento;
        private Button btCancelar;
        private Button btSalvar;
        private Button btExcluir;
        private Button btAlterar;
        private Button btLocalizar;
        private Label lblId;
        private Label lblDescription;
        private TextBox txtDescription;
        private TextBox txtId;
        private Label lblPriority;
        private Label lblStatus;
        private Label lblEndDate;
        private Label lblStartDate;
        private Label lblData;
        private TextBox txtPriority;
        private TextBox txtStatus;
        private TextBox txtEndDate;
        private TextBox txtStartDate;
        private TextBox txtDate;
    }
}