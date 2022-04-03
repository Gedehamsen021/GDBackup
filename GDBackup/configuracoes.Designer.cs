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
            this.label1 = new System.Windows.Forms.Label();
            this.box_diretorio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_ftp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_intervalo = new System.Windows.Forms.NumericUpDown();
            this.cmb_timer = new System.Windows.Forms.ComboBox();
            this.btn_diretorio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.box_script = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.box_scriptname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_usuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.box_senha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.box_oldpass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.box_newpass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.box_intervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(355, 384);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(355, 415);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diretorio FTP";
            // 
            // box_diretorio
            // 
            this.box_diretorio.Location = new System.Drawing.Point(89, 43);
            this.box_diretorio.Name = "box_diretorio";
            this.box_diretorio.Size = new System.Drawing.Size(339, 20);
            this.box_diretorio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Endereço FTP";
            // 
            // box_ftp
            // 
            this.box_ftp.Location = new System.Drawing.Point(89, 76);
            this.box_ftp.Name = "box_ftp";
            this.box_ftp.Size = new System.Drawing.Size(339, 20);
            this.box_ftp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Intervalo entre backups";
            // 
            // box_intervalo
            // 
            this.box_intervalo.Location = new System.Drawing.Point(139, 417);
            this.box_intervalo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.box_intervalo.Name = "box_intervalo";
            this.box_intervalo.Size = new System.Drawing.Size(46, 20);
            this.box_intervalo.TabIndex = 9;
            // 
            // cmb_timer
            // 
            this.cmb_timer.FormattingEnabled = true;
            this.cmb_timer.Items.AddRange(new object[] {
            "Minutos",
            "Horas"});
            this.cmb_timer.Location = new System.Drawing.Point(191, 417);
            this.cmb_timer.Name = "cmb_timer";
            this.cmb_timer.Size = new System.Drawing.Size(85, 21);
            this.cmb_timer.TabIndex = 10;
            this.cmb_timer.Text = "Horas";
            // 
            // btn_diretorio
            // 
            this.btn_diretorio.Location = new System.Drawing.Point(264, 385);
            this.btn_diretorio.Name = "btn_diretorio";
            this.btn_diretorio.Size = new System.Drawing.Size(85, 23);
            this.btn_diretorio.TabIndex = 11;
            this.btn_diretorio.Text = "DIRETORIOS";
            this.btn_diretorio.UseVisualStyleBackColor = true;
            this.btn_diretorio.Click += new System.EventHandler(this.btn_diretorio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(14, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Diretorio Script";
            // 
            // box_script
            // 
            this.box_script.Location = new System.Drawing.Point(89, 358);
            this.box_script.Name = "box_script";
            this.box_script.Size = new System.Drawing.Size(339, 20);
            this.box_script.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome do script";
            // 
            // box_scriptname
            // 
            this.box_scriptname.Location = new System.Drawing.Point(89, 387);
            this.box_scriptname.Name = "box_scriptname";
            this.box_scriptname.Size = new System.Drawing.Size(160, 20);
            this.box_scriptname.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Usuario FTP";
            // 
            // box_usuario
            // 
            this.box_usuario.Location = new System.Drawing.Point(89, 108);
            this.box_usuario.Name = "box_usuario";
            this.box_usuario.Size = new System.Drawing.Size(339, 20);
            this.box_usuario.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(15, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Senha FTP";
            // 
            // box_senha
            // 
            this.box_senha.Location = new System.Drawing.Point(89, 141);
            this.box_senha.Name = "box_senha";
            this.box_senha.PasswordChar = '*';
            this.box_senha.Size = new System.Drawing.Size(339, 20);
            this.box_senha.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(188, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "SISTEMA";
            // 
            // box_oldpass
            // 
            this.box_oldpass.Location = new System.Drawing.Point(85, 226);
            this.box_oldpass.Name = "box_oldpass";
            this.box_oldpass.Size = new System.Drawing.Size(345, 20);
            this.box_oldpass.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(200, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "FTP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(15, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Senha atual";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(15, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Nova senha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(188, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "SCRIPT";
            // 
            // box_newpass
            // 
            this.box_newpass.Location = new System.Drawing.Point(85, 259);
            this.box_newpass.Name = "box_newpass";
            this.box_newpass.Size = new System.Drawing.Size(343, 20);
            this.box_newpass.TabIndex = 26;
            // 
            // configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(440, 485);
            this.Controls.Add(this.box_newpass);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.box_oldpass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.box_senha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_usuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_scriptname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_script);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_diretorio);
            this.Controls.Add(this.cmb_timer);
            this.Controls.Add(this.box_intervalo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_ftp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_diretorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "configuracoes";
            this.Text = "configuracoes";
            ((System.ComponentModel.ISupportInitialize)(this.box_intervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_diretorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_ftp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_diretorio;
        public System.Windows.Forms.NumericUpDown box_intervalo;
        public System.Windows.Forms.ComboBox cmb_timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_script;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_scriptname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox box_senha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox box_oldpass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox box_newpass;
    }
}