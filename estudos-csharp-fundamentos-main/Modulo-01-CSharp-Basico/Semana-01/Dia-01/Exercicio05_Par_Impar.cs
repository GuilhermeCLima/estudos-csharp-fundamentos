int n = 1;

do{
Console.WriteLine("Digite um número:");
var numero = int.Parse(Console.ReadLine());
n = numero;

if(numero%2==0)System.Console.WriteLine("O numero é Par");
else System.Console.WriteLine("O numero é impar");
} 
while(n ==1);



