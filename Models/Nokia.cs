namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string Modelo, string IMEI, int Memoria)
            : base(numero, Modelo, IMEI, Memoria)
        {
            // Construtor da classe Nokia que chama o construtor da classe base (Smartphone)
        }

        public override void InstalarAplicativo(string nomeAplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeAplicativo}' em um dispositivo Nokia.");
        }
    }
}
