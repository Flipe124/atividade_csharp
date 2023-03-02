// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string frase = "";
int contador = 0;

Console.WriteLine("Digite uma frase:");
frase = Console.ReadLine();

for (int i = 0; i < frase.Length; i++)
{
    switch (frase[i])
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
            contador++;
            break;
        default:
            break;
    }
}

if(contador > 1)
{
    Console.WriteLine("A frase possui " + contador + " vogais!");
}
else if (contador == 1)
{
    Console.WriteLine("A frase possui 1 vogal!");
}
else
{
    Console.WriteLine("A frase não possui vogais!");
}