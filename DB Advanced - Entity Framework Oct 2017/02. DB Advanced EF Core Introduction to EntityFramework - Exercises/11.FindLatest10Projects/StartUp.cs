namespace _11.FindLatest10Projects
{
    using _00.DatabaseModel.Data;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var projects = context.Projects
                    .OrderByDescending(p => p.StartDate)
                    .Take(10)
                    .OrderBy(p => p.Name)
                    .ToList();

                foreach (var project in projects)
                {
                    Console.WriteLine(project.Name);
                    Console.WriteLine(project.Description);
                    Console.WriteLine(project.StartDate);
                }
            }
        }
    }
}
