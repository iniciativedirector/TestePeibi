using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Loginv2.Models
{
    [Table("TB_Cliente")]
    class Cliente
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string Nome { get; set; }
        [NotNull]
        public string SobreNome { get; set; }
        [NotNull]
        public string Email { get; set; }
        [NotNull]
        public string Senha { get; set; }
        
        public string CPF { get; set; }


        public Cliente()
        {
            this.Id = 0;
            this.Nome = "";
            this.SobreNome = "";
            this.Email = "";
            this.Senha = "";
            this.CPF = "";
        }

    }
}
