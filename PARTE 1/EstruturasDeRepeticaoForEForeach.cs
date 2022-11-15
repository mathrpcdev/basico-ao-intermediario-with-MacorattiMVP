//O foreach é utilizado para percorrer arrays e lists.

int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach (int number in numeros) // A cada 'variável' no 'array', imprima...
{
    Console.WriteLine(number);
}

// O ' for ' é utilizado quando sabemos exatamente a quantidade de repetições que iremos usar.
for (int counter = 0; counter <= 40; counter++)
{
    Console.Write($"{counter} - ");
    //  Irá dividir a variável por 10 e depois irá verificar se o resto é igual a 0.
    //     Ex:
    //     if(i % 10 == 0)  --> Significa que 10 é divisível por i, pois restou zero.

    if (counter % 10 == 0)
    {
        // \t é o caracter de tabulação.
        Console.WriteLine($"\t\t{counter}");
    }
}
