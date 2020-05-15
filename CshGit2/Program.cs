using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGIT2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку:\n");
            string str = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nВыберите действие:\n1) Найти второе вхождение буквы 'f'\n2) Перевести в транслит\n3) Заменить 'h' на 'H', кроме первого и последнего вхождения\n");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                char f = 'f';
                int ch = str.IndexOf(f);
                int k = 0;
                if (str.Contains(f))
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[j].Equals(f))
                        {
                            k++;

                        }
                    }
                }
                if (k == 1)
                {
                    Console.WriteLine("\nБуква 'f' встречается 1 раз");
                }
                else if (k == 0)
                {
                    Console.WriteLine("\nБуква 'f' встречается 0 раз");
                }
                else if (k > 1)
                {
                    string[] sp = str.Split('f');
                    for (int i = 0; i < str.Length; i++)
                    {
                        Console.WriteLine("\n" + sp[0].Length + 1 + sp[1].Length);
                        break;
                    }

                }

            }

            if (n == 2)
            {
                string r = "";
                string[] rus = {"а","б","в","г","д","е","ё","ж", "з","и","й","к","л","м", "н",
                "о","п","р","с","т","у","ф","х", "Ц", "ч", "ш", "щ", "ъ", "ы","ь",
                "э","ю", "я" };

                string[] eng = {"a","b","v","g","d","e","e","zh","z","i","y","k","l","m","n",
                "o","p","r","s","t","u","f","h","ts","ch","sh","sh'",null,"y",null,
                "e","yu","ya"};

                for (int j = 0; j < str.Length; j++)
                {
                    for (int i = 0; i < rus.Length; i++)
                    {

                        if (str.Substring(j, 1) == rus[i])
                        {
                            r = r + eng[i];
                        }

                    }

                }
                Console.WriteLine("\n" + r);
            }

            if (n == 3)
            {
                string str2 = "";
                string str3 = "";
                string str4 = "";

                int k = 0;
                if (str.Contains('h'))
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[j].Equals('h'))
                        {
                            k++;

                        }
                    }
                }
                if (k == 0)
                {
                    Console.WriteLine("\nСтрока не содержит букву 'h'");
                }
                if (k == 1)
                {
                    Console.WriteLine("\nСтрока содержит только одну букву 'h'");
                }
                if (k == 2)
                {
                    Console.WriteLine("\nСтрока содержит только две буквы 'h'");
                }
                if (k > 2)
                {
                    //int perv = str.IndexOf('h');
                    //int posl = str.LastIndexOf('h');

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == 'h')
                        {

                            str2 = str2 + str.Replace(str[i], 'H');
                            int perv = str.IndexOf('h');
                            str3 = str3 + str2.Replace(str[perv], 'h');
                            int posl = str3.IndexOf('h');
                            str4 = str4 + str3.Replace(str[posl], 'h');
                            Console.WriteLine(perv);
                            Console.WriteLine(posl);
                            break;
                            //str.Replace(str[perv], 'h');
                            //str.Replace(str[posl], 'h');

                        }
                    }

                    Console.WriteLine("\n" + str3);
                }


            }
        }
    }
}
