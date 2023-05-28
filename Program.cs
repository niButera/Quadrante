Console.Clear();

Console.WriteLine(@"     --- Quadrante Cartesiano ---
Forneça as coordenadas (apenas números)");

Console.WriteLine();

Console.Write("Coordenada X: ");
int X = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Coordenada Y: ");
int Y = Convert.ToInt32(Console.ReadLine()!);

if (X == 0 && Y == 0) 
{
    Console.WriteLine();
    Console.WriteLine($"O ponto ({X}, {Y}) fica na origem");
}

else if (X > 0 && Y > 0)
{
    Console.WriteLine();
    Console.WriteLine($"O ponto ({X}, {Y}) fica no quadrante I");
}

else if (X < 0 && Y > 0)
{
    Console.WriteLine();
    Console.WriteLine($"O ponto ({X}, {Y}) fica no quadrante II");
}

else if (X < 0 && Y < 0)
{
    Console.WriteLine();
    Console.WriteLine($"O ponto ({X}, {Y})fica no quadrante III");
}

else if (X > 0 && Y < 0)
{
    Console.WriteLine();
    Console.WriteLine($"O ponto ({X}, {Y}) fica no quadrante IV");
}

else if (X == 0)
{
    Console.WriteLine();
    Console.WriteLine($"O ponto ({X}, {Y}) fica no eixo X");
}

else if (Y == 0)
{
    Console.WriteLine();
    Console.WriteLine($"O ponto ({X}, {Y}) fica no eixo Y");
}

Console.WriteLine();