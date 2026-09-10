using System;
using System.Collections.Generic;
using System.Text;

namespace OldDragon1
{
   
    public class FichaOldDragon
    {
        public Atributos Atributos { get; set; } = new Atributos();

        public int Forca
        {
            get => Atributos.Forca;
            set => Atributos.Forca = value;
        }

        public int Destreza
        {
            get => Atributos.Destreza;
            set => Atributos.Destreza = value;
        }

        public int Constituicao
        {
            get => Atributos.Constituicao;
            set => Atributos.Constituicao = value;
        }

        public int Inteligencia
        {
            get => Atributos.Inteligencia;
            set => Atributos.Inteligencia = value;
        }

        public int Sabedoria
        {
            get => Atributos.Sabedoria;
            set => Atributos.Sabedoria = value;
        }

        public int Carisma
        {
            get => Atributos.Carisma;
            set => Atributos.Carisma = value;
        }

        public string Nome { get; set; } = "";
        public string Jogador { get; set; } = "";
        public string Classe { get; set; } = "";
        public string Raca { get; set; } = "";

        public int Nivel { get; set; } = 1;
        public int BaseAtaque { get; set; }

        public int PontosVida { get; set; }
        public int PontosVidaMaximos { get; set; }
        public int ClasseArmadura { get; set; }
        public int JogadaDeProtecao { get; set; }
        public int Experiencia { get; set; }
        public int Movimento { get; set; }
        public int Infravisao { get; set; }
        public string Alinhamento { get; set; } = "";
        public void Exibir()
        {
            Console.WriteLine($"Movimento: {Movimento}m");
            Console.WriteLine($"Infravisão: {Infravisao}m");
            Console.WriteLine($"Alinhamento: {Alinhamento}");
            Console.WriteLine($"BA: {BaseAtaque}");
            Console.WriteLine(
                "\n=== FICHA OLD DRAGON ===" +
                $"\nNome: {Nome} | Jogador: {Jogador}" +
                $"\nRaça: {Raca} | Classe: {Classe} | Nível: {Nivel}" +
                $"\nPV: {PontosVida}/{PontosVidaMaximos}" +
                $"\nCA: {ClasseArmadura}" +
                $"\nProteção: {JogadaDeProtecao} | XP: {Experiencia}" +
                $"\nFOR: {Forca}" +
                $" | DES: {Destreza}" +
                $" | CON: {Constituicao}" +
                $" | INT: {Inteligencia}" +
                $" | SAB: {Sabedoria}" +
                $" | CAR: {Carisma}" +
                "\n========================="
            );
        }
    }
}