var itensList = new List<string>();
var saida = 0;
System.Console.WriteLine("Digite itens, para sair deixe vazio");
do
{
    var item = Console.ReadLine();

    if (!string.IsNullOrEmpty(item))
        {
            itensList.Add(item);
        }
    else
        {
            saida = 1;
        }
}while(saida == 0);

System.Console.WriteLine("Digite qual item quer remover");
var remove = Console.ReadLine();

if (!string.IsNullOrEmpty(remove) && itensList.Contains(remove))
{
    itensList.Remove(remove);
    System.Console.WriteLine("Item removido com sucesso!");
}
else
{
    System.Console.WriteLine("Não existe esse item");
}
foreach(var n in itensList)
{
    System.Console.WriteLine(n);
}