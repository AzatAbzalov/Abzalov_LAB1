//Задание 1

//Console.WriteLine("Hello, World!");
//string name = Console.ReadLine();
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Hello! {name} через год тебе будет {age + 1}");

//Задание 2

//const double charka = 0.123, shkalik = 0.06;
//string name1, name2, name3;
//int x, y, z, w, temp;


//void PersonalData(out string name, out int a, out int b)
//{
//    Console.WriteLine("Введите имя: ");
//    name = Console.ReadLine();
//    Console.Write("Кол-во чарок = ");
//    a = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Кол-во шкаликов = ");
//    b = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine();
//}

//double Vconvert(int a = 0, int b = 0)
//{
//    return a * charka + b * shkalik;
//}


//bool Proverka(double e)
//{
//    if (0.5 < e & e < 1)
//    {
//        return true;
//    }
//    return false;
//}

//double Maximum3(double a, double b, double c)
//{
//    return Math.Max(Math.Max(a, b), c);
//}

//PersonalData(out name1, out x, out temp);
//PersonalData(out name2, out temp, out y);
//PersonalData(out name3, out z, out w);

//double v1 = Vconvert(x);
//double v2 = Vconvert(0,y);
//double v3 = Vconvert(z, w);

//Console.WriteLine($"\n{name1} выпил {v1} л");
//Console.WriteLine($"{name2} выпил {v2} л");
//Console.WriteLine($"{name3} выпил {v3} л");

//Console.WriteLine("\nИмена тех, кто выпил больше 0,5 л и меньше 1 л ");
//if (Proverka(v1)) Console.WriteLine(name1);
//if (Proverka(v2)) Console.WriteLine(name2);
//if (Proverka(v3)) Console.WriteLine(name3);
//if ((Proverka(v1) | Proverka(v2) | Proverka(v3)) == false) Console.WriteLine("никто не выпил такой объём");

//Console.WriteLine($"\nВсего выпито {v1 + v2 + v3} л");
//Console.WriteLine($"Наибольший из выпитых объёмов = {Maximum3(v1, v2, v3)} л");

//Задание 3
//DateTime current = DateTime.Now;
//DateTime bday = new DateTime();
//Console.Write("Введите вашу дату рождения: ");
//bday = Convert.ToDateTime(Console.ReadLine());
//Console.WriteLine($"Текущая дата: {current}");

//int age = current.Year - bday.Year;
//if (bday > current.AddYears(-age)) age--;
//Console.Write($"Вам {age} ");
//if (age / 10 == 1) Console.WriteLine("лет");
//else if (age % 10 == 1) Console.WriteLine("год");
//else if (age % 10 == 2 | age % 10 == 3 | age % 10 == 4) Console.WriteLine("года");
//else Console.WriteLine("лет");

//Задание 4
//int n;
//Console.Write("Введите кол-во чисел: ");
//n = Convert.ToInt32(Console.ReadLine());
//double[] x = new double[n];
//double[] f = new double[n];

//void Iarray(ref double[] array)
//{
//    Console.WriteLine($"Введите n чисел:");
//    for (int i = 0; i < array.Length; i++)
//        array[i] = Convert.ToDouble(Console.ReadLine());
//}

//void PoiskFx(ref double[] x, ref double[] fx)
//{
//    for (int i = 0; i < x.Length; i++)
//    {
//        if (x[i] < -3) fx[i] = (1 + Math.Pow(x[i], 2)) / (2 * x[i]);
//        else if (x[i] >= Math.PI / 4) fx[i] = 7.0 / 3;
//        else fx[i] = (Math.Pow(x[i], 2) - 3) * Math.Sin(x[i]);
//        fx[i] = Math.Round(fx[i] * 1000) / 1000;
//        if (fx[i] == -0) fx[i] = 0;

//    }
//}

//bool Proverka(double x, double fx)
//{
//    if (Math.Pow(x, 2) + Math.Pow(fx, 2) <= Math.Pow(4, 2) & fx <= -2 * x + 4 & fx >= -x - 4 & x <= 2 & fx >= -4)
//        return true;
//    else return false;
//}

//Iarray(ref x);
//PoiskFx(ref x, ref f);
//Console.WriteLine("\nСоответствующие значения f(x): ");
//for (int i = 0; i < n; i++) Console.WriteLine(f[i]);
//Console.WriteLine("\nТочки попавшие в заштрихованную область:");
//bool check = true;
//for (int i = 0; i < n; i++)
//{
//    if (Proverka(x[i], f[i]))
//    {
//        check = false;
//        Console.Write("{0,-10}", $"x = {x[i]}");
//        Console.WriteLine($"f(x) = {f[i]}");
//    }

//}
//if (check) Console.WriteLine("таких точек нет");

//Задание 5
//int n;
//Console.WriteLine("Введите целое неотрицательное число: ");
//n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Простые числа в промежутке [2, {n}]:");
//bool check = true;
//for (int i = 2; i <= n; i++)
//{
//    bool f = true;
//    for (int j = 2; j < n; j++)
//    {
//        if (i % j == 0)
//        {
//            f = false;
//            break;
//        }
//    }
//    if (f)
//    {
//        Console.Write($"{i}");
//        check = false;
//    }
//}
//if (check) Console.WriteLine("таких чисел нет");

//Задание 6
//const double e = 0.001;
//double a = 0, b = 0.9, x;

//double F(double x) { return Math.Log10(Math.Pow(x, 2) - 3 * x + 2); }
//while (Math.Abs(b-a) > 2 * e)
//{
//    x = (a + b) / 2;
//    if (F(a) * F(x) < 0)
//        b = x;
//    else if (F(x) * F(b) < 0)
//        a = x;
//}
//x = Math.Round((a + b) / 2, 3);
//Console.WriteLine($"x = {x}");

//Задание 7
//int n;
//while (true)
//{
//    Console.WriteLine("Введите количество элементов массива: ");
//    n = Convert.ToInt32(Console.ReadLine());
//    if (n <= 0) Console.WriteLine("Ошибка");
//    else break;
//}

//Console.WriteLine("Введите массив: ");
//int[] array = new int[n];
//for (int i = 0; i < n; i++) 
//    array[i] = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите целое число: ");
//int a = Convert.ToInt32(Console.ReadLine());

//int new_size = 0;
//for (int i = 0; i < n; i++)
//{
//    if (array[i] == a)
//    {
//        new_size++;
//    }
//}

//int[] new_array = new int[array.Length - new_size];
//int b = 0;
//for (int i = 0; i <array.Length; i++)
//{
//    if (array[i] != a)
//    {
//        new_array[b] = array[i];
//        b++;
//    }    
//}

//Console.WriteLine("Конечный массив: ");
//for(int i = 0; i < n-new_size; i++)
//{
//    Console.WriteLine(new_array[i]);
//}

//Задание 8
int x = 70;
int[] array = new int[x];

void RandomArr(ref int[] a)
{
    Random rnd = new Random();
    int x = a.Length;
    Console.WriteLine($"Массив размера {x}:");
    for (int i = 0; i < x; i++)
    {
        a[i] = rnd.Next(-100, 100);
        Console.Write("{0, -5}", $"{a[i]}");
    }
}

void SortArr(ref int[] a)
{
    int x = a.Length, min_ind, temp;
    for (int i = 1; i < x; i += 2)
    {
        min_ind = i;
        for (int j = i + 2; j < x; j += 2)
        {
            if (a[j] < a[min_ind])
                min_ind = j;
        }
        temp = a[i];
        a[i] = a[min_ind];
        a[min_ind] = temp;
    }
}

void PrArr(int[] a)
{
    for(int i = 0; i < a.Length; i++) Console.Write("{0, -5}", $"{a[i]}");
}
RandomArr(ref array);
SortArr(ref array);
Console.WriteLine("\n Отсортированный массив:");
PrArr(array);