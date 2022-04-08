namespace GDBackup
{
    partial class cfg_ftp
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
            this.label9 = new System.Windows.Forms.Label();
            this.box_senha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.box_usuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_ftp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_diretorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.box_scriptname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.box_script = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_timer = new System.Windows.Forms.ComboBox();
            this.box_intervalo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box_intervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(197, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "FTP";
            // 
            // box_senha
            // 
            this.box_senha.Location = new System.Drawing.Point(86, 135);
            this.box_senha.Name = "box_senha";
            this.box_senha.PasswordChar = '*';
            this.box_senha.Size = new System.Drawing.Size(339, 20);
            this.box_senha.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Senha FTP";
            // 
            // box_usuario
            // 
            this.box_usuario.Location = new System.Drawing.Point(86, 102);
            this.box_usuario.Name = "box_usuario";
            this.box_usuario.Size = new System.Drawing.Size(339, 20);
            this.box_usuario.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Usuario FTP";
            // 
            // box_ftp
            // 
            this.box_ftp.Location = new System.Drawing.Point(86, 70);
            this.box_ftp.Name = "box_ftp";
            this.box_ftp.Size = new System.Drawing.Size(339, 20);
            this.box_ftp.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Endereço FTP";
            // 
            // box_diretorio
            // 
            this.box_diretorio.Location = new System.Drawing.Point(86, 37);
            this.box_diretorio.Name = "box_diretorio";
            this.box_diretorio.Size = new System.Drawing.Size(339, 20);
            this.box_diretorio.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Diretorio FTP";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(353, 279);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 33;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(353, 248);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 32;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(196, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "SCRIPT";
            // 
            // box_scriptname
            // 
            this.box_scriptname.Location = new System.Drawing.Point(89, 236);
            this.box_scriptname.Name = "box_scriptname";
            this.box_scriptname.Size = new System.Drawing.Size(160, 20);
            this.box_scriptname.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nome do script";
            // 
            // box_script
            // 
            this.box_script.Location = new System.Drawing.Point(89, 207);
            this.box_script.Name = "box_script";
            this.box_script.Size = new System.Drawing.Size(339, 20);
            this.box_script.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(14, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Diretorio Script";
            // 
            // cmb_timer
            // 
            this.cmb_timer.FormattingEnabled = true;
            this.cmb_timer.Items.AddRange(new object[] {
            "Minutos",
            "Horas"});
            this.cmb_timer.Location = new System.Drawing.Point(191, 266);
            this.cmb_timer.Name = "cmb_timer";
            this.cmb_timer.Size = new System.Drawing.Size(85, 21);
            this.cmb_timer.TabIndex = 36;
            this.cmb_timer.Text = "Horas";
            // 
            // box_intervalo
            // 
            this.box_intervalo.Location = new System.Drawing.Point(139, 266);
            this.box_intervalo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.box_intervalo.Name = "box_intervalo";
            this.box_intervalo.Size = new System.Drawing.Size(46, 20);
            this.box_intervalo.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Intervalo entre backups";
            // 
            // cfg_ftp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(432, 308);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.box_scriptname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_script);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_timer);
            this.Controls.Add(this.box_intervalo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.box_senha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_usuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_ftp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_diretorio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cfg_ftp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cfg_ftp";
            ((System.ComponentModel.ISupportInitialize)(this.box_intervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox box_senha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox box_usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_ftp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_diretorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox box_scriptname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_script;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmb_timer;
        public System.Windows.Forms.NumericUpDown box_intervalo;
        private System.Windows.Forms.Label label4;
    }
}