namespace myCalendar
{
    partial class formPrincipal : Form
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
            this.SuspendLayout();
            // 
            // btCreateNewEvent
            // 
            this.btCreateNewEvent.Location = new System.Drawing.Point(72, 42);
            this.btCreateNewEvent.Name = "btCreateNewEvent";
            this.btCreateNewEvent.Size = new System.Drawing.Size(230, 107);
            this.btCreateNewEvent.TabIndex = 0;
            this.btCreateNewEvent.Text = "Criar Evento";
            this.btCreateNewEvent.UseVisualStyleBackColor = true;
            this.btCreateNewEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btCreateNewEvent);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda 2022";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btCreateNewEvent;
    }
}