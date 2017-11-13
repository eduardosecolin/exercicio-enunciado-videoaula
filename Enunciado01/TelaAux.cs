using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Enunciado01.objetos;
using Enunciado01.excecoes;

namespace Enunciado01 {
    class TelaAux {

        public static void mostrarMenu() {
            Console.WriteLine("1 - LIATAR ARTISTAS ORDENADAMENTE* ");
            Console.WriteLine("2 - CADASTRAR ARTISTA ");
            Console.WriteLine("3 - CADASTRAR FILME ");
            Console.WriteLine("4 - MOSTRAR DADOS DE UM FILME ");
            Console.WriteLine("5 - SAIR ");
            Console.Write("ESCOLHA A SUA OPÇÃO: ");
        }
        public static void mostrarArtistas() {
            Console.WriteLine("-----------LISTAGEM DOS ARTISTAS-------------");
            for(int i = 0; i < Program.artistas.Count; i++) {
                Console.WriteLine(Program.artistas[i]);
            }
        }
        public static void cadastrarArtista() {
            Console.WriteLine("DIGITE OS DADOS DOS ARTISTAS");
            Console.Write("CODIGO: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("NOME  : ");
            string nome = Console.ReadLine();
            Console.Write("CACHÊ : ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Artista A = new Artista(cod, nome, cache);
            Program.artistas.Add(A);
            Program.artistas.Sort();
        }
        public static void cadastrarFilme() {
            Console.WriteLine("DIGITE OS DADOS DO FILME");
            Console.Write("CODIGO: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("TITULO: ");
            string titulo = Console.ReadLine();
            Console.Write("ANO   : ");
            int ano = int.Parse(Console.ReadLine());
            Filme F = new Filme(cod, titulo, ano);
            Console.Write("QUANTAS PARTICIPAÇÕES TEM O FILME?: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++) {
                Console.WriteLine("DIGITE OS DADOS DA " + i + "º PARTICIPAÇÃO:");
                Console.Write("ARTISTA (CODIGO): ");
                int artistaCod = int.Parse(Console.ReadLine());
                int posicao = Program.artistas.FindIndex(user => user.codigo == artistaCod);
                if(posicao == -1) {
                    throw new CustomException("Codigo do artista não existe" + artistaCod);
                }
                Console.Write("DESCONTO        : ");
                double desc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Participacao p = new Participacao(desc, F, Program.artistas[posicao]);
                F.lista.Add(p);
            }
            Program.listaFilmes.Add(F);
        }
        public static void mostrarFilmes() {
            Console.Write("DIGITE O CODIGO DO FILME: ");
            int codFilme = int.Parse(Console.ReadLine());
            int posicao = Program.listaFilmes.FindIndex(user => user.codigo == codFilme);
            if(posicao == -1) {
                throw new CustomException("Codigo inexistente!!!" + codFilme);
            }
            Console.WriteLine(Program.listaFilmes[posicao]);
            Console.WriteLine();
        }
    }
}
