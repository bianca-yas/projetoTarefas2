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
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            this.Load += new EventHandler(Form1_Load);
            InitializeComponent();
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.ValidatingType = typeof(System.DateTime);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            ArredondarBotao(add, 30);
            ArredondarBotao(voltar, 30);
            //ArredondarControle(Fazendo, 30);
            //ArredondarControle(Fazer, 30);
            //ArredondarControle(Feito, 30);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

        private void add_Click(object sender, EventArgs e)
        {
            DAO inserir = new DAO();
            string titulo = textBox1.Text;
            string descricao = textBox2.Text;
            DateTime data;
            if(!DateTime.TryParseExact(maskedTextBox1.Text, "dd/MM/yyyy",null, System.Globalization.DateTimeStyles.None, out data))
            {
                MessageBox.Show("Data inválida!");
                return ;
            }
            string dataVencimento = data.ToString("yyyy-MM-dd");
            string prioridade = comboBox1.Text;
            string pendencia = comboBox2.Text;

            MessageBox.Show(inserir.Adicionar(titulo, descricao, dataVencimento, prioridade, pendencia));
        }//fim do adicionar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa titulo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa descricao

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//fim da caixa prioridade

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim da caixa data

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//fim da caixa pendencia
    }
}
