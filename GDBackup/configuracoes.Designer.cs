namespace GDBackup
{
    partial class configuracoes
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
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_diretorio = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_ftp = new System.Windows.Forms.Button();
            this.btn_email = new System.Windows.Forms.Button();
            this.btn_sistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(12, 101);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(353, 101);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_diretorio
            // 
            this.btn_diretorio.Location = new System.Drawing.Point(270, 48);
            this.btn_diretorio.Name = "btn_diretorio";
            this.btn_diretorio.Size = new System.Drawing.Size(85, 23);
            this.btn_diretorio.TabIndex = 11;
            this.btn_diretorio.Text = "DIRETORIOS";
            this.btn_diretorio.UseVisualStyleBackColor = true;
            this.btn_diretorio.Click += new System.EventHandler(this.btn_diretorio_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(164, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "CONFIGURAÇÕES";
            // 
            // btn_ftp
            // 
            this.btn_ftp.Location = new System.Drawing.Point(177, 48);
            this.btn_ftp.Name = "btn_ftp";
            this.btn_ftp.Size = new System.Drawing.Size(85, 23);
            this.btn_ftp.TabIndex = 26;
            this.btn_ftp.Text = "FTP";
            this.btn_ftp.UseVisualStyleBackColor = true;
            this.btn_ftp.Click += new System.EventHandler(this.btn_ftp_Click);
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(86, 48);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(85, 23);
            this.btn_email.TabIndex = 27;
            this.btn_email.Text = "EMAIL";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // btn_sistema
            // 
            this.btn_sistema.Location = new System.Drawing.Point(177, 101);
            this.btn_sistema.Name = "btn_sistema";
            this.btn_sistema.Size = new System.Drawing.Size(85, 23);
            this.btn_sistema.TabIndex = 28;
            this.btn_sistema.Text = "SISTEMA";
            this.btn_sistema.UseVisualStyleBackColor = true;
            this.btn_sistema.Click += new System.EventHandler(this.btn_sistema_Click);
            // 
            // configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(440, 131);
            this.Controls.Add(this.btn_sistema);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.btn_ftp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_diretorio);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "configuracoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_diretorio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_ftp;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button btn_sistema;
    }
}