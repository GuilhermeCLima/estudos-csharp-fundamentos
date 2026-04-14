var leave = 0;
var par = 0;
var impar = 0;
do {
System.Console.WriteLine("Digite numeros, para sair digitar 0:");
var numeros = int.Parse(Console.ReadLine());

    if(numeros%2 == 0 && numeros !=0)
    {
        par +=1;
    }
    else if (numeros%2 != 0 && numeros !=0)
    {
        impar +=1;
    } else
    {
        leave = 1;
    }
}
while(leave == 0);

Console.WriteLine($"Tem: {par} pares e {impar} impares");
