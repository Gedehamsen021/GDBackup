namespace GDBackup
{
    partial class cfg_email
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
            this.label4 = new System.Windows.Forms.Label();
            this.box_mailPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.box_mailUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_smtp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.box_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.box_receiver = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_smtp_port = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.box_utiliza_email = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Senha";
            // 
            // box_mailPass
            // 
            this.box_mailPass.Location = new System.Drawing.Point(82, 102);
            this.box_mailPass.Name = "box_mailPass";
            this.box_mailPass.PasswordChar = '*';
            this.box_mailPass.Size = new System.Drawing.Size(343, 20);
            this.box_mailPass.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Usuario";
            // 
            // box_mailUser
            // 
            this.box_mailUser.Location = new System.Drawing.Point(82, 76);
            this.box_mailUser.Name = "box_mailUser";
            this.box_mailUser.Size = new System.Drawing.Size(343, 20);
            this.box_mailUser.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Smtp";
            // 
            // box_smtp
            // 
            this.box_smtp.Location = new System.Drawing.Point(82, 25);
            this.box_smtp.Name = "box_smtp";
            this.box_smtp.Size = new System.Drawing.Size(343, 20);
            this.box_smtp.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "EMAIL";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(350, 217);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 47;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(350, 186);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 46;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(24, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Cliente";
            // 
            // box_cliente
            // 
            this.box_cliente.Location = new System.Drawing.Point(82, 160);
            this.box_cliente.Name = "box_cliente";
            this.box_cliente.Size = new System.Drawing.Size(343, 20);
            this.box_cliente.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(24, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Email recebedor";
            // 
            // box_receiver
            // 
            this.box_receiver.Location = new System.Drawing.Point(113, 130);
            this.box_receiver.Name = "box_receiver";
            this.box_receiver.Size = new System.Drawing.Size(312, 20);
            this.box_receiver.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(24, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Smtp porta";
            // 
            // box_smtp_port
            // 
            this.box_smtp_port.Location = new System.Drawing.Point(82, 50);
            this.box_smtp_port.Name = "box_smtp_port";
            this.box_smtp_port.Size = new System.Drawing.Size(65, 20);
            this.box_smtp_port.TabIndex = 54;
            this.box_smtp_port.TextChanged += new System.EventHandler(this.box_smtp_port_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(24, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Utiliza email";
            // 
            // box_utiliza_email
            // 
            this.box_utiliza_email.AutoSize = true;
            this.box_utiliza_email.Location = new System.Drawing.Point(93, 222);
            this.box_utiliza_email.Name = "box_utiliza_email";
            this.box_utiliza_email.Size = new System.Drawing.Size(15, 14);
            this.box_utiliza_email.TabIndex = 57;
            this.box_utiliza_email.UseVisualStyleBackColor = true;
            // 
            // cfg_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(450, 252);
            this.Controls.Add(this.box_utiliza_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_smtp_port);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.box_receiver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_cliente);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_mailPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.box_mailUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_smtp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cfg_email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cfg_email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_mailPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_mailUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_smtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox box_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox box_receiver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_smtp_port;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox box_utiliza_email;
    }
}