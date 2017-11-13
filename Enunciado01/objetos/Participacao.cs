using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Enunciado01.objetos {
    class Participacao {
        public double desconto { get; set; }
        public Artista artista { get; set; }
        public Filme filme { get; set; }

        public Participacao(double desc, Filme filme, Artista artista) {
            this.desconto = desc;
            this.artista = artista;
            this.filme = filme;
        }
        public double custo() {
            return artista.cache - desconto;
        }
        public override string ToString() {
            return " "+artista.nome + " , CACHÊ: " + artista.cache.ToString("F2", CultureInfo.InvariantCulture) +
                " , CUSTO: " + custo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
