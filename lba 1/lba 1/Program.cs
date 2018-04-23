using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                    //вывод информации в консоль
                    Console.WriteLine("---------------------------------------------- ");
                    Console.WriteLine("Введите информацию о Студенте: ");
                    Console.WriteLine("---------------------------------------------- ");
                    Student st1 = new Student(); //создание объекта класса
                    st1.Input();      //вызов метода ввода класса Student

                    Console.Clear(); //очищение консоли

                    //вывод информации в консоль
                    Console.WriteLine("----------------------------------------------- ");
                    st1.Display();     //вызов метода вывода класса Student
            Console.WriteLine("----------------------------------------------- ");

                    Console.ReadKey();  //ожидание нажатия клавиши для завершение программы

                }
            
        }

    }

