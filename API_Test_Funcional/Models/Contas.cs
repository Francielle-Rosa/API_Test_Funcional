using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Test_Funcional.Models
{
    public class Contas
    {
        public String Nome { get; set; }
        public int CodigoDeBarra { get; set; }
        public string NomeEmpresa { get; set; }
        public Decimal Valor { get; set; }


        public Contas(string nome, int codigoDeBarra, string nomeempresa, decimal Valor)
        {
            this.Nome = nome;
            this.CodigoDeBarra = codigoDeBarra;
            this.NomeEmpresa = nomeempresa;
            this.Valor = Valor;

        }
    }
}