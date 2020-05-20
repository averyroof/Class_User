using System;

namespace Class_User
{
    public class Employee: User
    {
        public string WorkExperience { get; }
        public string Position { get; }

        public Employee(string surname, string name, string patronymic, string dateOfBirth, int age, 
            string workExperience, string position) : base(surname, name, patronymic, dateOfBirth, age)
        {
            WorkExperience = workExperience;
            Position = position;
        }

        public string Experience => "Стаж работы: " + WorkExperience;
        
        public string Pos => "Должность: " + Position ;
        
        public override string ToString()
        {
            return "ФИО: " + Surname + Name + Patronymic + "| " +
                 "Дата рождения: " + Date_Of_Birth + "| " + "Возраст: " + Age  + " | " + Experience + " | " + Pos;
        }
    }
}