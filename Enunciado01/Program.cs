using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enunciado01.objetos;
using Enunciado01.excecoes;

namespace Enunciado01 {
    class Program {

       public static List<Artista> artistas = new List<Artista>();
       public static List<Filme> listaFilmes = new List<Filme>();

        static void Main(string[] args) {
            int opcao = 0;

            artistas.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            artistas.Sort();
            
            while(opcao != 5) {
                Console.WriteLine();
                TelaAux.mostrarMenu();
                try {
                    opcao = int.Parse(Console.ReadLine());
                }catch(Exception e) {
                    Console.WriteLine("ERRO" + e.Message);
                }
                Console.WriteLine();
                switch (opcao) {
                    case 1:
                        TelaAux.mostrarArtistas();
                        break;
                    case 2:
                        try {
                            TelaAux.cadastrarArtista();
                        }
                        catch (CustomException e) {
                            throw new CustomException(e.Message);
                        }
                        break;
                    case 3:
                        try {
                            TelaAux.cadastrarFilme();
                        }
                        catch (CustomException e) {
                            throw new CustomException(e.Message);
                        }
                        break;
                    case 4:
                        try {
                            TelaAux.mostrarFilmes();
                        }catch(CustomException e) {
                            throw new CustomException(e.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("FIM DO PROGRAMA!");
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVALIDA!!!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
