namespace CsharpIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            // Maaş və kredit dəyərləri daxil olur. Əgər istifadəçinin daxil etdiyi kredit dəyəri,
            // illik maaşın 60%-dən çoxdursa ekrana "Kredit götürə bilməzsiniz!", əks halda
            // "Kredit götürə bilərsiniz!" yazdırırsınız.

            //int salary = 100;
            //int kredit = 721;
            //int salaryOfYear = salary * 12;

            //if (salaryOfYear * 0.6 >= kredit)
            //{
            //    Console.WriteLine("Kredit goture bilersiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Kredit goture bilmezsiniz!");
            //}


            #endregion

            #region Task2
            // 2 ədəd daxil olunur, ədədlərin hər ikisi cüt ədəd olduğunu yoxlayırsınız və cəmini tapırsınız,
            // cüt ədəd deyilsə ekrana "Daxil olunan ədədlər cüt olmalıdır!" yazısını yazdırırsınız.

            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //if (number1 % 2 == 0 && number2 % 2 == 0)
            //{
            //    int sum = number1 + number2;
            //    Console.WriteLine(sum);
            //}
            //else
            //{
            //    Console.WriteLine("Daxil olan ededler cut olmalidir!");
            //}
            #endregion

            #region Task3
            //254324356 ədədinin rəqəmlərinin sayını tapan kod yazın(Bu kod istənilən ədəd üçün işləməlidir).

            //Console.Write("Reqem daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int countOfNumber = 0;
            //int sumOfNumber = 0;
            //int mod = 0;

            //do
            //{
            //    mod = number % 10;
            //    sumOfNumber += mod;
            //    number -= mod; // number = number - (number % 10)
            //    number /= 10;
            //    countOfNumber++;
            //} while (number != 0);

            //Console.WriteLine(sumOfNumber);
            //Console.WriteLine(countOfNumber);
            #endregion

            #region Task4
            // Ədəd daxil olunur. Ədədin Palindrome olub olmamasını yoxlayın ona uyğun olaraq console-a true və ya false yazdırın.
            //int num = Convert.ToInt32(Console.ReadLine());
            //int constant = num;
            //int reverse = 0;
            //while (num != 0)
            //{
            //    reverse *= 10;
            //    reverse += num % 10;
            //    num -= num % 10;
            //    num /= 10;
            //}
            //if (constant == reverse)
            //{
            //    Console.WriteLine("true");
            //}
            //else Console.WriteLine("false");
            #endregion

            #region Task5
            //Hər hansısa bir rəqəm seçin (Misal: 300). Həmin rəqəmə kimi olan Fibonacci rəqəmlərini console-a yazdırın.
            //int input = 377;
            //int firstNumber = 0;
            //int secondNumber = 1;
            //int thirdNumber = 1;

            //Console.WriteLine(firstNumber);
            //Console.WriteLine(secondNumber);

            //while (thirdNumber <= input)
            //{
            //    Console.WriteLine(thirdNumber);
            //    firstNumber = secondNumber;
            //    secondNumber = thirdNumber;
            //    thirdNumber = firstNumber + secondNumber;
            //}

            #endregion

            #region Task6
            // 2 rəqəmli bir ədəd daxil olunur, ədədin onluğunun yoxsa, təkliyin böyük olduğunu ekrana yazdırırsınız.
            //int number = Convert.ToInt32(Console.ReadLine());
            //int teklik = number % 10;
            //int onluq = number / 10;
            //int count = 0;

            //while (number > 0)
            //{
            //    int mod = number % 10;
            //    number -= mod;
            //    number = number / 10;
            //    count++;
            //}

            //if (count != 2)
            //{
            //    Console.WriteLine("Bu iki reqemli ede deyil");
            //}
            //else
            //{
            //    if (onluq > teklik)
            //    {
            //        Console.WriteLine("Onluq tektikden boyukdur!");
            //    }
            //    else if (onluq < teklik)
            //    {
            //        Console.WriteLine("Teklik onluqdan boyukdur!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Onluq ve teklik beraberdir!");
            //    }
            //}

            #endregion
        }
    }
}
