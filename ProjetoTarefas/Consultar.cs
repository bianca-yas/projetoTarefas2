using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTarefas
{
    public partial class Consultar : Form
    {
        DAO consult;
        public Consultar()
        {
            consult = new DAO();
            this.Load += new EventHandler(Consultar_Load);
            InitializeComponent();
            configurarGrid();
            nomeColunas();
            adicionarDados();
        }

        public void Limpar()
        {
           dataGridView1.Rows.Clear();
           dataGridView1.Refresh();
            
        }//fim do método

        private void ArredondarBotao(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            botao.Region = new Region(path);
        } // Fim

        private void Consultar_Load(object sender, EventArgs e)
        {
            ArredondarBotao(voltar, 30);
            ArredondarBotao(marcar, 30);
            ArredondarBotao(filt, 20);
            ArredondarBotao(filt2, 20);
            ArredondarBotao(ajuda, 35);
        }


        public void nomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Título";
            dataGridView1.Columns[2].Name = "Descrição";
            dataGridView1.Columns[3].Name = "Data de Vencimento";
            dataGridView1.Columns[4].Name = "Prioridade";
            dataGridView1.Columns[5].Name = "Status";
        }//fim do nomeColunas

        public void configurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.ColumnCount = 6;
        }//fim do configurarGrid

        public void adicionarDados()
        {
            consult.PreencherVetor();
            for(int i = 0; i < consult.quantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(consult.codigo[i], consult.titulo[i], consult.descricao[i], consult.dataVencimento[i], consult.prioridade[i], consult.pendencia[i]);
            }//fim do for
        }//fim do adicionar dados

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Data de Vencimento")
            {
                if(e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime dataVencimento))
                {
                    TimeSpan diferenca = dataVencimento - DateTime.Now;

                    if(diferenca.TotalDays <= 7 && diferenca.TotalDays >= 0)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                    else if(diferenca.TotalDays < 0)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
            {
                if(e.Value != null && e.Value.ToString().Trim().Equals("Concluída", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                } 
            }
        }//fim do cellformating



        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

        private void marcar_Click(object sender, EventArgs e)
        {
            Concluir conclu = new Concluir();
            conclu.ShowDialog();
        }//fim do botao de concluir tarefa

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do dataGridView


        private void filt_Click(object sender, EventArgs e)
        {
            string prioridade = comboBoxP.Text;
            if(comboBoxP.Text == "")
            {
                comboBoxP.Text = "Informe a prioridade!";
            }
            else
            {
                Limpar();
                consult.PreencherVetor();
                for(int i = 0; i < consult.quantidadeDeDados(); i++)
                {
                    if(comboBoxP.Text == consult.prioridade[i])
                    {
                        consult.Filtrar(prioridade);
                        dataGridView1.Rows.Add(consult.codigo[i], consult.titulo[i], consult.descricao[i], consult.dataVencimento[i], consult.prioridade[i], consult.pendencia[i]);
                    }

                }
            }
        }

        private void filt2_Click(object sender, EventArgs e)
        {
            string pendencia = comboBoxStatus.Text;
            if (comboBoxStatus.Text == "")
            {
                comboBoxStatus.Text = "Informe o status que deseja filtrar!";
            }
            else
            {
                Limpar();
                consult.PreencherVetor();
                for (int i = 0; i < consult.quantidadeDeDados(); i++)
                {
                    if (comboBoxStatus.Text == consult.pendencia[i])
                    {
                        consult.FiltrarStatus(pendencia);
                        dataGridView1.Rows.Add(consult.codigo[i], consult.titulo[i], consult.descricao[i], consult.dataVencimento[i], consult.prioridade[i], consult.pendencia[i]);
                    }

                }
            }
        }

        private void comboBoxP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ajuda_Click(object sender, EventArgs e)
        {
            Ajudar ajudar = new Ajudar();
            ajudar.ShowDialog();
        }

        private void textBoxBusca_TextChanged(object sender, EventArgs e)
        {
            string termoBusca = textBoxBusca.Text.Trim().ToLower();

            Limpar();
            consult.PreencherVetor();

            for (int i = 0; i < consult.quantidadeDeDados(); i++)
            {
                string titulo = consult.titulo[i].ToLower();
                string descricao = consult.descricao[i].ToLower();

                if (titulo.Contains(termoBusca) || descricao.Contains(termoBusca))
                {
                    dataGridView1.Rows.Add(consult.codigo[i], consult.titulo[i], consult.descricao[i], consult.dataVencimento[i], consult.prioridade[i], consult.pendencia[i]);
                }
            }
        }

        private void busca1_Click(object sender, EventArgs e)
        {
            string termoBusca = textBoxBusca.Text.Trim().ToLower();

            Limpar();
            consult.PreencherVetor();

            for (int i = 0; i < consult.quantidadeDeDados(); i++)
            {
                string titulo = consult.titulo[i].ToLower();
                string descricao = consult.descricao[i].ToLower();

                if (titulo.Contains(termoBusca) || descricao.Contains(termoBusca))
                {
                    dataGridView1.Rows.Add(consult.codigo[i], consult.titulo[i], consult.descricao[i], consult.dataVencimento[i], consult.prioridade[i], consult.pendencia[i]);
                }
            }
        }
    }
}
