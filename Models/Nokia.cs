namespace DesafioPOO.Models
{
    //OK TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        
        public override void Ligar()
        {
            Console.WriteLine("Ligando para um Iphone...");
        }
    public override void InstalarAplicativo(string AddApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{AddApp}\" no Nokia...");
        }
         //OK TODO: Sobrescrever o método "InstalarAplicativo"
    }
}