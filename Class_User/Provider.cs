using System;
using System.Collections.Generic;
using System.IO;

namespace Class_User
{
    public class Provider
    {
        private  List<Employee> List_Emp = new List<Employee>();

        public Provider(List<Employee> list_emp)
        {
            List_Emp = list_emp;
        }

        public static List<Employee> LoadFromFile()
        {
            using StreamReader sr = new StreamReader("input.txt");
            int n = int.Parse(sr.ReadLine());
            List<Employee> ListOfEmpl = new List<Employee>();
            List<string> ParametersEmpl = new List<string>();
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        ParametersEmpl.Add(sr.ReadLine());
                        if (ParametersEmpl[j] == null)
                        {
                            throw new ArgumentException($@"Неккоректно введены данные!");
                        }
                    }

                    ListOfEmpl.Add(new Employee(ParametersEmpl[0], ParametersEmpl[1], ParametersEmpl[2],
                        ParametersEmpl[3], int.Parse(ParametersEmpl[4]), ParametersEmpl[5], ParametersEmpl[6]));
                    ParametersEmpl.Clear();
                }
                return ListOfEmpl;
            }

            return null;
        }

        public void SaveToFile()
        {
            using StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine("Личные данные сотрудников:");
            for (int i = 0; i < List_Emp.Count; i++)
            {
                sw.WriteLine(List_Emp[i].ToString());
            }
        }
    }
}