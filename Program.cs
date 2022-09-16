//Задача 25
static void num25(){
    Console.WriteLine("введите число A");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число B");
    int b = Convert.ToInt32(Console.ReadLine());
    int step = a;

    for (int i = 1; i < b; i++)
    {
    step = step * a;
    }
    Console.WriteLine("A в степени B равно: " + step);
}
//Задача 27
static void num27(){
    Console.WriteLine("введите число");
    int i = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (i > 0)
    {
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
    }
    Console.WriteLine("сумма всех цифр в числе равна: " + sum);
}

//Задача 29
static void num29(){
    Console.WriteLine("Введите размер массива");
    int N = Convert.ToInt32(Console.ReadLine());
    int [] numbers = new int[N];
    int index = 1;
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write("Введите элемент №" + index + ": ");
        numbers [i] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}

num25();
num27();
num29();