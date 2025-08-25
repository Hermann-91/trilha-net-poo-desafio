namespace DesafioPOO.Models
{
    // OK TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

          public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação de um Nokia...");
        }
        
        public override void InstalarAplicativo(string AddApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{AddApp}\" no iPhone...");
        }
        // OK TODO: Sobrescrever o método "InstalarAplicativo"
    }
}