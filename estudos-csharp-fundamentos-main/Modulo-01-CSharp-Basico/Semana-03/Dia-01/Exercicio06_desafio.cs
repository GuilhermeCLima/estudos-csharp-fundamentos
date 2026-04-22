using System.ComponentModel.Design;
using System.Diagnostics;

var productList = new List<string>();
var priceList = new List<decimal>();
var sair = 0;

do
{
    System.Console.WriteLine("\nDigite o nome do produto:");
    var produto = Console.ReadLine();

    System.Console.WriteLine("\nDigite o preço do produto:");
    if (!decimal.TryParse(Console.ReadLine(), out decimal price)) {
        Console.WriteLine("Preço inválido! Tente novamente.");
        continue;
    }
    
    if (!string.IsNullOrEmpty(produto))
    {
        productList.Add(produto);
        priceList.Add(price);
    }
    System.Console.WriteLine("Deseja adicionar algum mais s / n");
    var choice = Console.ReadKey().KeyChar;

   if (choice == 'n' || choice == 'N')
    {
        sair = 1;
    }
    
}while(sair == 0);

sair = 0;
do
{
    System.Console.WriteLine("\nDeseja (1) listar| (2) remover por nome | (3) totalizar | (4) sair");
    var menu = Console.ReadKey().KeyChar;
    switch (menu)
    {
        case '1':
        for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"\n{productList[i]}: R$ {priceList[i]:N2}");
            }
            break;

        case '2':
            System.Console.WriteLine("\nDigite qual nome remover:");
            var nome = Console.ReadLine();

            if (!string.IsNullOrEmpty(nome) && productList.Contains(nome))
            {
                var index = productList.IndexOf(nome);
                productList.RemoveAt(index);
                priceList.RemoveAt(index);
                System.Console.WriteLine("Removidos com sucesso!!");
                 System.Console.WriteLine("\nOs produtos são:");
        foreach(var n in productList)
            {
                System.Console.WriteLine(n);
            }
            System.Console.WriteLine("\nOs preços são:");
        foreach(var p in priceList)
            {
                System.Console.WriteLine(p);
            }
            }
            break;
            case '3':
            var total = priceList.Sum();
                System.Console.WriteLine($"\nO preço total dos produtos é: R$ {total:N2}");
            break;
            
            case '4': 
            sair = 1;
            break;
    }
}while(sair == 0);