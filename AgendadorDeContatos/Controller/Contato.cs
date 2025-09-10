using  AgendadorDeContatos.Data;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgendadorDeContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email {  get; set; }
        public string Telefone { get; set; }



        public Contato(string nome, string email, string telefone)
        {

            Nome = nome;
            Email = email;
            Telefone = telefone;

        }

        public Contato() { }

    }




}
