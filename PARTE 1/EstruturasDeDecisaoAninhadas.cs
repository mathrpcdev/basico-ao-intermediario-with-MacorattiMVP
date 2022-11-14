/* 
Author: Matheus Cavalcante
Exercício: Controle de fluxo.
 */

int numero;
Console.WriteLine("Informe um número entre 0 e 10: ");
numero = int.Parse(Console.ReadLine());

if (numero > 10)
{
    Console.WriteLine("O número deve estar entre 0 e 10");
}
else
{
    if (numero < 0)
    {
        Console.WriteLine("O número deve ser maior que zero");
    }
    else
    {
        Console.WriteLine($"O número digitado foi: {numero}");
    }
}

int numero2;

Console.WriteLine($"DIGITE UM NUMERO DE 1 À 100");
numero2 = int.Parse(Console.ReadLine());

if (numero2 > 100)
{
    Console.WriteLine($"O valor digitado precisa estar entre 1 e 100");
    Console.WriteLine($"O valor digitado foi: {numero2}");
}
else if (numero2 <= 0)
{
    Console.WriteLine($"O número está muito abaixo do que foi requisitado.");
    Console.WriteLine($"O número digitado foi: {numero2}");
}
else
{
    if ((numero2 > 0) || (numero2 <= 100))
    {
        Console.WriteLine("Obrigado por responder!");
        Console.WriteLine($"O número digitado foi: {numero2}");
    }
}
