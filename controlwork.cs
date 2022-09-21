string[] array1 = new string[4] {"one", "two", "four", "seven"};
string[] array2 = new string[array1.Length];
void ACT_1(string[] array1, string[] array2)
{
    int ElementArray = 0;
    for (int Leng = 0; Leng < array1.Length; Leng++)
    {
    if(array1[Leng].Length<= 3)
        {
        array2[ElementArray] = array1[Leng];
        ElementArray++;
        }
    }
}
void result(string[] array)
{
    for (int Leng = 0; Leng < array.Length; Leng++)
    {
        Console.Write($"{array[Leng]} ");
    }
    Console.WriteLine();
}
ACT_1(array1, array2);
result(array2);