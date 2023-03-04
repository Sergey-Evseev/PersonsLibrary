using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsLibrary
{
    public enum PersonMaritalStatus
    {
        Married,
        Single
    }
    [Serializable] //атрибут для последующего преобразования объекта из 
    //библиотеки в другую программу
    public class Person
    {
        //все приватные поля по нотации указываются с подчеркиванием с мал.буквы
        string _name;
        string _lastName;
        int _age;        

        public Person(string name, string lastName, int age)
        {
            _name = name;
            _lastName = lastName;
            _age = age;
            
        }
        public virtual void Print()//виртуальный чтобы можно было переопределить
            //в наследнике
        {
            Console.WriteLine($"Имя: {_name}\nФамилия:{_lastName}\n" + 
                $"Возраст:{_age}");
        }
    } //class Person

    public class Employee : Person
    {

        PersonMaritalStatus _maritalStatus; //перенесли enum свойство из Human,
        //чтобы получать доступ к объектам библиотеки из другого процесса
        decimal _salary;        

        public Employee(string name, string lastName, int age, 
            PersonMaritalStatus maritalstatus, decimal salary): base(name, lastName, age)
        {
            _maritalStatus = maritalstatus;
            _salary = salary;
        }
        public override void Print()
        {
            base.Print(); //вывод базовой информации
            Console.WriteLine($"\nСтатус:{_maritalStatus}\nЗарплата:{_salary}");
        }
    }




} //namespace
