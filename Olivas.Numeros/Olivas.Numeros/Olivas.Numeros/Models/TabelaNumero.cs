using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olivas.Numeros.Models
{

    public class Numeros
    {
        public int ValorLetra { get; set; }
        public string Letra { get; set; }
    }
    public static class Tabela
    {
        public static List<KeyValuePair<string, int>> ListaValorLetras = new List<KeyValuePair<string, int>>()
        {
                 new KeyValuePair<string, int>("a", 1),
                 new KeyValuePair<string, int>("b", 2),
                 new KeyValuePair<string, int>("c", 3),
                 new KeyValuePair<string, int>("d", 4),
                 new KeyValuePair<string, int>("e", 5),
                 new KeyValuePair<string, int>("f", 8),
                 new KeyValuePair<string, int>("g", 3),
                 new KeyValuePair<string, int>("h", 5),
                 new KeyValuePair<string, int>("i", 1),
                 new KeyValuePair<string, int>("j", 1),
                 new KeyValuePair<string, int>("k", 2),
                 new KeyValuePair<string, int>("l", 3),
                 new KeyValuePair<string, int>("m", 4),
                 new KeyValuePair<string, int>("n", 5),
                 new KeyValuePair<string, int>("o", 7),
                 new KeyValuePair<string, int>("p", 8),
                 new KeyValuePair<string, int>("q", 1),
                 new KeyValuePair<string, int>("r", 2),
                 new KeyValuePair<string, int>("s", 3),
                 new KeyValuePair<string, int>("t", 4),
                 new KeyValuePair<string, int>("u", 6),
                 new KeyValuePair<string, int>("v", 6),
                 new KeyValuePair<string, int>("x", 5),
                 new KeyValuePair<string, int>("w", 6),
                 new KeyValuePair<string, int>("y", 1),
                 new KeyValuePair<string, int>("z", 7),
                 new KeyValuePair<string, int>("é", 7),
                 new KeyValuePair<string, int>("í", 3),
                 new KeyValuePair<string, int>("ó", 9),
                 new KeyValuePair<string, int>("á", 3)
        };
    }
}