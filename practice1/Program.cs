using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Наберите и разберите программу «Listing Считывание числа»
            string res, txt;
            int year = 2022, age, born;
            res = Interaction.InputBox("В каком году вы родились?", "Год рождения: ");
            born = Int32.Parse(res);
            age = year - born;
            if ((age == 1) || (age % 10 == 1))
            {
                txt = "Вам " + age + " год";
                MessageBox.Show(txt, "Возраст.");
            }
            else if((age > 1) && (age < 5) || (age % 10 == 2) || (age % 10 == 3) || (age % 10 == 4))
            {
                txt = "Вам " + age + " года";
                MessageBox.Show(txt, "Возраст.");
            }    
            else
            {
                txt = "Вам " + age + " лет";
                MessageBox.Show(txt, "Возраст.");
            }*/

            //Напишите программу, в которой пользователь вводит сначала имя, а затем фамилию. Программа выводит сообщение с информацией об имени и фамилии пользователя.
            //Предложите версию программы, в которой ввод и вывод текста осуществляется с помощью диалоговых окон. Также предложите консольную версию программы.
            /*string firstname, lastname;
            Console.WriteLine("Как вас зовут?");
            firstname = Console.ReadLine();
            Console.WriteLine("Ваша фамилия?");
            lastname = Console.ReadLine();
            Console.WriteLine("Ваше имя " + firstname + ". Ваша фамилия " + lastname + ".");
            Console.ReadLine();*/
            /*string firstname, lastname, txt;
            firstname = Interaction.InputBox("Как вас зовут?",  "Имя: ");
            lastname = Interaction.InputBox("Ваша фамилия?", "Фамилия: ");
            txt = "Ваше имя " + firstname + ". Ваша фамилия " + lastname + ".";
            MessageBox.Show(txt);*/

            //Напишите программу, в которой пользователь вводит имя и возраст. Программа отображает сообщение об имени и возрасте пользователя.
            //Предложите консольную версию программы и версию, в которой данные вводятся и выводятся с помощью диалоговых окон.
            /*string firstname;
            int age = 0;
            Console.WriteLine("Как вас зовут?");
            firstname = Console.ReadLine();
            Console.WriteLine("Ваш возраст?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваше имя " + firstname + ". Ваш возраст " + age + ".");
            Console.ReadLine();*/
            /*string firstname, txt;
            int age = 0;
            firstname = Interaction.InputBox("Как вас зовут?",  "Имя: ");
            age = int.Parse(Interaction.InputBox("Ваш возраст?", "Возраст: "));
            txt = "Ваше имя " + firstname + ". Ваш возраст " + age + ".";
            MessageBox.Show(txt);*/

            //Напишите программу, в которой пользователь последовательно вводит название текущего дня недели, название месяца и дату(номер дня в месяце).
            //Программа выводит сообщение о сегодняшней дате(день недели, дата, месяц). Предложите версию программы, в которой для ввода и вывода данных используются диалоговые окна.
        }
    }
}
