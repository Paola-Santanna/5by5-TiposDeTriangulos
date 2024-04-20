Console.WriteLine("--- Tipos de Triâgulos ---");

float lado_1, lado_2, lado_3;

//Entrada de dados e operações
Console.WriteLine("\nOs Triângulos devem ter medidas POSITIVAS e DIFERENTES DE ZERO!");
Console.WriteLine("\nInsira os valores para cada lado do triângulo: ");

do
{
    Console.Write("Lado 1: ");
    lado_1 = float.Parse(Console.ReadLine());
} while (lado_1 < 0 || lado_1 == 0);

Console.WriteLine("\n");
do
{
    Console.Write("Lado 2: ");
    lado_2 = float.Parse(Console.ReadLine());
} while (lado_2 < 0 || lado_2 == 0);

Console.WriteLine("\n");
do
{
    Console.Write("Lado 3: ");
    lado_3 = float.Parse(Console.ReadLine());
} while (lado_3 < 0 || lado_3 == 0);

if (lado_1 == lado_2 || lado_1 == lado_3 || lado_2 == lado_3)
{
    Console.WriteLine("\nEsse é um triângulo ISÓCELES, pois possui dois lados com medidas iguais.");
}
else
{
    if (lado_1 == lado_2 && lado_1 == lado_3 && lado_2 == lado_3)
    {
        Console.WriteLine("\nEsse é um triâgulo EQUILÁTERO, pois possui todos os lados com medidas iguais");
    }
    else
    {
        Console.WriteLine("\nEsse é um triângulo ESCALENO, pois possui lados diferentes.");
    }
}

//Final
Console.WriteLine("\nPressione ENTER para encerrar...");
Console.ReadKey();