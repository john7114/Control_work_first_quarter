// Описание задачи находится в файле README.md
//
// Решение:
// 1. Ввод значений с клавиатуры. Запись элементов в массив типа string.
// 2. Отобрать из массива элементы, где количество символов равно 3-м или меньше, и записать в новый массив.
// 3. В случае если в первом массиве нет элементов удовлетворящих условию отбора, вывести на экран "[]".
// 4. Вывести новый массив на экран.  

// 1:
Console.WriteLine("Введите слова, числа или символы через пробел");
string str = Console.ReadLine();

string[] strArray = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//2:
string[] secondStrArr = new string[strArray.Length];
int numOfChar;

for (int i = 0; i < strArray.Length; i++)
{
    numOfChar = strArray[i].Length;
    if (numOfChar <= 3)
    {
        secondStrArr[i] = strArray[i];
    }
}

secondStrArr = secondStrArr.Where(x => x != null).ToArray();

// 3:
if (secondStrArr.Length == 0)
{
    Console.WriteLine("[]");
}

// 4:
for (int i = 0; i < secondStrArr.Length; i++)
{
    if (i == secondStrArr.Length - 1)
    {
        Console.Write(secondStrArr[i]);
    }
    else Console.Write("{0}, ", secondStrArr[i]);
}

