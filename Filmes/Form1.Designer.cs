namespace Filmes
{
    partial class Form1
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
            this.cmbFilmes = new System.Windows.Forms.ComboBox();
            this.pnValidar = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.btnAsistirAgora = new System.Windows.Forms.Button();
            this.lblSaldacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.pnValidar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFilmes
            // 
            this.cmbFilmes.FormattingEnabled = true;
            this.cmbFilmes.Items.AddRange(new object[] {
            "O senhor dos neis ",
            "Divertidamente",
            "Megamente",
            "Bob esponja",
            "Homem aranha",
            "Capitao america",
            "Batman",
            "Pinoquio",
            "Zatura",
            "Robin"});
            this.cmbFilmes.Location = new System.Drawing.Point(26, 171);
            this.cmbFilmes.Name = "cmbFilmes";
            this.cmbFilmes.Size = new System.Drawing.Size(230, 21);
            this.cmbFilmes.TabIndex = 1;
            // 
            // pnValidar
            // 
            this.pnValidar.Controls.Add(this.btnAsistirAgora);
            this.pnValidar.Controls.Add(this.txtDataNascimento);
            this.pnValidar.Controls.Add(this.txtNome);
            this.pnValidar.Location = new System.Drawing.Point(12, 227);
            this.pnValidar.Name = "pnValidar";
            this.pnValidar.Size = new System.Drawing.Size(286, 162);
            this.pnValidar.TabIndex = 2;
            this.pnValidar.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(14, 101);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(230, 20);
            this.txtDataNascimento.TabIndex = 4;
            // 
            // btnAsistirAgora
            // 
            this.btnAsistirAgora.BackColor = System.Drawing.Color.Blue;
            this.btnAsistirAgora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistirAgora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsistirAgora.Location = new System.Drawing.Point(17, 136);
            this.btnAsistirAgora.Name = "btnAsistirAgora";
            this.btnAsistirAgora.Size = new System.Drawing.Size(95, 23);
            this.btnAsistirAgora.TabIndex = 4;
            this.btnAsistirAgora.Text = "Asistir Agora!";
            this.btnAsistirAgora.UseVisualStyleBackColor = false;
            this.btnAsistirAgora.Click += new System.EventHandler(this.btnAsistirAgora_Click);
            // 
            // lblSaldacao
            // 
            this.lblSaldacao.AutoSize = true;
            this.lblSaldacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldacao.Location = new System.Drawing.Point(20, 30);
            this.lblSaldacao.Name = "lblSaldacao";
            this.lblSaldacao.Size = new System.Drawing.Size(223, 33);
            this.lblSaldacao.TabIndex = 4;
            this.lblSaldacao.Text = "Bem vindo, ao ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "nosso app de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filmes";
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(414, 86);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(338, 303);
            this.pbImagem.TabIndex = 8;
            this.pbImagem.TabStop = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Blue;
            this.btnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinuar.Location = new System.Drawing.Point(26, 198);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaldacao);
            this.Controls.Add(this.pnValidar);
            this.Controls.Add(this.cmbFilmes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "ICinePlay";
            this.pnValidar.ResumeLayout(false);
            this.pnValidar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFilmes;
        private System.Windows.Forms.Panel pnValidar;
        private System.Windows.Forms.Button btnAsistirAgora;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSaldacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btnContinuar;
    }
}

