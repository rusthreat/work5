﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {
        static string str;
        static Random random = new Random();

        #region Задание 1 (матрицы из 4-го модуля)          
        // Задание 1.
        // Используется решение: 3-го задания четвертого модуля
        // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
        // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
        // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
        //

        /// <summary>
        /// Метод, генерирующий матрицу заданного размера
        /// </summary>
        static int[][] GetMatrix(int n, int m)
        {
            int[][] Matrix = new int[n][];

            // формирование начальной матрицы
            for (int j = 0; j < n; j++)
            {
                Matrix[j] = new int[m];

                for (int i = 0; i < m; i++)
                {
                    Matrix[j][i] = random.Next(1, 10);
                }
            }

            return Matrix;
        }

        /// <summary>
        /// Метод, принимающий число и матрицу, возвращающий результат их умножения
        /// </summary>
        static int[][] MultMatrixByNumber(int a, int[][] Array)
        {
            // Определение размера входящего массива
            int n = Array.Length;
            int m = Array[0].Length;

            // объявление итоговой матрицы
            int[][] Total = new int[n][];
            // 

            for (int j = 0; j < n; j++)
            {
                Total[j] = new int[m];

                for (int i = 0; i < m; i++)
                {
                    Total[j][i] = Array[j][i] * a;
                }
            }

            return Total;
        }

        /// <summary>
        /// Метод, принимающий 2 матрицы и возвращающий результат их сложения или вычитания
        /// flag = 0 - сложение
        /// flag = 1 - вычитание
        /// </summary>
        static int[][] MatrixAddition(int flag, int[][] Array1, int[][] Array2)
        {
            // Определение размера входящей матрицы
            int n = Array1.Length;
            int m = Array1[0].Length;

            // объявление итоговой матрицы
            int[][] Total = new int[n][];

            for (int j = 0; j < n; j++)
            {
                Total[j] = new int[m];

                for (int i = 0; i < m; i++)
                {
                    if (flag == 0)
                    {
                        Total[j][i] = Array1[j][i] + Array2[j][i];
                    }
                    else 
                    {
                        Total[j][i] = Array1[j][i] - Array2[j][i];
                    }
                }
            }
            return Total;
        }

        /// <summary>
        /// Метод, принимающий 2 матрицы, возвращающий результат их умножения
        /// </summary>
        static int[][] MatrixMultiplication(int[][] Array1, int[][] Array2)
        {
            // Определение размера входящих матриц
            int n1 = Array1.Length;
            int m1 = Array1[0].Length;
            int n2 = Array2.Length;
            int m2 = Array2[0].Length;
            // объявление итоговой матрицы
            int[][] Total = new int[n1][];

            // Расчет умножения
            for (int j = 0; j < n1; j++)
            {
                Total[j] = new int[m2];

                for (int i = 0; i < m2; i++)
                {
                    int sum = 0;

                    for (int k = 0; k < m1; k++)
                    {
                        sum = sum + (Array1[j][k] * Array2[k][i]);
                    }

                    Total[j][i] = sum;
                }
            }

            return Total;
        }

        /// <summary>
        /// Метод, выводящий переданный массив на экран
        /// </summary>
        static void PrintMatrix(int[][] Array)
        {
            // Определение размера входящего массива
            int n = Array.Length;
            int m = Array[0].Length;

            for (int j = 0; j < n; j++)
            {
                Console.Write("\n|");

                for (int i = 0; i < m; i++)
                {
                    Console.Write($"{Array[j][i],4:0}");
                }

                Console.Write("  |");
            }
        }

        /// <summary>
        /// Задание 1. Метод для выполнения арифметических операций с матрицами
        /// </summary>
        static void Matrix()
        {
            // Меню первого задания
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Задание 1. Выберите задание:");
                Console.WriteLine("1 - Задание 1.1. (Умножение числа на матрицу)");
                Console.WriteLine("2 - Задание 1.2. (Суммирование матриц)");
                Console.WriteLine("3 - Задание 1.3. (Умножение матриц)");
                int item = int.Parse(Console.ReadLine());

                #region Задание 3.1. Умножение матрицы на число
                // 
                // * Задание 3.1
                // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
                // Добавить возможность ввода количество строк и столцов матрицы и число,
                // на которое будет производиться умножение.
                // Матрицы заполняются автоматически. 
                // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
                //
                // Пример
                //
                //      |  1  3  5  |   |  5  15  25  |
                //  5 х |  4  5  7  | = | 20  25  35  |
                //      |  5  3  1  |   | 25  15   5  |
                //
                
                if (item == 1)
                {
                    Console.WriteLine("3.1. Умножение матрицы на число");

                    // запрос размера матрицы
                    Console.WriteLine("\nУкажите число строк: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Укажите число столбцов: ");
                    int m = Convert.ToInt32(Console.ReadLine());

                    // объявление начальной матрицы
                    int[][] Array = GetMatrix(n, m);

                    Console.WriteLine("Укажите число-множитель: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    // обращение к методу, выполняющему умножение
                    int[][] Total = MultMatrixByNumber(a, Array);

                    // вывод результата
                    // поиск строки, на которой будет выведен множитель
                    int a_output = (n % 2 == 0)?(n / 2):((n + 1) / 2);

                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine();

                        // вывод множителя
                        if (a_output - 1 == j)
                        {
                            Console.Write($"{a,5:0} * |");
                        }
                        else
                        {
                            Console.Write($"        |");   
                        }

                        // вывод начальной таблицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Array[j][i],3:0}");
                        }
                        
                        if (a_output - 1 == j)
                        {
                            Console.Write($" | = |");
                        }
                        else
                        {
                            Console.Write($" |   |");   
                        }
                        
                        // вывод итоговой таблицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Total[j][i],3:0}");
                        }

                        Console.Write($" |");
                    }
                }
                #endregion

                #region Задание 3.2. Сложение и вычитание матриц
                //
                // ** Задание 3.2
                // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
                // Добавить возможность ввода количество строк и столцов матрицы.
                // Матрицы заполняются автоматически
                // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
                //
                // Пример
                //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
                //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
                //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
                //  
                //  
                //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
                //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
                //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
                //
                
                else if (item == 2)
                {
                    int n;
                    int m;
                    
                    while (true)
                    {
                        Console.WriteLine("3.2. Сложение и вычитание матриц");
                        
                        // запрос размера матрицы
                        Console.WriteLine("\nУкажите число строк: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Укажите число столбцов: ");
                        m = Convert.ToInt32(Console.ReadLine());

                        if (n != m)
                        {
                            Console.WriteLine("Складывать и вычитать можно только матрицы одинакового размера.");
                            Console.WriteLine("Попробуйте еще раз.\n");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }   
                    
                    // объявление 1-й матрицы
                    int[][] Array1 = GetMatrix(n, m);

                    // объявление 2-й матрицы
                    int[][] Array2 = GetMatrix(n, m);

                    // расчет 1-й итоговой матрицы
                    int[][] Total1 = MatrixAddition(0, Array1, Array2);

                    // объявление 2-й итоговой матрицы
                    int[][] Total2 = MatrixAddition(1, Array1, Array2);

                    // вывод результата
                    // поиск строки, на которой будут выводится знаки
                    int a_output = (n % 2 == 0)?(n / 2):((n + 1) / 2);
                    
                    Console.WriteLine();

                    // вывод операции сложения
                    Console.WriteLine("Сложение:");
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("\n|");
                        
                        // вывод первой начальной матрицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Array1[j][i],3:0}");
                        }
                        
                        // вывод знака сложения
                        if (a_output - 1 == j)
                        {
                            Console.Write(" | + |");
                        }
                        else
                        {
                            Console.Write(" |   |");   
                        }

                        // вывод второй начальной матрицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Array2[j][i],3:0}");
                        }
                        
                        // вывод знака равенства
                        if (a_output - 1 == j)
                        {
                            Console.Write(" | = |");
                        }
                        else
                        {
                            Console.Write(" |   |");   
                        }
                        
                        // вывод итоговой матрицы сложения
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Total1[j][i],3:0}");
                        }

                        Console.Write($" |");

                    }
                    Console.WriteLine("\n");

                    // вывод операции вычитания
                    Console.WriteLine("Вычитание:");

                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("\n|");
                        
                        // вывод первой начальной матрицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Array1[j][i],3:0}");
                        }
                        
                        // вывод знака вычитания
                        if (a_output - 1 == j)
                        {
                            Console.Write(" | - |");
                        }
                        else
                        {
                            Console.Write(" |   |");   
                        }

                        // вывод второй начальной матрицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Array2[j][i],3:0}");
                        }
                        
                        // вывод знака равенства
                        if (a_output - 1 == j)
                        {
                            Console.Write(" | = |");
                        }
                        else
                        {
                            Console.Write(" |   |");   
                        }
                        
                        // вывод итоговой матрицы вычитания
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Total2[j][i],3:0}");
                        }

                        Console.Write($" |");
                    }
                }
                #endregion

                #region Задание 3.3. Умножение матриц
                // *** Задание 3.3
                // Заказчику требуется приложение позволяющщее перемножать математические матрицы
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
                // Добавить возможность ввода количество строк и столцов матрицы.
                // Матрицы заполняются автоматически
                // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
                //  
                //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
                //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
                //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
                //
                //  
                //                  | 4 |   
                //  |  1  2  3  | х | 5 | = | 32 |
                //                  | 6 |  
                //
                
                else if (item == 3)
                {
                    int n1;
                    int n2;
                    int m1;
                    int m2;
                    
                    while (true)
                    {
                        Console.WriteLine("3.3. Умножение матриц");
                        
                        // запрос размера 1-й матрицы
                        Console.WriteLine("\nУкажите число строк 1-й матрицы: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Укажите число столбцов 1-матрицы: ");
                        m1 = Convert.ToInt32(Console.ReadLine());

                        // запрос размера 2-й матрицы
                        Console.WriteLine("Укажите число строк 2-й матрицы: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Укажите число столбцов 2-матрицы: ");
                        m2 = Convert.ToInt32(Console.ReadLine());

                        if (m1 != n2)
                        {
                            Console.WriteLine("Число столбцов 1-й матрицы должно быть равно числу строк 2-й матрицы.");
                            Console.WriteLine("Попробуйте еще раз.\n");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }   
                    
                    // получение 1-й матрицы
                    int[][] Array1 = GetMatrix(n1, m1);

                    // получение 2-й матрицы
                    int[][] Array2 = GetMatrix(n2, m2);

                    // объявление итоговой матрицы
                    int[][] Total = MatrixMultiplication(Array1, Array2);

                    // Вывод результата
                    Console.WriteLine("\nМатрица 1:");
                    PrintMatrix(Array1);

                    Console.WriteLine("\n\nМатрица 2:");
                    PrintMatrix(Array2);

                    Console.WriteLine("\n\nИтог умножения матриц:");
                    PrintMatrix(Total);
                }
                #endregion

                else
                {
                    Console.WriteLine("Укажите верное значение");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("\n\nВернуться в меню Задания 1? y/n");
                str = Console.ReadLine();

                if (str == "y")
                {
                    continue;
                }
                else
                {
                    break; 
                }
            }
        }
        #endregion

        #region Задание 2 (поиск самого длинного и короткого слова)          
        // Задание 2.
        // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
        // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
        // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
        // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
        // 1. Ответ: А
        // 2. ГГГГ, ДДДД
        //
        static void LengthSearch()
        {
        
        
        }
        #endregion

        #region Задание 3 (удаление лишних букв)          
        // Задание 3. Создать метод, принимающий текст. 
        // Результатом работы метода должен быть новый текст, в котором
        // удалены все кратные рядом стоящие символы, оставив по одному 
        // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
        // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
        // 
        static void ShortText()
        {
        
        
        }
        #endregion

        #region Задание 4 (проверка на геом. прогрессию)          
        // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
        // является заданная последовательность элементами арифметической или геометрической прогрессии
        // 
        // Примечание
        //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
        //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
        //
        static void GeomProgression()
        {
        
        
        }
        #endregion

        #region Задание 5 (вычисление функции Аккермана)          
        // *Задание 5
        // Вычислить, используя рекурсию, функцию Аккермана:
        // A(2, 5), A(1, 2)
        // A(n, m) = m + 1, если n = 0,
        //         = A(n - 1, 1), если n <> 0, m = 0,
        //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
        // 
        // Весь код должен быть откоммментирован
        static void AkkermanFunction()
        {
        
        
        }
        #endregion

        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // меню для выбора решения
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Модуль 5. Выберите задание:");
                Console.WriteLine("1 - Задание 1 (матрицы из 4-го модуля)");
                Console.WriteLine("2 - Задание 2 (поиск самого длинного и короткого слова)");
                Console.WriteLine("3 - Задание 3 (удаление лишних букв)");
                Console.WriteLine("4 - Задание 4 (проверка на геом. прогрессию)");
                Console.WriteLine("5 - Задание 5 (вычисление функции Аккермана)");
                int item = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (item)
                {
                    case 1: Matrix(); break;
                    case 2: LengthSearch(); break;
                    case 3: ShortText(); break;
                    case 4: GeomProgression(); break;
                    case 5: AkkermanFunction(); break;
                    default: 
                    {
                        Console.WriteLine("Укажите верное значение (1-5)");
                        Console.ReadKey();
                        continue;
                    }
                }
             
                Console.WriteLine("\n\nВернуться в главное меню? y/n");
                str = Console.ReadLine();

                if (str == "y")
                {
                    continue;
                }
                else
                {
                    break; 
                }
            }
        }
    }
}
