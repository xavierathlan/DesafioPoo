namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _imei;
        private string _modelo;
        private int _memoria;

        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            _imei = imei;
            _modelo = modelo;
            _memoria = memoria; 
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