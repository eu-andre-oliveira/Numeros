using Olivas.Numeros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olivas.Numeros.Entidades
{
    public class Calculo
    {
        public virtual Cliente Cliente { get; set; }
        public DateTime DataCalculo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }


        public void CalcularCliente(Cliente cliente)
        {
            var lista = Tabela.ListaValorLetras;

            int somaTotal = 0;
            int somaVogais = 0;
            int somaConsoantes = 0;
            var ListaValores = new List<int>();

            //calcular os valores das letras do nome
            foreach (var item in cliente.Nome.ToLower())
            {
                switch (item.ToString())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                    case "á":
                    case "é":
                    case "í":
                    case "ó":
                    case "ú":
                    case "y":
                        somaVogais = somaVogais + lista.Where(c => c.Key.Equals(item.ToString())).FirstOrDefault().Value;
                        break;
                    default:
                        somaConsoantes = somaConsoantes + lista.Where(c => c.Key.Equals(item.ToString())).FirstOrDefault().Value;
                        break;
                }
                somaTotal = somaTotal + lista.Where(c => c.Key.Equals(item.ToString())).FirstOrDefault().Value;
                ListaValores.Add(lista.Where(c => c.Key.Equals(item.ToString())).FirstOrDefault().Value);
            }

            while (somaTotal >= 10 && somaTotal != 11 && somaTotal != 22) 
            {
                somaTotal = Convert.ToInt32((somaTotal.ToString()[0].ToString()))
                          + Convert.ToInt32((somaTotal.ToString()[1].ToString()));
            }
            while (somaConsoantes >= 10 && somaConsoantes != 11 && somaConsoantes != 22)
            {
                somaConsoantes = Convert.ToInt32((somaConsoantes.ToString()[0].ToString()))
                               + Convert.ToInt32((somaConsoantes.ToString()[1].ToString()));
            }
            while (somaVogais >= 10 && somaVogais != 11 && somaVogais != 22)
            {
                somaVogais = Convert.ToInt32((somaVogais.ToString()[0].ToString()))
                           + Convert.ToInt32((somaVogais.ToString()[1].ToString()));
            }

            //Tabela.ListaValorLetras 
            cliente.NumeroExpressao = somaTotal;
            cliente.NumeroImpressao = somaConsoantes;
            cliente.NumeroMotivacao = somaVogais;
        }

        private int ReduzNumero(int numero)
        {

            return 
        }

    }
}