int numeroDigitado;

Console.Write("Digite um número:  ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

bool numeroEhPAr = (numeroDigitado % 2 ) == 0; 

if (numeroEhPAr)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"{numeroDigitado} é par");
}
else 
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine($"{numeroDigitado} é ímpar");
}

Console.ResetColor();
