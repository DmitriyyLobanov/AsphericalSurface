using AsphericalSurface.Interfaces;
using AsphericalSurface.Lenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsphericalSurface.ConsoleView
{
    /// <summary>
    /// Класс реализующий консольный интерфейс взамодействия с пользователем.
    /// </summary>
    internal class View
    {
        private IController controller;
        
        public View(IController controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// Метод реализующий клавный диалоговый список взаимодействия с пользователем.
        /// </summary>
        public void PrimaryPage()
        {
            Console.Clear();
            string? usersChoise;
            Console.WriteLine("D ==> |)");
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("" +
                "1 - Посмотреть список доступных линз.\n" +
                "2 - Посмотреть информацию о конкретной линзе.\n" +
                "3 - Рассчитать макрозаготовку для одной из имеющихся линз.\n" +
                "4 - Завершить работу программы.");
            while (true)
            {
                usersChoise = Console.ReadLine();
                if (usersChoise != null)
                {
                    if (usersChoise == "1" || usersChoise == "2" || usersChoise == "3" || usersChoise == "4")
                    {
                        switch (usersChoise)
                        {
                            case "1": ViewLensNames();
                                      break;
                            case "2": ViewSingleLensInfo();
                                      PrimaryPage();
                                      break;
                            case "3": ViewCalculateMacro();
                                      PrimaryPage();
                                      break;
                            case "4": Environment.Exit(0);
                                      break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод, попробуйте снова.");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод, попробуйте снова.");
                }
            }

        }

        /// <summary>
        /// Метод просмотра имён продуктов, доступных к взаимодействию.
        /// </summary>
        private void ViewLensNames()
        {
            string[] names = controller.getLensNames();
            Console.WriteLine();
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();
        }
        private void ViewSingleLensInfo()
        {
            string? userChoise;
            string[] lensNames = controller.getLensNames();
            Console.WriteLine("Введите код-имя конкретной линзы: ");
            while (true)
            {
                userChoise = Console.ReadLine();
                if (userChoise != null)
                {
                    if (lensNames.Contains(userChoise))
                    {
                        Console.WriteLine();
                        Console.WriteLine(controller.GetSinleLens(userChoise).ToString() + "\n");
                        
                        Console.WriteLine("Нажмите любую кнопку.");
                        Console.ReadKey();

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректное значение!");
                    }
                }
            }
        }

        /// <summary>
        /// Метод формирующий параметы макрозаготовки под перетяжку и файл с массивом точек поверхности.
        /// Используется пользовательский ввод для выбора базовой микролинзы и коэффициента увеличения.
        /// </summary>
        private void ViewCalculateMacro()
        {
            string? userChoise;
            string[] lensNames = controller.getLensNames();
            Console.WriteLine("Для расчёта макрозаготовки введите код-имя конкретной линзы: ");
            ILens macro;
            while (true)
            {
                userChoise = Console.ReadLine();
                if (userChoise != null)
                {
                    if (lensNames.Contains(userChoise))
                    {
                        double magnificationFactor = GetMagnificationFactor();
                        Console.WriteLine();
                        Console.WriteLine(controller.GetSinleLens(userChoise).ToString() + "\n");
                        macro = controller.GetSinleLens(userChoise);
                        Console.WriteLine(macro.CalculateMacro(magnificationFactor) + "\n");


                        Console.WriteLine($"Файл с именем '{macro.LensName}.txt' формируется. ");
                        controller.CreateDots(macro.CalculateMacro(magnificationFactor));
                        Console.WriteLine($"Файл с именем '{macro.LensName}.txt' сформирован. \n");

                        Console.WriteLine("Нажмите любую кнопку.");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректное значение!");
                    }
                }
            }
        }

        /// <summary>
        /// Метод получения коэффициента увеличения с помощью пользовательского ввода.
        /// </summary>
        /// <returns> коэффициэнт увеличения </returns>
        private double GetMagnificationFactor()
        {
            string? userInput;
            double factor;
            while (true)
            {
                Console.WriteLine("Введите коэффициент увеличения линзы: ");
                userInput = Console.ReadLine();
                if (Double.TryParse(userInput, out factor))
                {
                    return factor;
                }
                else
                {
                    Console.WriteLine("Некорректное значение!");
                }
            }

        }
    }
}
