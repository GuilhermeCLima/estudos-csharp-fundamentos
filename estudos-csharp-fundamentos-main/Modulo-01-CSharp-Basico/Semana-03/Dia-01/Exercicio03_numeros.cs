var numerosList = new List<int>();
var saida = 0;
System.Console.WriteLine("Digite numeros, para sair coloque 0");
do
{
    var numeros = int.Parse(Console.ReadLine());

    if (numeros !=0)
        {
            numerosList.Add(numeros);
        }
    else
        {
            saida = 1;
        }
}while(saida == 0);

var maximo = numerosList.Max();
var minimo = numerosList.Min();

	Console.WriteLine($"O numero maximo é: {maximo}");
    Console.WriteLine($"O numero minimo é: {minimo}");