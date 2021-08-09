using API_Test_Funcional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Test_Funcional.Controllers
{
    public class ClienteController : ApiController
    {

        private static List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Get()
        {
            return clientes;

        }

        public void Post(int id, string nome, decimal saldo)
        {
            if (id != 0)
                clientes.Add(new Cliente(id, nome, saldo));
        }

        public void Post(string Nome, decimal Valor)
        {

            var elem = clientes.Where<Cliente>(a => a.Nome == Nome).FirstOrDefault();

            int index = clientes.IndexOf(elem);

            clientes[index].Saldo = clientes[index].Saldo - Valor;

        }
    }
}
