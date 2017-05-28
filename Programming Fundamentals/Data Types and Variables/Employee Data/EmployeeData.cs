using System;

namespace Employee_Data
{
    public class EmployeeData
    {
        public static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            int age = 27;
            char gender = 'f';
            long personalID = 8306112507;
            uint employeeNumber = 27563571;
            Console.WriteLine($"First name: {firstName}\r\nLast name: {lastName}\r\nAge: {age}\r\nGender: {gender}\r\nPersonal ID: {personalID}\r\nUnique Employee number: {employeeNumber}");
        }
    }
}
