using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Новикова_лаб_3_24._11
{
    internal class Program
    {

        static void task1()
        {
            try
            {
                int input = Convert.ToInt32(Interaction.InputBox("Введите число"));

                // Проверка деления на 3 и 7
                if (input % 3 == 0 && input % 7 == 0)
                {
                    MessageBox.Show($"{input} делится и на 3, и на 7.");
                }
                else
                {
                    MessageBox.Show($"{input} не делится одновременно на 3 и 7.");
                    
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода. Пожалуйста, введите целое число.");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошло исключение: {ex.Message}");
               
            }
        }

        static void task2()
        {
            try
            {
                int input = Convert.ToInt32(Interaction.InputBox("Введите первое число"));
                int input2 = Convert.ToInt32(Interaction.InputBox("Введите второе число"));

                if (input == input2)
                {
                    MessageBox.Show($"Первое число {input} равно второму числу {input2}");
                }
                else if (input < input2)
                {
                    MessageBox.Show($"{input2} больше числа {input}");

                }
                else if (input > input2)
                {
                    MessageBox.Show($"{input} больше числа {input2}");

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода. Пожалуйста, введите целое число.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошло исключение: {ex.Message}");

            }
        }

        static void task3()
        {
            try
            {
                int input = Convert.ToInt32(Interaction.InputBox("Введите первое число"));
                int input2 = Convert.ToInt32(Interaction.InputBox("Введите второе число"));
                int sum = input + input2;
                MessageBox.Show($"{sum}");
                int input3;

                        for (int i = sum; input != 0; ++i)
                        {
                            input3 = Convert.ToInt32(Interaction.InputBox("Введите число"));
                        if (input3 != 0)
                        {
                            sum += input3;
                            MessageBox.Show($"Сумма + введенное число = {sum}");
                        }
                        else if( input3 == 0)
                        {
                            break;
                        }
                        }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода. Пожалуйста, введите целое число.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошло исключение: {ex.Message}");

            }
        }

        static void task4()
        {
            try
            {
                int input = Convert.ToInt32(Interaction.InputBox("Введите число от 1 до 7: "));
                if ( input > 7  || input < 1)
                {
                    MessageBox.Show("Введите число согласно инструкциям");
                }
                else
                {
                    switch(input)
                    {
                        case 1:
                            {
                                MessageBox.Show("Понедельник");
                                break;
                            }
                        case 2:
                            {
                                MessageBox.Show("Вторник");
                                break;
                            }
                        case 3:
                            {
                                MessageBox.Show("Среда");
                                break;
                            }
                        case 4:
                            {
                                MessageBox.Show("Четверг");
                                break;
                            }
                        case 5:
                            {
                                MessageBox.Show("Пятница");
                                break;
                            }
                        case 6:
                            {
                                MessageBox.Show("Суббота");
                                break;
                            }
                        case 7:
                            {
                                MessageBox.Show("Воскресенье");
                                break;
                            }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода. Пожалуйста, введите целое число.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошло исключение: {ex.Message}");
            }

        }

        static void task5()
        {
            string inputday = Interaction.InputBox("Введите название дня недели с большой буквы");

            if( inputday == "Понедельник" || inputday == "Вторник" || inputday == "Среда" || inputday == "Четверг" || inputday == "Пятница" || inputday == "Суббота" || inputday == "Воскресенье")
            {
                switch(inputday)
                {
                    case "Понедельник":
                        MessageBox.Show("1");
                        break;
                    case "Вторник":
                        MessageBox.Show("2");
                        break;
                    case "Среда":
                        MessageBox.Show("3");
                        break;
                    case "Четверг":
                        MessageBox.Show("4");
                        break;
                    case "Пятница":
                        MessageBox.Show("5");
                        break;
                    case "Суббота":
                        MessageBox.Show("6");
                        break;
                    case "Воскресенье":
                        MessageBox.Show("7");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Введите корректное название");
            }
        }

        static void task6()
        {
            int num1 = 0, num2 = 1, num3 = num1, num4 = num2;
            Console.Write("Введите размер последовательности: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"{num3}");
                Console.WriteLine($"{num4}");
                num3 = num3 + num4;
                num4 = num4 + num3;
            }
            Console.ReadKey();
        }

        static void task7()
        {

            try
            {
                Console.WriteLine("Введите 2 числа для последовательности: ");
                int num1 = Convert.ToInt32(Console.ReadLine()),num2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                for (int i = 0; i < num2; i++)
                {
                    Console.WriteLine($"{i + 1}");
                }
                Console.ReadKey();

            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка ввода. Пожалуйста, введите целое число.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошло исключение: {ex.Message}");
                Console.ReadKey();
            }
        }

        static void task8()
        {
            try
            {
                Console.Write("Введите количество чисел для суммирования: ");
                int count = int.Parse(Console.ReadLine());

                int sum = 0;

                Console.WriteLine($"Числа, удовлетворяющие условиям:");

                for (int i = 1; count > 0; i++)
                {
                    if (i % 5 == 2 || i % 3 == 1)
                    {
                        Console.Write(i + " ");
                        sum += i;
                        count--;
                    }
                }
                Console.ReadKey ();

                Console.WriteLine($"\nСумма этих чисел: {sum}");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошло исключение: {ex.Message}");
            }


        }

        static int Main(string[] args)
        {
            /*task1();*/
            /*task2();*/
            /*task3();*/
            /*task4();*/
            /*task5();*/
            /*task6();*/
            /*task7();*/
            task8();
            return 0;
        }
    }
}
