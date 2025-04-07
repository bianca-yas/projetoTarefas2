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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            this.Load += new EventHandler(Consultar_Load);
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

        private void Consultar_Load(object sender, EventArgs e)
        {
            ArredondarBotao(voltar, 30);
            ArredondarBotao(marcar, 30);
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

        private void marcar_Click(object sender, EventArgs e)
        {

        }//fim do botao de concluir tarefa
    }
}
