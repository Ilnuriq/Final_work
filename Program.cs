string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "Rus",
"-2", "computer science", "Russia", "Denmark", "Kazan", "GB", "GBU" };
int count = ArrayCheck(array);
string[] resultArray = FillResultArray(array, count);
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}