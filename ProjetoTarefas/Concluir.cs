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
    public partial class Concluir : Form
    {
        DAO conclu;
        public Concluir()
        {
            conclu = new DAO();
            this.Load += new EventHandler(Concluir_Load);
            InitializeComponent();
        }

        private void Concluir_Load(object sender, EventArgs e)
        {
            ArredondarBotao(voltar, 30);
            ArredondarBotao(conc, 30);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }//fim da caixa codigo

        private void conc_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox2.Text);

            string message = "Tem certeza que deseja concluir essa tarefa?";
            string caption = "Ordoflow";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);

            if(result == DialogResult.Yes)
            {
                conclu.Concluir(codigo);
                MessageBox.Show("  Tarefa concluida com sucesso!");
            }
        }//fim do botao concluir

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do botao voltar
    }
}
