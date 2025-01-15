Console.WriteLine("Insira a nota do aluno abaixo:");
double num = double.Parse(Console.ReadLine());

Console.Clear();

bool excelente = (num >= 9);
bool boa = (num < 9 && num >= 7);
bool regular = (num < 7 && num >= 5);

if (excelente == true) {
    Console.WriteLine("Excelente.");
} else if (boa == true) {
    Console.WriteLine("Boa.");
} else if (regular == true) {
    Console.WriteLine("Regular.");
} else {
    Console.WriteLine("Baixa.");
}

//Corrigido, mas correto