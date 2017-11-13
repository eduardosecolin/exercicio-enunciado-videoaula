using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Enunciado01.objetos {
    class Artista : IComparable{
        public int codigo { get; set; }
        public string nome { get; set; }
        public double cache { get; set; }

        public Artista(int cod, string name, double cache) {
            this.codigo = cod;
            this.nome = name;
            this.cache = cache;
        }

        public override string ToString() {
            return "CODIGO: " + codigo + " , NOME: " + nome + 
                " , CACHÊ: " + cache.ToString("F2",CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            Artista outro = ((Artista)obj);
            int resultado = nome.CompareTo(outro.nome);
            if(resultado != 0) {
                return resultado;
            }else {
                return -cache.CompareTo(outro.cache);
            }
        }
    }
}
