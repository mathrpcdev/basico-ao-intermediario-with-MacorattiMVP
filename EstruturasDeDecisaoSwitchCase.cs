/*
Author: Matheus Cavalcante
Exercício: Estruturas de desisão / Controle de Fluxo.
 */

string carro;
string fabricante;

Console.WriteLine("Por favor, nos diga a marca de seu carro.");
carro = Console.ReadLine();

switch (carro)
{
    case "Punto":
    case "Uno":
    case "Palio":
        fabricante = "Fiat";
        break;
    case "Spin":
    case "Tracker":
    case "Camaro":
        fabricante = "Chevrolet";
        break;
    case "Frontier":
    case "Kiks":
    case "Versa":
        fabricante = "Nissan";
        break;
    case "Civic":
    case "Fit":
    case "City":
        fabricante = "Honda";
        break;
    default:
        fabricante = "Desconhecido.";
        break;
}

Console.WriteLine($"De acordo com a marca de seu carro, a fabricante dele é {fabricante}");
