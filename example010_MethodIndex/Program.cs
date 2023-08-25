int [] array = {1, 2, 4, 56, 65, 23, 43, 85, 30};
int n = array.Length;
int find = Console.ReadLine();
int index = 0;
while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
    }
    index++;
}