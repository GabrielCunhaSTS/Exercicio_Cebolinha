string frase;

Console.WriteLine("Oi! Eu me chamo Cebolinha, digite alguma flase para eu lepetir: ");
frase = Console.ReadLine();
frase = frase.Replace("r", "l");
Console.Write(frase);