using System;

namespace Celulares
{
    // Classe abstrata Smartphone
    abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando o smartphone...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que será sobrescrito nas classes filhas
        public abstract void InstalarAplicativo(string nome);
    }

    // Classe Nokia
    class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) { }

        // Implementação específica do Nokia
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no Nokia via Loja Nokia...");
        }
    }

    // Classe iPhone
    class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) { }

        // Implementação específica do iPhone
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no iPhone via App Store...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("1234-5678", "Nokia X", "111222333444555", 64);
            Iphone iphone = new Iphone("9876-5432", "iPhone 14", "555444333222111", 128);

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine();
        }
    }
}
