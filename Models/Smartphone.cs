namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get; set;}
        private string Imei {get; set;}
        private int Memory {get; set;}

        public Smartphone(string numero, string modelo, string imei, int memory)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memory = memory;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}