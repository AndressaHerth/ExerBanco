using ExerBanco;
using System.Globalization;

ContaBancaria conta;

Console.Write("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre com o titular da conta: ");
string nome = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? " );
char resp = char.Parse(Console.ReadLine());  
    if(resp == 's' || resp == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, nome, depositoInicial);

}
    else
{
    conta = new ContaBancaria (numero, nome);
}

Console.WriteLine();
Console.Write("Dados da conta: ");
Console.WriteLine(conta);

Console.WriteLine();

Console.Write("Entre um valor para depósito: ");
double  quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);

Console.WriteLine();

Console.WriteLine("Dados da conta atualizados: " + conta);

Console.WriteLine();

Console.Write("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);

Console.WriteLine();

Console.Write("Dados da conta atualizados: " + conta);