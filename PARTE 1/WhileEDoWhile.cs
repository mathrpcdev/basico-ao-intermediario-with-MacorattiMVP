/*
Author: Matheus Cavalcante
Exercício: Estruturas de repetição.
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

/*
// Essa estrutura de repetição não é uma boa prática e foi herdada do Visual Basic.

int i = 0;
repeat: // <-- Isso é chamado de Label.
Console.WriteLine($"i = {i}");
i++;
if (i < 10)
    goto repeat;
 */
