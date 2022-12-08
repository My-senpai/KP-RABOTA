/* Написать программу, которая из имеющегося массива сторок формирует массив из строк, длина которых
не превышает 3 символа. Первоначальный массив задается любым способом. 
При решении желательно обойтись только массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "cjmputer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/
System.Console.Write($"изначальный массив - [cat] [526] [%%%23] [^&@91] [5] ===> получается массив");



string[] firstArray = new string[] { "cat", "526", "%%%23", "^&@91", "5" };
for (int i = 0; i < firstArray.Length; i++)
{
    int x = firstArray[i].Length;
    if (x <= 3)
    {
        string[] secondArray = firstArray;
        System.Console.Write($" [{secondArray[i]}] ");
    }
    
}









