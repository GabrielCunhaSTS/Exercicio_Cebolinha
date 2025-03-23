string frase;
bool temNumero = false;

Console.Write("Oi! Eu me chamo Cebolinha, digite alguma flase para eu lepetir: ");

while (true)
{
    frase = Console.ReadLine()!;

    foreach (char c in frase)
    {
        if (char.IsDigit(c))
        {
            temNumero = true;
            break;
        }
    }

    if (!temNumero) break;

    Console.Write("Digite uma flase coleta (sem númelos): ");
}

frase = frase.Replace("r", "l").Replace("R", "L");

Console.Write(frase);
