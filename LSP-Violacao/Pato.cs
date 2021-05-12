using System;

namespace LSP_Violacao
{
    public abstract class Pato
    {
        public abstract void Quack();
        public abstract void Nadar();
        public abstract void Voar();

        public string Bico { get; set; }
        public string Asa { get; set; }
    }

    public class PatoSelvagem : Pato
    {
        public PatoSelvagem()
        {
            Bico = "Preto";
            Asa = "Grande";
        }

        public override void Quack()
        {
            Console.WriteLine("QUACK!!!!");
        }
        public override void Nadar()
        {
            Console.WriteLine("Nadando!");
        }
        public override void Voar()
        {
            Console.WriteLine("Voando!");
        }
    }

    public class PatoDomestico : Pato
    {
        public PatoDomestico()
        {
            Bico = "Amarelo";
            Asa = "Pequena";
        }

        public override void Quack()
        {
            Console.WriteLine("Quack!");
        }
        public override void Nadar()
        {
            Console.WriteLine("Nadando!");
        }
        public override void Voar()
        {
            Console.WriteLine("Voando!");
        }
    }

    public class PatoBorracha : Pato
    {
        public PatoBorracha()
        {
            Bico = "Amarelo";
            Asa = "Borracha";
        }

        public override void Quack()
        {
            Console.WriteLine("Quack!");
        }
        public override void Nadar()
        {
            Console.WriteLine("Flutuando!");
        }
        public override void Voar()
        {
            throw new Exception("Pato de borracha não pode voar");
        }
    }
}
