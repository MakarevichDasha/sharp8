// Открывается файл "Inlet.in" для чтения
using System.Text.RegularExpressions;

StreamReader input = new StreamReader("Inlet.in");

// Создается объект StreamWriter для записи в файл "Outlet.out"
StreamWriter output = new StreamWriter("Outlet.out");

// Читается весь текст из файла и сохраняется в строке s
string s = input.ReadToEnd();

// Находятся все слова в строке s
MatchCollection m = new Regex(@"\b\w+\b").Matches(s);

// Если найдены слова, находится самое короткое слово(для этого иф)
if (m.Count > 0)
{
    // мину присваем первое слово из колекции
    Match min = m.First();

    // Проходим с помощью форэч по коллекции для поиска самого короткого слова
    foreach (Match i in m)
        if (i.Length < min.Length) //если находится слово меньше, то оно становится миниальным
            min = i;

    // Выводится длина самого короткого слова
    output.WriteLine(min.Length);
}
else
    // Если слова не найдены, выводится 0
    output.WriteLine(0);

// Закрываются потоки чтения и записи
input.Close();
output.Close();