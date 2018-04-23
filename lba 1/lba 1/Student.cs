using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lba_1
{
    class Student
    {
        /*private string name;
        private int kurs;
        private bool sex;*/
        //свойства класса
        public string Name { get; set; }         //свойство имя студента
        public int Kurs { get; set; }       //свойство курса
        public bool Sex { get; set; }          //свойство пола
        public Student()  //конструктор по умолчанию
        {
            Name = null;
            Kurs = 0;
            Sex = true;
        }
        public Student(string Name, int Kurs, bool Sex) //конструктор с параметрами
        {
            this.Name = Name;
            this.Kurs = Kurs;
            this.Sex = Sex;
        }
        public virtual void Display() //метод для вывода 
        {
            Console.WriteLine("Имя студента: " + Name);
            Console.WriteLine("Курс: " + Kurs);
            Console.WriteLine("Пол: " + Sex);
        }
        public virtual void Input()  //метод для ввода
        {
            Console.WriteLine("Имя студента:  ");
            Name = Console.ReadLine();
            Console.WriteLine("Курс: ");
            Kurs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пол: ");
            Sex = Convert.ToBoolean(Console.ReadLine());

        }
    }
}
