Console.WriteLine("Digite o preço do produto");
var precoProduto  = decimal.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o valor que foi dado:");
var valorPago  = decimal.Parse(Console.ReadLine());

if(precoProduto<= valorPago) 
{
    var troco = valorPago - precoProduto;
    System.Console.WriteLine($"O troco é: R${troco}");
}
else
{
    var troco = precoProduto - valorPago;
    System.Console.WriteLine($"Falta R${troco}");
}
