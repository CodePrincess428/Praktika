using System;

namespace zadanie2
{
    class MainClass
    {
        public static string translit(string a)
        {
            string result = "";
            string [] Rus_letters = {"А","Б","В","Г","Д","Е","Ё","Ж","З","И","Й","К","Л","М","Н",
          "О","П","Р","С","Т","У","Ф","Х", "Ц", "Ч", "Ш", "Щ","Ъ", "Ы","Ь",
          "Э","Ю", "Я","а","б","в","г","д","е","ё","ж","з","и","й","к","л","м","н",
          "о","п","р","с","т","у","ф","х", "ц", "ч", "ш", "щ","ъ", "ы","ь",
          "э","ю", "я", " "}; // Словарь с русскими буквами в обоих регистрах
            string[] Eng_letters = {"A","B","V","G","D","E","E","ZH","Z","I","I","K","L","M","N",
          "O","P","R","S","T","U","F","KH","TS","CH","SH","SHCH","IE","Y",null,
          "E","IU","YA","a","b","v","g","d","e","e","zh","z","i","i","k","l","m","n",
          "o","p","r","s","t","u","f","kh","ts","ch","sh","shch","ie","y",null,
          "e","iu","ya"," "}; //Словарь с латинскими буквами для транслитерации в обоих регистрах
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < Rus_letters.Length; j++)
                {
                    if (a.Substring(i,1)== Rus_letters[j]) // Подбор букв для транслитерации, и замена русских букв на латинские
                    {
                        result = result + Eng_letters[j];
                    }
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("#1"); // Поиск второго вхождения буквы f и индекс вхождения
            string stroka = "";
            char find = 'f';
            Console.Write("Введите строку: ");
            stroka = Console.ReadLine(); //Ввод строки
            stroka = stroka.ToLower();
            int count = 0;
            int index = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == find)
                {
                    count++;
                    if (count == 2)
                    {
                        index = i;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("-2");
            } else if (count == 1)
            {
                Console.WriteLine("-1");
            } else if (count > 1)
            {
                Console.WriteLine(index);
            }
            Console.WriteLine("#2");
            Console.WriteLine(translit("яма"));
            Console.WriteLine("#3");
            stroka = "";
            Console.WriteLine("Введите строку: ");
            stroka = Console.ReadLine();
            find = 'h';
            int first_index = stroka.IndexOf(find); //Нахождение первого вхождения буквы
            int last_index = stroka.LastIndexOf(find);//Нахождение последнего вхождения буквы 
            for (int i = 0; i < stroka.Length; i++)
            {
                if(stroka[i]==find )
                {
                    if(i != first_index && i != last_index)
                    {
                        stroka = stroka.Remove(i, 1).Insert(i,"H");
                    }
                }
            }
            Console.WriteLine(stroka);
        }
    }
}
