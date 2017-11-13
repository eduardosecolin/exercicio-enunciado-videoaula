using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Enunciado01.objetos {
    class Filme {
        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }
        public List<Participacao> lista { get; set; }

        public Filme(int cod, string titulo, int ano) {
            this.codigo = cod;
            this.titulo = titulo;
            this.ano = ano;
            lista = new List<Participacao>();
        }
        public double custoTotal() {
            double soma = 0.0;
            for(int i = 0; i < lista.Count; i++) {
                soma += lista[i].custo();
            }
            return soma;
        }
        public override string ToString() {
            String s = "FILME: " + codigo + " , " + titulo + " , " + ano +
                "\nPARTICIPAÇÕES:\n";
            for(int i = 0; i < lista.Count; i++) {
                s += lista[i] + "\n";
            }
            s = s + "CUSTO TOTAL DO FILME: " + custoTotal().ToString("F2", CultureInfo.InvariantCulture);
            return s;
        }
    }
}
