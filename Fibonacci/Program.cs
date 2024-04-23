int num = 0, penultimo = 0, ultimo = 1, atual = 0; 
do {
    Console.WriteLine("Digite um numero inteiro, para que a sequência pare nele");
    num = int.Parse(Console.ReadLine());
} while (num < 1);


for (int i = 0; i < num; i++)
{
    if (i != 0 && i!= 1)
    {
        atual = penultimo + ultimo;
        penultimo = ultimo;
        ultimo = atual;
    } else
    {
        atual = i;
    }
    Console.Write(atual + " ");
}