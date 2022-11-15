/*
É necessário lembrar que no exercício não foi utilizado o mecanismo String template, ou seja, usar Cifrão seguida de Aspas duplas para conseguir
interpolar strings de modo a conseguir inserir uma variável qualquer dentro de {chaves}. Macoratti utiliza a forma antiga.
*/

bool valor = true;

if (valor == true)
{
    Console.WriteLine(" O valor é {0}", valor);
}

int a,
    b;
a = 7;
b = 7;

if (a < b)
{
    Console.WriteLine("A é menor que B");
    Console.WriteLine("O valor de A é: {0}", a);
    Console.WriteLine("O valor de B é: {0}", b);
}
else if (a > b)
{
    Console.WriteLine($"A é maior que B, que vale: {0}", b);
    Console.WriteLine("O valor de A é: {0}", a);
    Console.WriteLine("O valor de B é: {0}", b);
}
else
{
    Console.WriteLine("A é igual a B: {0}", b);
    Console.WriteLine("O valor de A é: {0}", a);
    Console.WriteLine("O valor de B é: {0}", b);
}
