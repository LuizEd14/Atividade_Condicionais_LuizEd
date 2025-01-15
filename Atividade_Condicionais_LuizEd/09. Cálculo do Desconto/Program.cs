Console.WriteLine("Insira qualquer preço abaixo:");
int num = int.Parse(Console.ReadLine());

double descon = num * 0.1;
double num_com_descon = num - descon;

Console.WriteLine("Valor original: {0}", num);
Console.WriteLine(" ");
Console.WriteLine("Valor com desconto: {0}", num_com_descon);

//Correto