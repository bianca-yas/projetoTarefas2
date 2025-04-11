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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoTarefas
{
    public partial class Excluir : Form
    {
        DAO exclu;
        public Excluir()
        {
            this.Load += new EventHandler(Excluir_Load);
            exclu = new DAO();
            InitializeComponent();
        }

        private void ArredondarBotao(System.Windows.Forms.Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            botao.Region = new Region(path);
        } // Fim


        private void Excluir_Load(object sender, EventArgs e)
        {
            ArredondarBotao(voltar2, 30);
            ArredondarBotao(exclude, 30);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exclude_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox2.Text);
            MessageBox.Show(exclu.Excluir(codigo));
            this.Close();
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
