void FillArray(int[] collection)
{
    int Length =  collection.Length;
    int index = 0;
    while (index<Length)
    {
        collection[index]= new Random().Next(1,10);
        index++;
    }
}
void PrintArray (int[] collect)
{
    int LenCollect = collect.Length;
    int position = 0;
    while (position < LenCollect)
    {
        Console.WriteLine(collect[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find )
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        } 
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 8);
Console.WriteLine(pos);