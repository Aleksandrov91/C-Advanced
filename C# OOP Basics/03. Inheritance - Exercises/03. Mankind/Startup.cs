namespace _03.Mankind
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            try
            {
                var studentData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var student = new Student(studentData[0], studentData[1], studentData[2]);

                var workerData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var worker = new Worker(workerData[0], workerData[1], double.Parse(workerData[2]), double.Parse(workerData[3]));

                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
