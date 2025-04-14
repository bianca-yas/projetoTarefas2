namespace ProjetoTarefas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mensagem = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.excluirTaf = new System.Windows.Forms.Button();
            this.consultarTaf = new System.Windows.Forms.Button();
            this.editarTarefa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 79);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 35);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "MENU PRÍNCIPAL";
            // 
            // mensagem
            // 
            this.mensagem.BackColor = System.Drawing.Color.White;
            this.mensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagem.Location = new System.Drawing.Point(71, 160);
            this.mensagem.Multiline = true;
            this.mensagem.Name = "mensagem";
            this.mensagem.ReadOnly = true;
            this.mensagem.Size = new System.Drawing.Size(274, 213);
            this.mensagem.TabIndex = 8;
            this.mensagem.Text = "Seja bem-vindo à OrdoFlow, utilize nossa plataforma para o gerenciamento de suas " +
    "tarefas com mais facilidade e rapidez!";
            this.mensagem.TextChanged += new System.EventHandler(this.mensagem_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoTarefas.Properties.Resources.book;
            this.pictureBox2.Location = new System.Drawing.Point(130, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // excluirTaf
            // 
            this.excluirTaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.excluirTaf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.excluirTaf.FlatAppearance.BorderSize = 0;
            this.excluirTaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirTaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirTaf.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.excluirTaf.Image = global::ProjetoTarefas.Properties.Resources.icons8_trash_24;
            this.excluirTaf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirTaf.Location = new System.Drawing.Point(399, 334);
            this.excluirTaf.Name = "excluirTaf";
            this.excluirTaf.Size = new System.Drawing.Size(237, 50);
            this.excluirTaf.TabIndex = 5;
            this.excluirTaf.Text = "Excluir Tarefa";
            this.excluirTaf.UseVisualStyleBackColor = false;
            this.excluirTaf.Click += new System.EventHandler(this.excluirTaf_Click);
            // 
            // consultarTaf
            // 
            this.consultarTaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.consultarTaf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.consultarTaf.FlatAppearance.BorderSize = 0;
            this.consultarTaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarTaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarTaf.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.consultarTaf.Image = global::ProjetoTarefas.Properties.Resources.icons8_tasks_30;
            this.consultarTaf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultarTaf.Location = new System.Drawing.Point(399, 222);
            this.consultarTaf.Name = "consultarTaf";
            this.consultarTaf.Size = new System.Drawing.Size(237, 50);
            this.consultarTaf.TabIndex = 4;
            this.consultarTaf.Text = "Consultar Tarefa";
            this.consultarTaf.UseVisualStyleBackColor = false;
            this.consultarTaf.Click += new System.EventHandler(this.consultarTaf_Click);
            // 
            // editarTarefa
            // 
            this.editarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.editarTarefa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editarTarefa.FlatAppearance.BorderSize = 0;
            this.editarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarTarefa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.editarTarefa.Image = global::ProjetoTarefas.Properties.Resources.icons8_pencil_30;
            this.editarTarefa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editarTarefa.Location = new System.Drawing.Point(399, 278);
            this.editarTarefa.Name = "editarTarefa";
            this.editarTarefa.Size = new System.Drawing.Size(237, 50);
            this.editarTarefa.TabIndex = 3;
            this.editarTarefa.Text = "Editar Tarefa";
            this.editarTarefa.UseVisualStyleBackColor = false;
            this.editarTarefa.Click += new System.EventHandler(this.editarTarefa_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Image = global::ProjetoTarefas.Properties.Resources.icons8_plus_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(399, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = " Adicionar Tarefa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoTarefas.Properties.Resources.logo_trabalho_maior;
            this.pictureBox1.Location = new System.Drawing.Point(237, -123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 466);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mensagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.excluirTaf);
            this.Controls.Add(this.consultarTaf);
            this.Controls.Add(this.editarTarefa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editarTarefa;
        private System.Windows.Forms.Button consultarTaf;
        private System.Windows.Forms.Button excluirTaf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox mensagem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

