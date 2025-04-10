using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjetoTarefas
{
    class DAO
    {
        public MySqlConnection conn;
        public int[] codigo;
        public string[] titulo;
        public string[] descricao;
        public string[] dataVencimento;
        public string[] prioridade;
        public string[] pendencia;
        public int i;
        public int contador;

        public DAO()
        {
            conn = new MySqlConnection("server=localhost;Database=gerenciadorTarefas;Uid=root;password=");
            try
            {
                conn.Open();
            }catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n\n" + erro);
            }
        }//fim do construtor

        public string Adicionar(string titulo,string descricao,string dataVencimento,string prioridade,string pendencia)
        {
            string inserir = $"Insert into tarefas(codigo,titulo,descricao,dataPendencia,prioridade,pendencia) values('','{titulo}','{descricao}','{dataVencimento}','{prioridade}','{pendencia}')";
            MySqlCommand sql = new MySqlCommand(inserir, conn);
            string resultado = sql.ExecuteNonQuery() + "  Tarefa adicionada com sucesso!";

            return resultado;
        }

        public void PreencherVetor()
        {
            string query = "select * from tarefas";

            //Instanciar os vetores
            this.codigo = new int[100];
            this.titulo  = new string[100];
            this.descricao = new string[100];
            this.dataVencimento = new string[100];
            this.prioridade = new string[100];
            this.pendencia = new string[100];

            MySqlCommand sql = new MySqlCommand(query, conn);

            MySqlDataReader reader = sql.ExecuteReader();

            i = 0; //instanciando contadores
            contador = 0;
            while (reader.Read())
            {
                codigo[i] = Convert.ToInt32(reader["codigo"]);
                titulo[i] = reader["titulo"]+"";
                descricao[i] = reader["descricao"] + "";


                string dataLida = reader["dataPendencia"].ToString();
                if (!string.IsNullOrWhiteSpace(dataLida) && dataLida != "0000-00-00")
                {
                    DateTime data;
                    if (DateTime.TryParse(reader["dataPendencia"].ToString(), out data))
                    {
                        dataVencimento[i] = data.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        dataVencimento[i] = "";
                    }
                }
                else
                {
                    dataVencimento[i] = "";
                }

                
                prioridade[i] = reader["prioridade"] + "";
                pendencia[i] = reader["pendencia"] + "";

                i++; //contador gira
                contador++; //dados que vão preencher o vetor
            }//fim do while

            reader.Close(); //encerrar a leitura
        }//fim do metodo vetor

        public int ConsultarIndividual(int cod)
        {
            PreencherVetor(); //Preenchendo o vetor com dados do banco

            i = 0;
            for(int i  = 0; i < codigo.Length; i++)
            {
                if (codigo[i] == cod)
                {
                    return i;
                }
            }

            return -1; //Encerrar leitura


        }//fim do metodo consultar individual

        public string retornarTitulo(int cod)
        {
            int posicao = ConsultarIndividual(cod);
            if(posicao > -1)
            {
                return titulo[posicao];
            }
            return "Código digitado não é válido!";
        }//fim do retornar titulo

        public string retornarDescricao(int cod)
        {
            int posicao = ConsultarIndividual(cod);
            if (posicao > -1)
            {
                return descricao[posicao];
            }
            return "Código digitado não é válido!";
        }//fim do retornar descricao

        public string retornarData(int cod)
        {
            int posicao = ConsultarIndividual(cod);
            if (posicao > -1)
            {
                return dataVencimento[posicao];
            }
            return "";
        }//fim do retornar data

        public string retornarPrioridade(int cod)
        {
            int posicao = ConsultarIndividual(cod);
            if (posicao > -1)
            {
                return prioridade[posicao];
            }
            return "Código digitado não é válido!";
        }//fim do retornar prioridade

        public string retornarPendencia(int cod)
        {
            int posicao = ConsultarIndividual(cod);
            if (posicao > -1)
            {
                return pendencia[posicao];
            }
            return "Código digitado não é válido!";
        }//fim do retornar pendencia

        public int quantidadeDeDados()
        {
            return contador;
        }//fim do quantidadeDeDados

        public string Editar(int codigo, string campo, string dado)
        {
            string query = $"update tarefas set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conn);
            string resultado = sql.ExecuteNonQuery() + "  Atualizado com sucesso!";

            return resultado;
        }//fim do atualizar

        public string Concluir(int codigo)
        {
            string query = $"update tarefas set pendencia = 'Concluída' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conn);
            string resultado = sql.ExecuteNonQuery() + "  Tarefa concluída com sucesso!";

            return resultado;
        }

        public string Filtrar(string prioridade)
        {
            string query = $"select * from tarefas where prioridade = '{prioridade}'";
            MySqlCommand sql = new MySqlCommand(query, conn);
            string resultado = sql.ExecuteNonQuery() + "";

            return resultado;
        }

        public string FiltrarStatus(string pendencia)
        {
            string query = $"select * from tarefas where pendencia = '{pendencia}'";
            MySqlCommand sql = new MySqlCommand(query, conn);
            string resultado = sql.ExecuteNonQuery() + "";

            return resultado;
        }

        public string Excluir(int codigo)
        {
            string query = $"delete from tarefas where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conn);
            string resultado = sql.ExecuteNonQuery() + "  Deletado com sucesso!";

            return resultado;

        }

    }
}
