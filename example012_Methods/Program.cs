// ViD 1

void Method1()
{
    Console.WriteLine("PRIVET");
}
//Method1();




//Vid 2
void Method2( string msg, int i )
{
    int count = 0;
    while (count < i)
    {
        Console.WriteLine(msg);
        count++;
    }
}
// Method2(msg: "You god den rite", i: 6);





// VID 3

int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);




// VID 4
string Method4(int count, string msg)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + msg;
        i++;
    }
    return result;
}
//string res = Method4(msg: "HelloWorld ", count: 3);
//Console.WriteLine(res);



string Method5(int count, string msg)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + msg;
    }
    return result;
}
//string res = Method5(msg: "HelloWorld555 ", count: 3);
//Console.WriteLine(res);



//for (int i = 2; i <= 10; i++)
{
    //for (int j = 0; j <= 10; j++)
    {
        //Console.WriteLine($"{i} x {j} = {i*j}");
    }
    //Console.WriteLine();
}






// Дан текст. В ткстк нужно все пробелы заменить черточками,
// Маленькие "к" заменить на большие "К"
// а большие "С" заменить на маленкие "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прсского короля."
            + "Вы так красноречивыю. Вы дадите мне чаю?";
        
string correctText(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length; 
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
//string newText1 = correctText(text, ' ', '-');
//string newText2 = correctText(newText1, 'к', 'К');
//string newText3 = correctText(newText2, 'С', 'с');
//Console.WriteLine(newText3);










int [] arr = {1, 4, 5, 7, 6, 3, 2};
void WriteArray(int [] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
WriteArray(arr);

void SortArray(int [] array)
{
    int length = array.Length;
    for (int i = 0; i < length-1; i++)
    {
        int MinPos = i; 
        for (int j = i+1; j < length; j++)
        {
            if(array[i] < array[MinPos]) 
            {
                MinPos = j;
            }
        }
        int Temp = array[i];
        array [i] = array[MinPos];
        array[MinPos] = Temp;
    }
    Console.WriteLine(array);
}
SortArray(arr);
