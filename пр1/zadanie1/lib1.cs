using System;
public class lib1
{
    public static string stpow(string a, int b) // Возврат n дублирующей строки
    {
        string ready = "";
        for (int i = 0; i < b; i++)
        {
            ready = ready + a;
        }
        return ready;
    }
    public static string rev(string a) //Возврат перевернутой строки
    {
        int length = a.Length;
        char[] b = a.ToCharArray();
        string reverse = "";
        for (int i = length; i != 0; i--)
        {
            reverse = reverse + b[i - 1];
        }
        return reverse;
    }
    public static string remov(string str, string s)// Возврат строки с удалением подстроки
    {
        string ready = "";
        int length_main = str.Length; //Длина строки
        int length_sec = s.Length;// Длина подстроки
        int find = str.IndexOf(s);
        //if (find > -1)
        //{
            ready = str.Replace(s, "");
        //}
        return ready;
    }
    public static int leng(string str)
    {
        int length = str.Length;
        return length;
    }
}

