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
    string[] res=new string[len];
    for(int i=0; i<len; i++)
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
    string[] res = new string[len];
    for(int i = 0; i<len; i++)
    {
        buf_len = arr[i].Length;  
        if(buf_len <4)
        {
            res[i] = arr[i];
        }
    }
    Print1Darray(res);
}

int len = ReadData("Введите длину массива");
string[] Arr = Gen1DArray(len);
ElementCount(Arr, len);