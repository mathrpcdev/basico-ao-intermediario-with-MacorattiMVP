/*
Author: Matheus Cavalcante
Exercício: Estruturas de repetição  do while e while.
 */

// A verificação no ' do while ' é feita após a execução, diferentemente do ' while '.

int j = 10;
do
{
    Console.WriteLine($"Numero {j}");
    j--;
} while (j > 0);

// Aqui a verificação é feita antes.
int i = 0;

while (i < 10)
{
    Console.WriteLine($"i = {i}");
    i++;
}

// Essa estrutura de repetição não é uma boa prática e foi herdada do Visual Basic.
// goto não deve mais ser usado!
int contador = 0;
repeat: // <-- Isso é chamado de Label.
Console.WriteLine($"Contador é igual a = {contador}");
contador++;
if (contador < 10)
    goto repeat;
