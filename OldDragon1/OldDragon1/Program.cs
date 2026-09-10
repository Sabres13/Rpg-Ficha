using System;
using System.Collections.Generic;

namespace OldDragon1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FichaOldDragon ficha = new FichaOldDragon();

            Console.WriteLine("=== OLD DRAGON ===");

            Console.Write("\nNome do personagem: ");
            ficha.Nome = Console.ReadLine() ?? "";

            Console.Write("Nome do jogador: ");
            ficha.Jogador = Console.ReadLine() ?? "";

            // Escolha da forma de criação dos atributos
            IMetodoCriacao metodo = EscolherMetodoCriacao();

            CriadorPersonagem criador =
                new CriadorPersonagem(metodo);

            int[] valores = criador.GerarAtributos();

            // Clássico usa a ordem fixa.
            // Aventureiro e Heroico permitem distribuir.
            if (criador.PermiteDistribuir())
            {
                DistribuirAtributos(ficha, valores);
            }
            else
            {
                AplicarAtributosEmOrdem(ficha, valores);
            }

            // Escolha e aplicação da raça
            Raca raca = EscolherRaca();
            raca.Aplicar(ficha);

            // Escolha e aplicação da classe
            ClassePersonagem classe = EscolherClasse();
            classe.Aplicar(ficha);

            Console.Clear();

            // Exibe os dados gerais da ficha
            ficha.Exibir();

            Console.WriteLine("\n=== HABILIDADES RACIAIS ===");
            raca.ExibirHabilidades();

            Console.WriteLine("\n=== HABILIDADES DE CLASSE ===");
            classe.ExibirHabilidades();

            Console.WriteLine(
                "\nPressione qualquer tecla para encerrar..."
            );

            Console.ReadKey();
        }

        static IMetodoCriacao EscolherMetodoCriacao()
        {
            while (true)
            {
                Console.WriteLine("\n=== FORMA DE CRIAÇÃO ===");
                Console.WriteLine("1 - Clássico");
                Console.WriteLine("2 - Aventureiro");
                Console.WriteLine("3 - Heroico");

                Console.Write("Escolha: ");

                string opcao =
                    Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        return new CriacaoClassica();

                    case "2":
                        return new CriacaoAventureira();

                    case "3":
                        return new CriacaoHeroica();

                    default:
                        Console.WriteLine(
                            "Opção inválida."
                        );
                        break;
                }
            }
        }

        static void AplicarAtributosEmOrdem(
            FichaOldDragon ficha,
            int[] valores)
        {
            ficha.Forca = valores[0];
            ficha.Destreza = valores[1];
            ficha.Constituicao = valores[2];
            ficha.Inteligencia = valores[3];
            ficha.Sabedoria = valores[4];
            ficha.Carisma = valores[5];
        }

        static void DistribuirAtributos(
            FichaOldDragon ficha,
            int[] valores)
        {
            List<int> disponiveis =
                new List<int>(valores);

            string[] nomes =
            {
                "Força",
                "Destreza",
                "Constituição",
                "Inteligência",
                "Sabedoria",
                "Carisma"
            };

            int[] escolhidos = new int[6];

            for (
                int atributo = 0;
                atributo < nomes.Length;
                atributo++)
            {
                while (true)
                {
                    Console.WriteLine(
                        $"\nEscolha um valor para " +
                        $"{nomes[atributo]}:"
                    );

                    for (
                        int i = 0;
                        i < disponiveis.Count;
                        i++)
                    {
                        Console.WriteLine(
                            $"{i + 1} - " +
                            $"{disponiveis[i]}"
                        );
                    }

                    Console.Write("Escolha: ");

                    if (
                        int.TryParse(
                            Console.ReadLine(),
                            out int escolha)
                        &&
                        escolha >= 1
                        &&
                        escolha <= disponiveis.Count)
                    {
                        escolhidos[atributo] =
                            disponiveis[
                                escolha - 1
                            ];

                        disponiveis.RemoveAt(
                            escolha - 1
                        );

                        break;
                    }

                    Console.WriteLine(
                        "Opção inválida."
                    );
                }
            }

            AplicarAtributosEmOrdem(
                ficha,
                escolhidos
            );
        }

        static Raca EscolherRaca()
        {
            while (true)
            {
                Console.WriteLine("\n=== RAÇA ===");
                Console.WriteLine("1 - Humano");
                Console.WriteLine("2 - Elfo");
                Console.WriteLine("3 - Anão");
                Console.WriteLine("4 - Halfling");

                Console.Write("Escolha: ");

                string opcao =
                    Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        return new Humano();

                    case "2":
                        return new Elfo();

                    case "3":
                        return new Anao();

                    case "4":
                        return new Halfling();

                    default:
                        Console.WriteLine(
                            "Opção inválida."
                        );
                        break;
                }
            }
        }

        static ClassePersonagem EscolherClasse()
        {
            while (true)
            {
                Console.WriteLine("\n=== CLASSE ===");

                Console.WriteLine(
                    "1  - Guerreiro"
                );

                Console.WriteLine(
                    "2  - Bárbaro"
                );

                Console.WriteLine(
                    "3  - Paladino"
                );

                Console.WriteLine(
                    "4  - Clérigo"
                );

                Console.WriteLine(
                    "5  - Druida"
                );

                Console.WriteLine(
                    "6  - Acadêmico"
                );

                Console.WriteLine(
                    "7  - Ladrão"
                );

                Console.WriteLine(
                    "8  - Ranger"
                );

                Console.WriteLine(
                    "9  - Bardo"
                );

                Console.WriteLine(
                    "10 - Mago"
                );

                Console.WriteLine(
                    "11 - Ilusionista"
                );

                Console.WriteLine(
                    "12 - Necromante"
                );

                Console.Write("Escolha: ");

                string opcao =
                    Console.ReadLine() ?? "";

                switch (opcao)
                {
                    case "1":
                        return new Guerreiro();

                    case "2":
                        return new Barbaro();

                    case "3":
                        return new Paladino();

                    case "4":
                        return new Clerigo();

                    case "5":
                        return new Druida();

                    case "6":
                        return new Academico();

                    case "7":
                        return new Ladrao();

                    case "8":
                        return new Ranger();

                    case "9":
                        return new Bardo();

                    case "10":
                        return new Mago();

                    case "11":
                        return new Ilusionista();

                    case "12":
                        return new Necromante();

                    default:
                        Console.WriteLine(
                            "Opção inválida."
                        );
                        break;
                }
            }
        }
    }
}