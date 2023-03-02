// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string frase = "";
char[] vogais = new char[1];

int contador = 0;


Console.WriteLine("Digite uma frase:");
frase = Console.ReadLine();

for (int i = 0; i < frase.Length; i++)
{
    switch (frase[i])
    {
        case 'a':
            vogais[contador] = 'a';
            Array.Resize(ref vogais, vogais.Length + 1);
            contador++;
            break;
        case 'e':
            vogais[contador] = 'e';
            Array.Resize(ref vogais, vogais.Length + 1);
            contador++;
            break;
        case 'i':
            vogais[contador] = 'i';
            Array.Resize(ref vogais, vogais.Length + 1);
            contador++;
            break;
        case 'o':
            vogais[contador] = 'o';
            Array.Resize(ref vogais, vogais.Length + 1);
            contador++;
            break;
        case 'u':
            vogais[contador] = 'u';
            Array.Resize(ref vogais, vogais.Length + 1);
            contador++;
            break;
        default:
            break;
    }
}

if (contador >= 1)
{
    string vogaisS = string.Join(", ", vogais);
    Console.WriteLine("A frase possui essas vogais: " + vogaisS + " vogais!");
}
else
{
    Console.WriteLine("A frase não possui vogais!");
}