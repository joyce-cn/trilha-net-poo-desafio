namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void MostrarInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("SEGUE INFORMAÇÕES DO SMARTHPHONE!");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memória: {Memoria} GB");
            Console.WriteLine("\n");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        
        public void DesligaCelular()
        {
            Console.WriteLine("Celular desligando...");
        }
    }
}