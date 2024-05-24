
namespace DesafioPOO.Models
{
        public class Iphone : Smartphone
    {
      public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo; 
            Imei = imei; 
            Memoria = memoria;
        }
      
          public override void InstalarAplicativo(string nomeApp)
        {
               Console.WriteLine($"Instalando {nomeApp} no iphone...");
        }             

    }
}