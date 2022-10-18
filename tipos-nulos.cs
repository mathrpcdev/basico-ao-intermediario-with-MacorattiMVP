using System;

// AUTHOR: MATHEUS CAVALCANTE
//  ------>>   Os tipos por valor como : int, double, float, struct,enum, etc NÃO PODEM SER ANUÁVEIS (NON-NULLABLES), por padrão.
// PS: Outros types são:  Interfaces, Classes, delegates, arrays, strings, etc já aceitão tipos nulos por padrão.
class Program
{
    static void Main(string[] args)
    {
        // ************************  AULA SOBRE NULLABLE TYPES  ***********************
        // A SINTAXE TIPO? = NULL  É FEITA PARA RECEBER VALORES NÚLOS (OU NÃO). SERVE PARA TOMADAS DE DECISÃO E RETORNAR TRUE OR FALSE CASO ANULÁVEL.
        String nome = null;
        int? valor1 = null;
        Nullable<int> valor2 = null;
        Console.WriteLine(nome);

        int? valor = 100; //DECALRAÇÃO IMPLÍCITA
        int valInt = (int)valor; //DECALRAÇÃO EXPLÍCITA [É UTILIZADO O CASTING]

        Console.WriteLine("Declaração implícita/explícita de nullable type --> " + valor + "\n");

        //Outro exercício.
        double? meuValor = 99;
        if (meuValor != null)
        {
            // AQUI NÃO IMPRIME NADA POIS O meuValor é um double?, ou seja, é um tipo que comporta o null.
            Console.WriteLine("{0}", meuValor);
        }

        int? mInteiro1 = 28; //  Valor implícito
        int? mInteiro2 = mInteiro1; //  aqui está recebendo um Nullable type, pois mInteiro1 = int?.
        int? mInteiro3 = null; // null

        Console.WriteLine("mInteiro1: {0}, mInteiro2: {1}", mInteiro1, mInteiro2);
        Console.WriteLine();

        //Outro exercício.
        Console.WriteLine("Usando o VALUE: \n");
        int? n = 10;
        int m2 = (int)n; // fazendo casting de um tipo Nulo para non-nullable.
        int m3 = n.Value;
        Console.WriteLine((n, m2, m3));

        // -------------------------------------------------------------
        Console.WriteLine(" --------------------------------------------------------- \n");
        Console.WriteLine("Verificando se a data de nascimento foi definida...");
        DateTime? dataNascimento = DateTime.Now;
        // -->> Has.Value retorna um valor TRUE caso a variáveu tenha um valor e FALSE caso seja null.
        if (dataNascimento.HasValue)
        {
            Console.WriteLine("A data de Nascimento foi definida.");
        }
        else
        {
            Console.WriteLine("A data de nascimento é null.");
        }
        try
        {
            Console.WriteLine(dataNascimento.HasValue);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
