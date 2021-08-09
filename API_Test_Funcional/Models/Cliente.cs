using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Test_Funcional.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Decimal Saldo { get; set; }


        public Cliente(int id, string nome, decimal saldo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Saldo = saldo;
        }
    }
}