using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20241030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            reLoad();
            Console.ReadKey();

        }

        public static string TextToHtml(string text)
        {
            string html = text;
            html = html.Replace(">", "&gt");
            html = html.Replace("<", "&lt");
            html = html.Replace("\r\n", "<br>");
            html = html.Replace("|", "&brvbar");
            html = html.Replace(" ", " &nbsp");
            return html;
        }
        public static bool IsNumber(string input)
        {
            if(double.TryParse(input, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsEmail(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsPhone(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string pattern = @"^09\d{8}$";
            return Regex.IsMatch(input, pattern);
        }
        public static bool IsID(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            string pattern = @"^[A-Z]\d{9}$";
            return Regex.IsMatch(input, pattern);
        }
        public static string TextToDa(string input, int n)
        {
            if (string.IsNullOrEmpty(input) || n <= 0)
                return "";

            if (input.Length > n)
            {
                string answer= input.Substring(0, n) + "...";
                return answer;
            }
            else
            {
                return input;
            }

        }
        public static string ConvertDate(string text)
        {
            if (DateTime.TryParse(text, out DateTime date))
            {
                int taiwanYear = date.Year - 1911;
                return $"{taiwanYear}.{date.Month}.{date.Day}";
            }
            else
            {
                return "Invalid date format";
            }
        }
        public static string ConvertDate2(string text)
        {
            if (DateTime.TryParse(text, out DateTime date))
            {
                int taiwanYear = date.Year - 1911;
                return $"民國{taiwanYear}年{date.Month}月{date.Day}日";
            }
            else
            {
                return "Invalid date format";
            }
        }
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        public static double todayLucky(string phone)
        {
            if (IsPhone(phone))
            {
                string lastFour = phone.Substring(phone.Length - 4);
                int lastFourToInt = Convert.ToInt32(lastFour);
                double fortune = (lastFourToInt % 80) / 80.0 * 80;
                return fortune;
            }
            else
            {
                return 0;
            }
        }
        public static string  helloWho(string name)
        {
            string answer = "Hi~" + name;

            return answer;
        }
        public static string peoplePeople(char name)
        {
            string main = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            char[] a = main.ToCharArray();
            string answer = "";
            foreach(char s in a)
            {
                if (s==name)
                {
                    answer= "存在";
                    break;
                }
                else
                {
                    answer= "不存在";
                }
            }
            return answer;
        }
        public static string toApple(string Apple)
        {
            char[] a = Apple.ToCharArray();
            string answer = "";
            foreach (char s in a)
            {
                answer = answer + s + "-";
            }
            answer = answer.Substring(0, answer.Length - 1);
            return answer;
        }
        public static string toJpg(string Apple)
        {
            string[] a = Apple.Split('.');
            string answer = a[1];
            return answer;
        }
        public static string toFive(string Five)
        {
            string answer = "";
            if (Five.Length < 5)
            {
                answer = "長度不夠";
            }
            else
            {
                answer = Five.Substring(0, 3);
            }
            return answer;
        }
        public static string toMin(string Sing)
        {
            Sing = Sing.Replace("我","小明");
            return Sing;
        }
        public static string howMany(string Sing)
        {
            int count = Sing.Length;
            
            return count.ToString();
        }
        static void content()
        {
            List<string> array= new List<string>();
            string temp;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"請輸入第{i+1}組字");
                temp = Console.ReadLine();
                if (array.Contains(temp))
                {
                    Console.WriteLine("已輸入過");
                    array.Add(temp);
                }
                else
                {
                    Console.WriteLine("未輸入過");
                    array.Add(temp);
                }
            }
        }
        static string whatTime(string time)
        {
            string[] a = time.Split(':');
            string answer = a[0] + "點" + a[1]+"分";
            return answer;
        }
        static void ToHtml()
        {
            Console.WriteLine("請輸入:");
            string text=Console.ReadLine();
            string allName = text;
            string[] name = allName.Split(',');
            Console.WriteLine("<ul>");
            foreach(string a in name)
            {
                Console.WriteLine($"<li>{a}</li>");
            }
            Console.WriteLine("<ul>");
        }
        static void ToTotal()
        {
            Console.WriteLine("輸入5處數字，用空白隔開");
            string text = Console.ReadLine();
            string allName = text;
            string[] name = allName.Split(' ');
            int total = 0;
            foreach (string a in name)
            {
                int i = Convert.ToInt32(a);
                total+= i;
            }
            Console.WriteLine(total.ToString());
        }
        static void reLoad()
        {
            Console.WriteLine("輸入一串文字");
            string text = Console.ReadLine();
            string reversed = new string(text.Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }
}
