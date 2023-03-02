internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        bool abrirCalculadora = true;

        do
        {
            Console.WriteLine("****************************");
            Console.WriteLine("         CALCULADORA        ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1 - Soma                    ");
            Console.WriteLine("2 - Subtração               ");
            Console.WriteLine("3 - Multiplicação           ");
            Console.WriteLine("4 - Divisão                 ");
            Console.WriteLine("5 - Resto divisão           ");
            Console.WriteLine("0 - Sair                    ");
            Console.WriteLine("****************************");

            Console.WriteLine("Operação:");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Primeiro número:");
                    var soma1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo número");
                    var soma2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {soma1} + {soma2} = {soma1 + soma2}");

                    break;

                case 2:
                    Console.WriteLine("Primeiro número:");
                    int subtracao1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo número");
                    int subtracao2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {subtracao1} - {subtracao2} = {subtracao1 - subtracao2}");
                    break;

                case 3:
                    Console.WriteLine("Primeiro número:");
                    int multiplicacao1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo número");
                    int multiplicacao2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {multiplicacao1} * {multiplicacao2} = {multiplicacao1 * multiplicacao2}");
                    break;

                case 4:
                    Console.WriteLine("Primeiro número:");
                    int divisao1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo número");
                    int divisao2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {divisao1} / {divisao2} = {divisao1 / divisao2}");
                    break;
                case 5:
                    Console.WriteLine("Primeiro número:");
                    int resto1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Segundo número");
                    int resto2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Resultado: {resto1} % {resto2} = {resto1 % resto2}");
                    break;
                case 0:
                    abrirCalculadora = false;

                    break;

                default:
                    break;
            }

        } while (abrirCalculadora == true);

        Console.WriteLine("Saiu.");

        
    }
}