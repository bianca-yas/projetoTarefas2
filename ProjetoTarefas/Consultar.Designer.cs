﻿namespace ProjetoTarefas
{
    partial class Consultar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voltar = new System.Windows.Forms.Button();
            this.marcar = new System.Windows.Forms.Button();
            this.filt = new System.Windows.Forms.Button();
            this.filt2 = new System.Windows.Forms.Button();
            this.comboBoxP = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.busca1 = new System.Windows.Forms.Button();
            this.ajuda = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(792, 79);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(0, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 35);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "CONSULTAR TAREFAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 188);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.voltar.FlatAppearance.BorderSize = 0;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.voltar.Location = new System.Drawing.Point(299, 360);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(111, 40);
            this.voltar.TabIndex = 26;
            this.voltar.Text = "VOLTAR";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // marcar
            // 
            this.marcar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.marcar.FlatAppearance.BorderSize = 0;
            this.marcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.marcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcar.ForeColor = System.Drawing.Color.White;
            this.marcar.Location = new System.Drawing.Point(72, 360);
            this.marcar.Name = "marcar";
            this.marcar.Size = new System.Drawing.Size(211, 40);
            this.marcar.TabIndex = 27;
            this.marcar.Text = "CONCLUIR TAREFA";
            this.marcar.UseVisualStyleBackColor = false;
            this.marcar.Click += new System.EventHandler(this.marcar_Click);
            // 
            // filt
            // 
            this.filt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.filt.FlatAppearance.BorderSize = 0;
            this.filt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filt.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.filt.Location = new System.Drawing.Point(682, 157);
            this.filt.Name = "filt";
            this.filt.Size = new System.Drawing.Size(96, 23);
            this.filt.TabIndex = 28;
            this.filt.Text = "Filtrar Prioridade";
            this.filt.UseVisualStyleBackColor = false;
            this.filt.Click += new System.EventHandler(this.filt_Click);
            // 
            // filt2
            // 
            this.filt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.filt2.FlatAppearance.BorderSize = 0;
            this.filt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filt2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.filt2.Location = new System.Drawing.Point(682, 186);
            this.filt2.Name = "filt2";
            this.filt2.Size = new System.Drawing.Size(96, 23);
            this.filt2.TabIndex = 29;
            this.filt2.Text = "Filtrar Status";
            this.filt2.UseVisualStyleBackColor = false;
            this.filt2.Click += new System.EventHandler(this.filt2_Click);
            // 
            // comboBoxP
            // 
            this.comboBoxP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxP.FormattingEnabled = true;
            this.comboBoxP.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.comboBoxP.Location = new System.Drawing.Point(627, 157);
            this.comboBoxP.Name = "comboBoxP";
            this.comboBoxP.Size = new System.Drawing.Size(49, 24);
            this.comboBoxP.TabIndex = 30;
            this.comboBoxP.SelectedIndexChanged += new System.EventHandler(this.comboBoxP_SelectedIndexChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Concluída",
            "Pendente"});
            this.comboBoxStatus.Location = new System.Drawing.Point(627, 186);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(49, 24);
            this.comboBoxStatus.TabIndex = 31;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Location = new System.Drawing.Point(668, 216);
            this.textBoxBusca.Multiline = true;
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(55, 35);
            this.textBoxBusca.TabIndex = 34;
            this.textBoxBusca.TextChanged += new System.EventHandler(this.textBoxBusca_TextChanged);
            // 
            // busca1
            // 
            this.busca1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.busca1.FlatAppearance.BorderSize = 0;
            this.busca1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.busca1.Image = global::ProjetoTarefas.Properties.Resources.icons8_search_30;
            this.busca1.Location = new System.Drawing.Point(627, 216);
            this.busca1.Name = "busca1";
            this.busca1.Size = new System.Drawing.Size(35, 35);
            this.busca1.TabIndex = 35;
            this.busca1.UseVisualStyleBackColor = false;
            this.busca1.Click += new System.EventHandler(this.busca1_Click);
            // 
            // ajuda
            // 
            this.ajuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ajuda.FlatAppearance.BorderSize = 0;
            this.ajuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajuda.Image = global::ProjetoTarefas.Properties.Resources.icons8_question_30;
            this.ajuda.Location = new System.Drawing.Point(582, 351);
            this.ajuda.Name = "ajuda";
            this.ajuda.Size = new System.Drawing.Size(39, 36);
            this.ajuda.TabIndex = 33;
            this.ajuda.UseVisualStyleBackColor = false;
            this.ajuda.Click += new System.EventHandler(this.ajuda_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoTarefas.Properties.Resources.consult;
            this.pictureBox2.Location = new System.Drawing.Point(494, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoTarefas.Properties.Resources.logo_trabalho_maior;
            this.pictureBox1.Location = new System.Drawing.Point(235, -124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 466);
            this.Controls.Add(this.busca1);
            this.Controls.Add(this.textBoxBusca);
            this.Controls.Add(this.ajuda);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxP);
            this.Controls.Add(this.filt2);
            this.Controls.Add(this.filt);
            this.Controls.Add(this.marcar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button marcar;
        private System.Windows.Forms.Button filt;
        private System.Windows.Forms.Button filt2;
        private System.Windows.Forms.ComboBox comboBoxP;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ajuda;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.Button busca1;
    }
}