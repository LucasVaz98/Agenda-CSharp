namespace myCalendar
{
    partial class FormPrincipal : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCreateNewEvent = new System.Windows.Forms.Button();
            this.btConsultEvent = new System.Windows.Forms.Button();
            this.btUpdateEvent = new System.Windows.Forms.Button();
            this.btDeleteEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCreateNewEvent
            // 
            this.btCreateNewEvent.Location = new System.Drawing.Point(94, 103);
            this.btCreateNewEvent.Name = "btCreateNewEvent";
            this.btCreateNewEvent.Size = new System.Drawing.Size(230, 107);
            this.btCreateNewEvent.TabIndex = 0;
            this.btCreateNewEvent.Text = "Criar novo evento";
            this.btCreateNewEvent.UseVisualStyleBackColor = true;
            this.btCreateNewEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // btConsultEvent
            // 
            this.btConsultEvent.Location = new System.Drawing.Point(447, 103);
            this.btConsultEvent.Name = "btConsultEvent";
            this.btConsultEvent.Size = new System.Drawing.Size(230, 107);
            this.btConsultEvent.TabIndex = 1;
            this.btConsultEvent.Text = "Consultar eventos";
            this.btConsultEvent.UseVisualStyleBackColor = true;
            this.btConsultEvent.Click += new System.EventHandler(this.button2_Click);
            // 
            // btUpdateEvent
            // 
            this.btUpdateEvent.Location = new System.Drawing.Point(94, 251);
            this.btUpdateEvent.Name = "btUpdateEvent";
            this.btUpdateEvent.Size = new System.Drawing.Size(230, 107);
            this.btUpdateEvent.TabIndex = 2;
            this.btUpdateEvent.Text = "Atualizar evento";
            this.btUpdateEvent.UseVisualStyleBackColor = true;
            this.btUpdateEvent.Click += new System.EventHandler(this.button3_Click);
            // 
            // btDeleteEvent
            // 
            this.btDeleteEvent.Location = new System.Drawing.Point(447, 251);
            this.btDeleteEvent.Name = "btDeleteEvent";
            this.btDeleteEvent.Size = new System.Drawing.Size(230, 107);
            this.btDeleteEvent.TabIndex = 3;
            this.btDeleteEvent.Text = "Apagar evento";
            this.btDeleteEvent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btDeleteEvent);
            this.Controls.Add(this.btUpdateEvent);
            this.Controls.Add(this.btConsultEvent);
            this.Controls.Add(this.btCreateNewEvent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Calendar";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btCreateNewEvent;
        private Button btConsultEvent;
        private Button btUpdateEvent;
        private Button btDeleteEvent;
    }
}