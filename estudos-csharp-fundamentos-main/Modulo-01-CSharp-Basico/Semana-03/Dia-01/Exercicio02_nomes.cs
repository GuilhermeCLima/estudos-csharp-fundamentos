var nomesList = new List<string>();
var saida = 0;
System.Console.WriteLine("Digite nomes, para sair deixar em branco");
do
{
    var nome = Console.ReadLine();

    if (!string.IsNullOrEmpty(nome))
        {
            nomesList.Add(nome);
        }
    else
        {
            saida = 1;
        }
}while(saida == 0);

foreach (var n in nomesList)
	Console.WriteLine(n);