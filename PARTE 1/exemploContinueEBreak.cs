while (true) // Enquanto for verdadeiro...
{
    Console.WriteLine("Digite um número:");
    int valor = int.Parse(Console.ReadLine());
    if ((valor % 3) == 0)
    {
        continue; // Se for divisível por 3, irá continuar o bloco WHILE.
    }
    if ((valor % 5) == 0)
    {
        break; // Se for divisível por 5, irá encerrar o bloco WHILE.
    }
    Console.WriteLine("O número não é divisível por 3 ou 5.");
}
Console.WriteLine("O número é divisível por 5.");
