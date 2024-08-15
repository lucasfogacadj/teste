int x, y;
double divisao;
Console.WriteLine("Digitar o valor de X:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor de y");
y = Convert.ToInt32(Console.ReadLine());

divisao = (double) x / y;

Console.WriteLine($"O valor da divisao entre {x} e {y} é igual a: {divisao}");


