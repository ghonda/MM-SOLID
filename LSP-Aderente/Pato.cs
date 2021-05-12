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
    public interface IQuack
    {
        void Quack();
    }

    public class PatoSelvagem : IFly, ISwim, IQuack
    {
        public void Quack()
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

    public class PatoDomestico : IFly, ISwim, IQuack
    {
        public void Quack()
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

    public class PatoBorracha : ISwim, IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
        public void Nadar()
        {
            Console.WriteLine("Flutuando!");
        }
    }
}
