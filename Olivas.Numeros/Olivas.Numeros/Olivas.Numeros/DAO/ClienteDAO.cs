using Olivas.Numeros.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olivas.Numeros.DAO
{
    public class ClienteDAO
    {
        private NumerosContext context;

        public ClienteDAO(NumerosContext context)
        {
            this.context = context;
        }
        public void Adiciona(Cliente cliente)
        {
            cliente.DataCadastro = DateTime.Now;
            cliente.DataAtualizacao = DateTime.Now;
            cliente.UsuarioId = 1;
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public IList<Cliente> Lista()
        {
            return context.Clientes.ToList();
        }

        public void Atualiza(Cliente cliente)
        {
            cliente.DataAtualizacao = DateTime.Now;
            context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}