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
            this.button1 = new System.Windows.Forms.Button();
            this.editarTarefa = new System.Windows.Forms.Button();
            this.consultarTaf = new System.Windows.Forms.Button();
            this.excluirTaf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 71);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 35);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(103, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "1. Adicionar Tarefa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editarTarefa
            // 
            this.editarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.editarTarefa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editarTarefa.FlatAppearance.BorderSize = 0;
            this.editarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarTarefa.ForeColor = System.Drawing.Color.White;
            this.editarTarefa.Location = new System.Drawing.Point(376, 184);
            this.editarTarefa.Name = "editarTarefa";
            this.editarTarefa.Size = new System.Drawing.Size(198, 65);
            this.editarTarefa.TabIndex = 3;
            this.editarTarefa.Text = "2. Editar Tarefa";
            this.editarTarefa.UseVisualStyleBackColor = false;
            this.editarTarefa.Click += new System.EventHandler(this.editarTarefa_Click);
            // 
            // consultarTaf
            // 
            this.consultarTaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.consultarTaf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.consultarTaf.FlatAppearance.BorderSize = 0;
            this.consultarTaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarTaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarTaf.ForeColor = System.Drawing.Color.White;
            this.consultarTaf.Location = new System.Drawing.Point(103, 275);
            this.consultarTaf.Name = "consultarTaf";
            this.consultarTaf.Size = new System.Drawing.Size(198, 65);
            this.consultarTaf.TabIndex = 4;
            this.consultarTaf.Text = "3. Consultar Tarefa";
            this.consultarTaf.UseVisualStyleBackColor = false;
            this.consultarTaf.Click += new System.EventHandler(this.consultarTaf_Click);
            // 
            // excluirTaf
            // 
            this.excluirTaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.excluirTaf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.excluirTaf.FlatAppearance.BorderSize = 0;
            this.excluirTaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirTaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirTaf.ForeColor = System.Drawing.Color.White;
            this.excluirTaf.Location = new System.Drawing.Point(376, 275);
            this.excluirTaf.Name = "excluirTaf";
            this.excluirTaf.Size = new System.Drawing.Size(198, 65);
            this.excluirTaf.TabIndex = 5;
            this.excluirTaf.Text = "4. Excluir Tarefa";
            this.excluirTaf.UseVisualStyleBackColor = false;
            this.excluirTaf.Click += new System.EventHandler(this.excluirTaf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "MENU PRÍNCIPAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.BackgroundImage = global::ProjetoTarefas.Properties.Resources.logo_trabalho1;
            this.pictureBox1.Image = global::ProjetoTarefas.Properties.Resources.logo_trabalho_maior;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(175, -91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.excluirTaf);
            this.Controls.Add(this.consultarTaf);
            this.Controls.Add(this.editarTarefa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

