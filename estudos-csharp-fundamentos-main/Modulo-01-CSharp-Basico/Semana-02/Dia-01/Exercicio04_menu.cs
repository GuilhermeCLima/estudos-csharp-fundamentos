var leave = 0;

do {
System.Console.WriteLine("\n Digite a opção: (1)Soma (2)Subtração (3)Sair");
var option = int.Parse(Console.ReadLine());
var num1 = 0;
var num2 = 0;
switch(option)
{
    case 1:
    System.Console.WriteLine("Digite o primeiro numero: ");
     num1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite o segundo numero: ");
     num2 = int.Parse(Console.ReadLine());

    Console.Write($"A soma é: {num1+num2}");
    break;

    case 2:
    System.Console.WriteLine("Digite o primeiro numero: ");
     num1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite o segundo numero: ");
     num2 = int.Parse(Console.ReadLine());

    Console.Write($"A subração é: {num1-num2}");
    break;

    case 3: 
    leave = 3;
    break;
}
}
while(leave !=3);
