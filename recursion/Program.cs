void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

    Console.WriteLine();
}

int [] mass = new int [4];//задаём массив

for (int i=0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 10);//случайный диапазон массива от 0 до 10
}

Print(mass);

int save;
for (int i = 0; i < mass.Length/2; i++)
{
    /* save = mass[i];
    mass[mass.Length - 1 - i] = save; */
    (mass[i], mass[mass.Length - 1 - i]) = (mass[i] = mass[mass.Length - 1 - i], mass[i]);
}

Print(mass);
123415