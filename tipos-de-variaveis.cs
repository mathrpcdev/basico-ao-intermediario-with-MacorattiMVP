using System;

//********************      EXERCÍCIOS COM BASE NO CURSO MARCORATTI - TIPOS DE VARIÁVEIS         ******************************
namespace tiposVariaveis
{
    class bola
    {
        static void Main(string[] args)
        {
            //----  ÁREA DO CÍRCULO     A = PI * RAIO * RAIO
            // ----->  AUTOR: MATHEUS CAVALCANTE

            double raioDoCirculo,
                areaDoCirculo;

            // *************   CONSTANTES USAM LETRAS MAIÚSCULAS     *************
            const double PI = 3.1416;
            raioDoCirculo = 10.0;

            //1.0 = 1.0 * PI    (3.14)
            areaDoCirculo = (raioDoCirculo * raioDoCirculo * PI);
            Console.WriteLine("A área do círculo é: " + areaDoCirculo);

            //  ----------------->> VARIÁVEIS USANDO STRINGS

            string firstName = "Ronaldinho";
            string secondName = " Gaúcho.";

            int a = 10;
            int b = 40;

            Console.WriteLine(
                "The best soccer player in the wolrd is called " + firstName + secondName + "\n"
            );
            Console.WriteLine("O valor de a + b é = " + (a + b));
        }
    }
}
