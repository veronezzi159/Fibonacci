int num = 0, count = 0; 
do {
    Console.WriteLine("Digite um numero inteiro, para que a sequência pare nele");
    num = int.Parse(Console.ReadLine());
} while (num < 1);
int[] fibonacci = new int[num];

for (int i = 0; count < num; i++)
{
    if (i == 0 || i == 1)
    {
        fibonacci[i] = 1;
        count++;
    } else
    {
        fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
        count++;
    }
}
Console.WriteLine($"A sequência de {num} numeros é: ");
for (int i = 0; i < num; i++)
{
    Console.WriteLine(fibonacci[i]);
}