int Max(int arg1, int  arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 26;
int b1 = 42;
int c1 = 56;
int a2 = 11;
int b2 = 3236;
int c2 = 70;
int a3 = 120;
int b3 = 50;
int c3 = 78;

int max = Max(
    Max(a1, b1 ,c1),
    Max(a2, b2 ,c2),
    Max(a3, b3 ,c3));

Console.Write("max = ");
Console.WriteLine(max);