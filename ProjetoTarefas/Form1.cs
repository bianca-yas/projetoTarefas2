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
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Load += new EventHandler(Form1_Load);
            InitializeComponent();
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
            ArredondarBotao(button1, 30);
            ArredondarBotao(editarTarefa, 30);
            ArredondarBotao(consultarTaf, 30);
            ArredondarBotao(excluirTaf, 30);
            //ArredondarControle(Fazendo, 30);
            //ArredondarControle(Fazer, 30);
            //ArredondarControle(Feito, 30);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Adicionar add = new Adicionar();
            add.ShowDialog();
        }//fim do botao adicionar

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void editarTarefa_Click(object sender, EventArgs e)
        {
            Editar edi = new Editar();
            edi.ShowDialog();
        }//fim do botao editar

        private void consultarTaf_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            consultar.ShowDialog();
        }

        private void excluirTaf_Click(object sender, EventArgs e)
        {
            Excluir exc = new Excluir();
            exc.ShowDialog();
        }

        private void mensagem_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
