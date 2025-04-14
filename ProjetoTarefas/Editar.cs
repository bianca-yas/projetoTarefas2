using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTarefas
{
    public partial class Editar : Form
    {
        DAO edi;
        public Editar()
        {
            edi = new DAO();
            this.Load += new EventHandler(Editar_Load);
            InitializeComponent();
            textBox2.ReadOnly = false;
            textBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
            maskedTextBox1.ReadOnly = true;
        }

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
        
       

        private void Editar_Load(object sender, EventArgs e)
        {
            ArredondarBotao(edit, 30);
            ArredondarBotao(voltar, 30);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox2.Text);
            string titulo = textBox1.Text;
            string descricao = textBox3.Text;
            DateTime data;
            string dataVencimento = "";
            if(DateTime.TryParseExact(maskedTextBox1.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
            {
                dataVencimento = data.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("Data inválida");
                return ;
            }//convertendo o datetime para string
            string prioridade = comboBox1.Text;
            string pendencia = comboBox2.Text;

            edi.Editar(codigo, "titulo", titulo);
            edi.Editar(codigo, "descricao", descricao);
            edi.Editar(codigo, "dataPendencia", dataVencimento);
            edi.Editar(codigo, "prioridade", prioridade);
            edi.Editar(codigo, "pendencia", pendencia);
            MessageBox.Show("Dados atualizados com sucesso!");

            this.Close();

        }//fim do botao editar

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa codigo

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa titulo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa descricao

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//fim da caixa prioridade

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim da caixa data

        private void busca_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox1.Text = "Informe o código";
                textBox3.Text = "Informe o código";
                comboBox1.Text = "Informe o código";
                comboBox2.Text = "Informe o código";
            }
            else
            {
                int codigo = Convert.ToInt32(textBox2.Text);
                var dataFormatada = Convert.ToDateTime(edi.retornarData(codigo)).ToString("dd/MM/yyyy");
                textBox1.Text = edi.retornarTitulo(codigo);
                textBox3.Text = edi.retornarDescricao(codigo);
                maskedTextBox1.Text = dataFormatada;
                comboBox1.Text = edi.retornarPrioridade(codigo);
                comboBox2.Text = edi.retornarPendencia(codigo);

                textBox2.ReadOnly = true;
                textBox1.ReadOnly = false;
                maskedTextBox1.ReadOnly = false;
                textBox3.ReadOnly = false;
            }
        }//fim do botao buscar

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//fim da caixa pendencia
    }
}
