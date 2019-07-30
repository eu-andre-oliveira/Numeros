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
            #region Expressao Motivação e Impressao

            
            int somaTotal = 0;
            int somaVogais = 0;
            int somaConsoantes = 0;
            var ListaValores = new List<int>();

            //calcular os valores das letras do nome
            foreach (var item in cliente.Nome.ToLower())
            {
                if (lista.Where(c => c.Key.Equals(item.ToString())).FirstOrDefault().Value == 0)
                    continue;
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

                cliente.PrimeiraLinhaPiramide =
                    cliente.PrimeiraLinhaPiramide + 
                    lista.Where(c => c.Key.Equals(item.ToString()))
                                          .FirstOrDefault().Value.ToString() + " + ";

            }

            cliente.PrimeiraLinhaPiramide =
                cliente.PrimeiraLinhaPiramide
                  .Substring(0, cliente.PrimeiraLinhaPiramide.Length - 3);

            somaTotal = ReduzNumero(somaTotal);

            somaConsoantes = ReduzNumero(somaConsoantes);

            somaVogais = ReduzNumero(somaVogais);


            
            cliente.NumeroExpressao = somaTotal;
            cliente.NumeroImpressao = somaConsoantes;
            cliente.NumeroMotivacao = somaVogais;
            #endregion

            #region Numero do Destino     

            cliente.NumeroDestino = ReduzNumero(SomaCaracteres(cliente.DataNascimento.ToString("ddMMyyyy")));

            #endregion

            #region Ciclos

            cliente.Numero1Ciclo = ReduzNumero(Convert.ToInt32(cliente.DataNascimento.ToString("MM")));

            cliente.Numero2Ciclo = ReduzNumero(Convert.ToInt32(cliente.DataNascimento.ToString("dd")));

            cliente.Numero3Ciclo = ReduzNumero(Convert.ToInt32(cliente.DataNascimento.ToString("yyyy")));

            #endregion

            #region Momentos decisivos

            cliente.NumeroMomento1 = ReduzNumero(Convert.ToInt32(cliente.DataNascimento.ToString("ddMM")));

            cliente.NumeroMomento2 = ReduzNumero(SomaCaracteres(cliente.DataNascimento.ToString("ddyyyy")));

            cliente.NumeroMomento3 = ReduzNumero(cliente.NumeroMomento1 + cliente.NumeroMomento2);

            cliente.NumeroMomento4 = ReduzNumero(SomaCaracteres(cliente.DataNascimento.ToString("MMyyyy")));



            #endregion

            #region Missao
            cliente.NumeroMissao = ReduzNumero(cliente.NumeroDestino + cliente.NumeroExpressao);
            #endregion

        }

        private int SomaCaracteres(string Caracteres)
        {
            int soma = 0;
            foreach (var item in Caracteres)
            {
                soma = soma + Convert.ToInt32((item.ToString()[0].ToString()));
            }
            return soma;

            //teste 
        }




        private int ReduzNumero(int numero)
        {
            var numeroTemp = numero;
            while (numeroTemp >= 10 && numeroTemp != 11 && numeroTemp != 22)
            {
                numeroTemp = Convert.ToInt32((numero.ToString()[0].ToString()))
                       + Convert.ToInt32((numero.ToString()[1].ToString()));
                if (numero >= 100) numeroTemp =
                        numeroTemp + Convert.ToInt32((numero.ToString()[2].ToString())); 
                if (numero >= 1000) numeroTemp =
                        numeroTemp + Convert.ToInt32((numero.ToString()[3].ToString())) ;
                if (numero >= 10000) numeroTemp =
                        numeroTemp + Convert.ToInt32((numero.ToString()[4].ToString()));
                if (numero >= 100000) numeroTemp =
                        numeroTemp + Convert.ToInt32((numero.ToString()[5].ToString()));
                numero = numeroTemp;
            }
            return numero;
        }

    }
}