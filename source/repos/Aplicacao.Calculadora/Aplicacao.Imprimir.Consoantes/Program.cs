// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string frase = "";
char[] consoantes = new char[1];

int contador = 0;


Console.WriteLine("Digite uma frase:");
frase = Console.ReadLine();

for (int i = 0; i < frase.Length; i++)
{
    switch (frase[i])
    {
        case 'b':
            consoantes[contador] = 'b';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'c':
            consoantes[contador] = 'c';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'd':
            consoantes[contador] = 'd';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'f':
            consoantes[contador] = 'f';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'g':
            consoantes[contador] = 'g';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'h':
            consoantes[contador] = 'h';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'j':
            consoantes[contador] = 'j';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'k':
            consoantes[contador] = 'k';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'l':
            consoantes[contador] = 'l';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'm':
            consoantes[contador] = 'm';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'n':
            consoantes[contador] = 'n';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'p':
            consoantes[contador] = 'p';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'q':
            consoantes[contador] = 'q';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'r':
            consoantes[contador] = 'r';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 's':
            consoantes[contador] = 's';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 't':
            consoantes[contador] = 't';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'v':
            consoantes[contador] = 'v';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'w':
            consoantes[contador] = 'w';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'x':
            consoantes[contador] = 'x';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'y':
            consoantes[contador] = 'y';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;
        case 'z':
            consoantes[contador] = 'z';
            Array.Resize(ref consoantes, consoantes.Length + 1);
            contador++;
            break;

        default:
            break;
    }
}

if (contador >= 1)
{
    string vogaisS = string.Join(", ", consoantes);
    Console.WriteLine("A frase possui essas consoantes: " + vogaisS);
}
else
{
    Console.WriteLine("A frase não possui vogais!");
}