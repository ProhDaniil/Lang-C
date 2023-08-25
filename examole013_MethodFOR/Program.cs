string Method5(int count, string msg)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + msg;
    }
    return result;
}
string res = Method5(msg: "HelloWorld555 ", count: 3);
Console.WriteLine(res);



for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}