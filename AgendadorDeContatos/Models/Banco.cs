using AgendadorDeContatos.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SQLite;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgendadorDeContatos.Data
{
    internal class Banco
    {

        private string caminhoBanco;
        private SQLiteConnection conexao;

        // Construtor
        public Banco()
        {
            // Caminho do banco
            caminhoBanco = @"D:\Obsidian Vault\Projetos\2 - Projeto - Agenda de Contatos\AgendaDeContatos.db";
            // Criar conexão
            conexao = new SQLiteConnection($"Data Source={caminhoBanco};Version=3;");
            // Abrir conexão
            conexao.Open();

        }



        public void InserirContato(string nome, string email, string telefone)
        {
            string sql = "INSERT INTO Contato (Nome, Email, Telefone) VALUES (@Nome, @Email, @Telefone)";
            var cmd = new SQLiteCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Telefone", telefone);
            cmd.ExecuteNonQuery();
            
        }

        public void DeletarContato(string nome)
        {
            string sql = "DELETE FROM Contato WHERE nome = @Nome";
            var cmd = new SQLiteCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.ExecuteNonQuery();
        }


        public void AtualizarContato(int id, string nome, string email, string telefone)
        {
            string sql = "UPDATE Contato SET Nome = @Nome, Email = @Email, Telefone = @Telefone  WHERE Id = @Id ";
            Console.WriteLine(sql);
            var cmd = new SQLiteCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Telefone", telefone);
            cmd.Parameters.AddWithValue("@Id", id);

            Console.WriteLine($"SQL: {sql}");
            Console.WriteLine($"@Id = {id}, @Nome = {nome}, @Email = {email}, @Telefone = {telefone}");


            int linhas = cmd.ExecuteNonQuery();
            Console.WriteLine("Linhas afetadas: " + linhas);
        }

        public List<Contato> ListarContatos()
        {
            List<Contato> contatos = new List<Contato>();
            string sql = "SELECT * FROM Contato";
            SQLiteCommand cmd = new SQLiteCommand(sql, conexao);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Contato c = new Contato
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString(),
                    Email = reader["Email"].ToString(),
                    Telefone = reader["Telefone"].ToString()
                };
                contatos.Add(c);
            }
            reader.Close();
            return contatos;
        }

        public List<Contato> ConsultaContatos(string nome)
        {
            List<Contato> contatos = new List<Contato>();
            string sql = "SELECT * FROM Contato WHERE Nome LIKE @Nome";
            SQLiteCommand cmd = new SQLiteCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Contato c = new Contato
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString(),
                    Email = reader["Email"].ToString(),
                    Telefone = reader["Telefone"].ToString()
                };
                contatos.Add(c);
            }
            reader.Close();
            return contatos;
        }



        public void Fechar()
        {
            conexao.Close();
        }







    }
}
