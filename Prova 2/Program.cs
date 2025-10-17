
decimal n1, n2, n3;
decimal p1, p2, p3;
decimal media;
p1 = 1;
p2 = 2;
p3 = 3;



Console.WriteLine("Digite a 1° nota:\n");
n1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite a 2° nota:\n");
n2 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite a 3° nota:\n");
n3 = decimal.Parse(Console.ReadLine());

media = ((n1 * p1) + (n2 * p2) + (n3 * p3)) / (p1 + p2 + p3);
if (media >= 7)
{
    Console.WriteLine($"Sua média é {media} Você está aprovado");
}
else if (media < 7 & media > 5)
{
    Console.WriteLine($"Sua média é {media} Você está de recuperação");
}
else if (media <= 5)
    {
    Console.WriteLine($"Sua média é {media} Você está reprovado");

    }