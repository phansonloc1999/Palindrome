namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            do
            {
                Console.Write("Enter a string: ");
                String? str = Console.ReadLine();
                if (str == null)
                {
                    Console.WriteLine("String is null!");
                    continue;
                }
                int len = str.Length;
                if (len == 0)
                {
                    Console.WriteLine("Empty string!");
                    continue;
                }
                bool isNotPalindrome = false;
                for (int i = 0; i < len / 2.0f; i++)
                {
                    if (str[i] != str[len - 1 - i])
                    {
                        if ((str[i] == '6' && str[len - 1 - i] == '9') || (str[i] == '9' && str[len - 1 - i] == '6')) 
                        {
                            continue;
                        }
                        Console.WriteLine("String is not palindrome!");
                        isNotPalindrome = true;
                        break;
                    }
                }
                if (!isNotPalindrome)
                {
                    Console.WriteLine("String is a palindrome");
                }
                Console.Write("Enter 1 to continue inputting string, enter anything else to exit: ");
                cont = Console.ReadLine() == "1" ? true : false ;
            } while (cont);
        }
    }
}