var soma = 0;
    System.Console.WriteLine("Digite 5 numeros: ");

for(int i = 1; i <=5; i++)
{
    var number = int.Parse(Console.ReadLine());
    soma = soma + number;
}

System.Console.WriteLine($"A soma é: {soma}");