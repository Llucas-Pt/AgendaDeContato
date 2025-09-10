using AgendadorDeContatos.Data;
using AgendadorDeContatos.Models;
using System.Linq.Expressions;

namespace AgendadorDeContatos
{
    public partial class MainModel : Form
    {
        public MainModel()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();


        }
        private void buttonCadastro_Click(object sender, EventArgs e)


        {



            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || !maskedTextBox1.MaskFull)
            {

                MessageBox.Show("Preencha todos os campos!");

            }
            else
            {

                Contato ContatoBanco = new Contato(textBox1.Text, textBox2.Text, maskedTextBox1.Text);

                Banco banco = new Banco();
                banco.InserirContato(ContatoBanco.Nome, ContatoBanco.Email, ContatoBanco.Telefone);
                MessageBox.Show("Contato cadastrado com sucesso!");
                banco.Fechar();
                AtualizarDataGrid(); // Atualiza a tabela
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            List<Contato> contatos = banco.ConsultaContatos(textBox1.Text);
            banco.Fechar();


            dataGridView1.DataSource = null; // Limpa antes de atualizar
            dataGridView1.DataSource = contatos; // Preenche com a lista
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                MessageBox.Show("Nome inválido, digite um Nome.");
            }
            else
            {
                Banco banco = new Banco();
                banco.DeletarContato(textBox1.Text);
                MessageBox.Show("Contato deletado com sucesso!");
                AtualizarDataGrid();
                banco.Fechar();
            }

        }
        private void btnAtualizacao_Click(object sender, EventArgs e)
        {

            try
            {
                // converte ID (vem do textBox5)
                int id = int.Parse(textBox5.Text);


                // cria conexão
                Banco banco = new Banco();

                // chama o método de atualização
                Contato ContatoBanco = new Contato(textBox3.Text, textBox4.Text, maskedTextBox2.Text);
                banco.AtualizarContato(id, ContatoBanco.Nome, ContatoBanco.Email, ContatoBanco.Telefone);
                MessageBox.Show("Contato atualizado com sucesso!");

                // recarrega os dados no DataGridView
                List<Contato> contatos = banco.ConsultaContatos(""); // busca todos
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = contatos;

                banco.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }
        private void AtualizarDataGrid()
        {
            Banco banco = new Banco();
            List<Contato> contatos = banco.ListarContatos();
            banco.Fechar();

            dataGridView1.DataSource = null; // Limpa antes de atualizar
            dataGridView1.DataSource = contatos; // Preenche com a lista
        }


    }
}
