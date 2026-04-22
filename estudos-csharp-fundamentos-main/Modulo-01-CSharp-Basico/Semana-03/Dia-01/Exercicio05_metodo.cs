
var listNumeros = new List<double>();
var saida = 0;
System.Console.WriteLine("Digite numeros, digite 0 para sair");
do
{
    var numero = double.Parse(Console.ReadLine());
    if(numero != 0)
    {
        listNumeros.Add(numero);
    }
    else
    {
        saida = 1;
    }
}while(saida ==0);

var soma = CalcularTotal(listNumeros);
static double CalcularTotal(List<double> valores)
{
    return valores.Sum();
}
System.Console.WriteLine($"A soma é: {soma}");
