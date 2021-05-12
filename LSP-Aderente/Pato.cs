using System;

namespace LSP_Aderente
{
    public interface IFly
    {
        void Voar();
    }
    public interface ISwim
    {
        void Nadar();
    }

    public abstract class Pato
    {
        public abstract void Quack();
        public string Bico { get; set; }
        public string Asa { get; set; }
    }

    public class PatoSelvagem : Pato, IFly, ISwim
    {
        public PatoSelvagem()
        {
            Bico = "Preto";
            Asa = "Grande";
        }
        public override void Quack()
        {
            Console.WriteLine("QUACK!");
        }
        public void Nadar()
        {
            Console.WriteLine("Nadando!");
        }
        public void Voar()
        {
            Console.WriteLine("Voando!");
        }
    }

    public class PatoDomestico : Pato, IFly, ISwim
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
        public void Nadar()
        {
            Console.WriteLine("Nadando!");
        }
        public void Voar()
        {
            Console.WriteLine("Voando!");
        }
    }

    public class PatoBorracha : Pato, ISwim
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
        public void Nadar()
        {
            Console.WriteLine("Flutuando!");
        }
    }
}
