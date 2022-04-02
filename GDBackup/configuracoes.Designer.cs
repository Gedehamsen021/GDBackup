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
            ((System.ComponentModel.ISupportInitialize)(this.box_intervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(353, 199);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(353, 164);
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
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diretorio FTP";
            // 
            // box_diretorio
            // 
            this.box_diretorio.Location = new System.Drawing.Point(89, 26);
            this.box_diretorio.Name = "box_diretorio";
            this.box_diretorio.Size = new System.Drawing.Size(339, 20);
            this.box_diretorio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Endereço FTP";
            // 
            // box_ftp
            // 
            this.box_ftp.Location = new System.Drawing.Point(96, 78);
            this.box_ftp.Name = "box_ftp";
            this.box_ftp.Size = new System.Drawing.Size(332, 20);
            this.box_ftp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Intervalo entre backups";
            // 
            // box_intervalo
            // 
            this.box_intervalo.Location = new System.Drawing.Point(137, 197);
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
            this.cmb_timer.Location = new System.Drawing.Point(189, 197);
            this.cmb_timer.Name = "cmb_timer";
            this.cmb_timer.Size = new System.Drawing.Size(85, 21);
            this.cmb_timer.TabIndex = 10;
            this.cmb_timer.Text = "Horas";
            // 
            // btn_diretorio
            // 
            this.btn_diretorio.Location = new System.Drawing.Point(262, 165);
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
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Diretorio Script";
            // 
            // box_script
            // 
            this.box_script.Location = new System.Drawing.Point(96, 120);
            this.box_script.Name = "box_script";
            this.box_script.Size = new System.Drawing.Size(332, 20);
            this.box_script.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(14, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome do script";
            // 
            // box_scriptname
            // 
            this.box_scriptname.Location = new System.Drawing.Point(96, 167);
            this.box_scriptname.Name = "box_scriptname";
            this.box_scriptname.Size = new System.Drawing.Size(160, 20);
            this.box_scriptname.TabIndex = 15;
            // 
            // configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(440, 234);
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
    }
}