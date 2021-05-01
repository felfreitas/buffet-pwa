using System;
using System.Collections.Generic;

namespace BuffetOficial.Models.Buffet.Cliente
{
    public class ClienteService
    {
        public List<ClienteEntity> ObterClientes()
        {
            var listaDeClientes = new List<ClienteEntity>();
            
            listaDeClientes.Add(new ClienteEntity
            {
                Id = 1,
                Nome = "Felipe",
                DataDeNascimento = new DateTime(1989,09,11)
            });
            
            listaDeClientes.Add(new ClienteEntity
            {
                Id = 2,
                Nome = "Zeh",
                DataDeNascimento = new DateTime(1987,03,11)
            });
            return listaDeClientes;
        }
    }
}