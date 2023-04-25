namespace Umfg.Programacao.Assincrona._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AguardarEmSegundosAsync(5);
            Console.ReadLine();

            for(var i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        static async void AguardarEmSegundosAsync(int segundos)
        {
            Console.WriteLine("Inicio aguaradar processamento");
            await Task.Delay(TimeSpan.FromSeconds(segundos));
            Console.WriteLine($"Fim do processamento, aguardou {segundos}");
        }
    }
}