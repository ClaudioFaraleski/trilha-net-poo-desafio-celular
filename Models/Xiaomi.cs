namespace DesafioPOO.Models
{
    public class Xiaomi : Smartphone
    {
        public Xiaomi(string numero, string modelo, string imei, string memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Xiaomi...");
        }
    }
}
