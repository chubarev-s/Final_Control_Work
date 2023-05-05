// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


// Метод ввода длины массива
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
//Метод заполнения массива
string[] Gen1DArray(int len)
{
    string[] res = new string[len];
    for (int i = 0; i < len; i++)
    {
        Console.Write("Введите элемент массива: ");
        string name = (string)(Console.ReadLine() ?? "0");
        res[i] = name;
    }
    return res;
}


//Метод печати одномерного массива
void Print1Darray(string[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Метод подсчёта 
void ElementCount(string[] arr, int len)
{
    int buf_len = 0;
    int count = 0;
    string[] res = new string[len];  //создаём смежный массив
    for (int i = 0; i < len; i++)
    {
        buf_len = arr[i].Length;
        if (buf_len < 4)            //выборка эл-тов, длина которых не более 3х символов
        {
            res[i] = arr[i];
            count++;                    //узнаём кол-во эл-тов нужной длины
        }
        else
        {
            res[i] = "9999";        //чтобы избежать заполнение нулями, заполняем любыми символоми, но более 3х
        }
    }
    string[] arr_max3 = new string[count];      //смежный массив с нужным кол-вом эл-тов
    for (int i = len - 1; i >= 0; i--)          //заполнение итогового массива
    {
        buf_len = res[i].Length;
        if (buf_len < 4)                           
        {
            arr_max3[count - 1] = res[i];
            count--;
        }
    }
    Console.WriteLine("Выборка из эл-тов массива строк, длина которых меньше, либо равна 3 символам: ");
    Print1Darray(arr_max3);
}

//Вводим длину массива
int len = ReadData("Введите длину массива: ");
//Формируем массив
string[] Arr = Gen1DArray(len);
//Производим выборку
ElementCount(Arr, len);