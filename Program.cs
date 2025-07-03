namespace C44_G00__C_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 3 == 0 && num1 % 4 == 0){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
            #endregion
            #region 2. Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive
            Console.Write("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 < 0){
                Console.WriteLine("Negative");
            }else{
                Console.WriteLine("Positive");
            }
            #endregion
            #region 3. Write a program that takes 3 integers from the user then prints the max element and the min element.
            Console.Write("Enter a first number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a third number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int max;
            int min;
            if (num3 > num4){
                max = num3;
                min = num4;
            }else{
                max = num4;
                min = num3;
            }
            if (num5 > max){
                max = num5;
            }
            if (num5 < min){
                min = num5;
            }

            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
            #endregion
            #region 4. Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.Write("Enter a number: ");
            int num6 = Convert.ToInt32(Console.ReadLine());
            if (num6 % 2 == 0) {
                Console.WriteLine("Even");
            } else {
                Console.WriteLine("Odd");
            }
            #endregion
            #region 5 Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            Console.Write("Enter a character: ");
            char ch = Console.ReadKey().KeyChar;
            ch = char.ToLower(ch);
            // should to convert the capital letter to lower letter
            // also i can use contains instead of if
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            #endregion
            #region 10.Write a program to enter marks of five subjects and calculate total, average and percentage.
            double total = 0;
            Console.Write("Enter mark of subject 1: ");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter mark of subject 2: ");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter mark of subject 3: ");
            double m3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter mark of subject 4: ");
            double m4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter mark of subject 5: ");
            double m5 = Convert.ToDouble(Console.ReadLine());
            total = m1 + m2 + m3 + m4 + m5;
            double avg = total / 5.0;
            double percentage = avg;
            Console.WriteLine("Total marks = " + total);
            Console.WriteLine("Average marks = " + avg);
            Console.WriteLine("Percentage = " + percentage);
            #endregion
            #region 11. Write a program to input the month number and print the number of days in that month.
            Console.Write("Enter a number oof month ");
            int month = Convert.ToInt32(Console.ReadLine());
            int day;
            switch (month){
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                case 2:
                    day = 28;
                    break;
                default:
                    day = 0;
                    break;
            }
            if (day == 0){
                Console.WriteLine("Please Enter a number of month correct");
            }else{
                Console.WriteLine("Days in Month: " + day);
            }
            #endregion
            #region 12.  Write a program to create a Simple Calculator.
            double res;
            bool validation = true;
            Console.Write("Enter a first number: ");
            double num7 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator : ");
            char operatorr = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Enter a second number: ");
            double num8 = Convert.ToDouble(Console.ReadLine());
            switch (operatorr){
                case '+':
                    res = num7 + num8;
                    break;
                case '-':
                    res = num7 - num8;
                    break;
                case '*':
                    res = num7 * num8;
                    break;
                case '/':
                    if (num8 != 0){
                        res = num7 / num8;
                    }else{
                        Console.WriteLine("Error: Cannot divide by zero. or this is a runtime error");
                        validation = false;
                        res = 0;
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a correct operator.");
                    validation = false;
                    res = 0;
                    break;
            }

            if (validation == true){
                Console.WriteLine("result = " + res);
            }

            #endregion
        }
    }
}
