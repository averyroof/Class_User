using System;

namespace Class_User
{
    public class User
    {
        public string Surname { get; }
        public string Name { get; }
        public string Patronymic { get; }
        public string Date_Of_Birth { get; }
        public int Age { get; }

        public User(string surname, string name, string patronymic, string dateOfBirth, int age)
        {
            string str = "1234567890+=/><?.,)(*&^%$#@!~`№;\"|";
            if (age < 14)
                throw new ArgumentException("Возраст человека не может быть меньше четырнадцати");
            if (surname[0] != surname.ToUpper()[0] || surname.Contains(str))
                throw new ArgumentException("Фамилия должна начинаться с заглавной буквы");
            if (name[0] != name.ToUpper()[0] || name.Contains(str))
                throw new ArgumentException("Имя должно начинаться с заглавной буквы");
            if (patronymic[0] != patronymic.ToUpper()[0] || patronymic.Contains(str))
                throw new ArgumentException("Отчество должно начинаться с заглавной буквы");
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Date_Of_Birth = dateOfBirth;
            Age = age;
        }
        
        public override string ToString()
        {
            return "ФИО: " + Surname + Name + Patronymic + ". " +
                 "Дата рождения: " + Date_Of_Birth + ". " + "Возраст: " + Age;
        }
    }
}