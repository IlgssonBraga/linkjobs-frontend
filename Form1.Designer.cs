
namespace LinkJobs_App
{
    partial class Form1
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
            this.txtNomeDeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblNomeDeUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.linklblEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.lblLinkJobs = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeDeUsuario
            // 
            this.txtNomeDeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeDeUsuario.Location = new System.Drawing.Point(331, 229);
            this.txtNomeDeUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeDeUsuario.Name = "txtNomeDeUsuario";
            this.txtNomeDeUsuario.Size = new System.Drawing.Size(260, 27);
            this.txtNomeDeUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Location = new System.Drawing.Point(331, 310);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(260, 27);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblNomeDeUsuario
            // 
            this.lblNomeDeUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeDeUsuario.AutoSize = true;
            this.lblNomeDeUsuario.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeDeUsuario.Location = new System.Drawing.Point(331, 198);
            this.lblNomeDeUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeDeUsuario.Name = "lblNomeDeUsuario";
            this.lblNomeDeUsuario.Size = new System.Drawing.Size(119, 21);
            this.lblNomeDeUsuario.TabIndex = 2;
            this.lblNomeDeUsuario.Text = "Nome de Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSenha.Location = new System.Drawing.Point(331, 275);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(51, 21);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConectar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.Location = new System.Drawing.Point(400, 369);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(117, 32);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // linklblEsqueciSenha
            // 
            this.linklblEsqueciSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linklblEsqueciSenha.AutoSize = true;
            this.linklblEsqueciSenha.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linklblEsqueciSenha.Location = new System.Drawing.Point(390, 429);
            this.linklblEsqueciSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklblEsqueciSenha.Name = "linklblEsqueciSenha";
            this.linklblEsqueciSenha.Size = new System.Drawing.Size(126, 20);
            this.linklblEsqueciSenha.TabIndex = 5;
            this.linklblEsqueciSenha.TabStop = true;
            this.linklblEsqueciSenha.Text = "Esqueci minha senha";
            // 
            // lblLinkJobs
            // 
            this.lblLinkJobs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLinkJobs.BackColor = System.Drawing.Color.Yellow;
            this.lblLinkJobs.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLinkJobs.Location = new System.Drawing.Point(346, 74);
            this.lblLinkJobs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinkJobs.Name = "lblLinkJobs";
            this.lblLinkJobs.Size = new System.Drawing.Size(234, 65);
            this.lblLinkJobs.TabIndex = 6;
            this.lblLinkJobs.Text = "LinkJobs";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.Location = new System.Drawing.Point(428, 476);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(63, 20);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "V 0.0.0.1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(936, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 20);
            this.toolStripStatusLabel1.Text = "StatusBar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 595);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblLinkJobs);
            this.Controls.Add(this.linklblEsqueciSenha);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNomeDeUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNomeDeUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeDeUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblNomeDeUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.LinkLabel linklblEsqueciSenha;
        private System.Windows.Forms.Label lblLinkJobs;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

