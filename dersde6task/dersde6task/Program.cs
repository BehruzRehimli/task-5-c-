using System;

namespace dersde6task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            //Consola adinizi yanlish daxil etdiyiniz halda yeniden daxil etmeyinizi isteyir 
            do
            {
                Console.WriteLine("Adinizi daxil edin");
                result = Console.ReadLine();

            } while (!IsName(result));
            //Consola mailinizi yanlish daxil etdiyiniz halda yeniden daxil etmeyinizi isteyir 
            do
            {
                Console.WriteLine("Mailinizi daxil edin");
                result = Console.ReadLine();

            } while (result.IndexOf('@') == -1);

        }
        static bool IsName(string name)
        {
            //Verilmish stringin ada uygun olub olmadigini yoxlayan method.
            if (char.IsUpper(name[0]))
            {
                for (int i = 1; i < name.Length; i++)
                {
                    if (!char.IsLower(name[i]))
                    {
                        return false;
                    }

                }
            }

            else
            {
                return false;
            }
            return true;
        }
        static string[] NameList(string[] name) 
        {
            //Verilmish fullname arrayde name siyahisi duzelden method.
            var result= new string[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = name[i].Trim();
                result[i] = name[i].Substring(0, name[i].IndexOf(' '));
            }
            return result;
        }
        static string[] DontRepeat(string[] name)
        {
            //Verilmish adlar siyahisindan tekrarlanmayan adlar siyahisi veren method
            string[] result = new string[0];

            for (int i = 0; i < name.Length; i++)
            {
                if (Array.IndexOf(result, name[i])==-1)
                {
                    Array.Resize(ref result, result.Length+1);
                    result[result.Length-1] = name[i];
                }
            }
            return result;
        }
        static string FirstCharUpper(string str)
        {
            //Verilmish yazini bash herifi boyuk digerleri kichik halda qaytaran method.
            string result = "";
            if (string.IsNullOrWhiteSpace(str))
            {
                return result;
            }
            result += char.ToUpper(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                    result += char.ToLower(str[i]) ;   
            }
            return result;
        }
        static string Domain( string str)
        {
            //Verilmish mailde domen hisseni tapan method.
            return str.Substring(str.IndexOf('@')+1);
        }
        static bool HasDigit(string str)
        {
            //Task 1 :Verilmish yazida reqem olub olmadigini tapan methot
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsFullname(string str)
        {
            //Task 2 - Verilmiş yazının fullname olub olmadığını tapan metod (fullname olması üçün iki sozdən ibarət
            // olmalıdır və hər bir söz böyük hərflə başlayıb kiçik hərflərlə davam etməlidir)
            str= str.Trim();
            var arr= str.Split(' ');
            if (IsName(arr[0]) && IsName(arr[1]))
            {
                return true;
            }
            return false;
        }
        static int[] DontReprat2(int[] arr)
        {
            //Task 3- Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.Yeni arrayə elementlər
            //təkrarlanmamaq şərti ilə yerləşdirilsin.
            var result= new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(result, arr[i])==-1)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length-1] = arr[i];
                }
            }
            return result;
        }
        static string[] EmailDomain(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].Substring(str[i].IndexOf('@')+1);
            }
            var result=new string[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (Array.IndexOf(result, str[i])==-1)
                {
                    Array.Resize(ref result,result.Length+1);
                    result[result.Length - 1] = str[i];
                }
            }
            return result;
        }
        static int HowMuchSentence(string str)
        {
            // - Verilmiş yazının içindəki cümlələrin sayını tapan metod.
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]=='.')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
