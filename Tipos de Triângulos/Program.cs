//Início
Console.WriteLine("--- Tipos de Triâgulos ---");

//Declaração de variáveis
float lado_1, lado_2, lado_3;

//Entrada de dados e operações

Console.WriteLine("\nInsira os valores positivos para cada lado do triângulo: ");

do
{
    Console.Write("Lado 1: ");
    lado_1 = float.Parse(Console.ReadLine());
} while (lado_1 < 0);

do
{
    Console.Write("Lado 2: ");
    lado_2 = float.Parse(Console.ReadLine());
} while (lado_2 < 0);

do
{
    Console.Write("Lado 2: ");
    lado_3 = float.Parse(Console.ReadLine());
} while (lado_3 < 0);

if (lado_1 == lado_2 || lado_1 == lado_3 || lado_2 == lado_3)
{
    Console.WriteLine("Esse é um triângulo ISÓCELES, pois possui dois lados com medidas iguais.");
}
else
{
    if (lado_1 == lado_2 && lado_1 == lado_3 && lado_2 == lado_3)
    {
        Console.WriteLine("Esse é um triâgulo EQUILÁTERO, pois possui todos os lados com medidas iguais");
    }
    else
    {
        Console.WriteLine("\nEsse é um triângulo ESCALENO, pois possui lados diferentes.");
    }
}

//Final
Console.WriteLine("\nPressione ENTER para encerrar...");
Console.ReadKey();