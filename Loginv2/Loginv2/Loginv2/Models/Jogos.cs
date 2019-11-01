using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Loginv2.Models
{

    [Table("TB_Jogos")]
    class Jogos
    {
        [NotNull]
        public string nomeTimeOne { get; set; }
        [NotNull]
        public string nomeTimeTwo { get; set; }
        [NotNull]
        public string Local { get; set; }


        public Jogos()
        {
            List<Jogos> jogos = new List<Jogos>();
        }
    }

    
}
