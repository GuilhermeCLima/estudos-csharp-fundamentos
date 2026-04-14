var repeticao = 0;
var qtd = 0;
var soma = 0;
System.Console.WriteLine("Digite notas:");
do
{   
    var nota = int.Parse(Console.ReadLine());
    
    if (nota != -1)
    {
    soma += nota;
    qtd = qtd + 1;
    System.Console.WriteLine($"a soma é: {soma}");
    System.Console.WriteLine($"a quantidade foi: {qtd}");
    }else repeticao = nota;
} while(repeticao != -1);

Console.WriteLine($"A média é: {soma /qtd}");