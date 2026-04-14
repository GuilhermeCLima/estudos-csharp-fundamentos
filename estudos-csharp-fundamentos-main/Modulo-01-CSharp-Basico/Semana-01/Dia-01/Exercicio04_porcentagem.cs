Console.WriteLine("Digite o preço");
var preco = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite a porcentagem: ");
var porcentagem = decimal.Parse(Console.ReadLine());

var precofinal = (preco - (preco * (porcentagem / 100)));
Console.WriteLine($"O preço com o cupom é: R${precofinal}");



