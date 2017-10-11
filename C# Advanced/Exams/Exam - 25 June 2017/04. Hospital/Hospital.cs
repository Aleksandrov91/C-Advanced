namespace _04.Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Hospital
    {
        public static void Main()
        {
            var departments = new Dictionary<string, Dictionary<int, string[]>>();
            var doctorsAndPatients = new Dictionary<string, HashSet<string>>();

            var inputLine = Console.ReadLine();
            while (inputLine != "Output")
            {
                var inputData = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var department = inputData[0];
                var doctor = inputData[1] + " " + inputData[2];
                var patient = inputData[3];

                if (!doctorsAndPatients.ContainsKey(doctor))
                {
                    doctorsAndPatients[doctor] = new HashSet<string>();
                }

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new Dictionary<int, string[]>()
                    {
                        { 1, new string[3] },
                        { 2, new string[3] },
                        { 3, new string[3] },
                        { 4, new string[3] },
                        { 5, new string[3] },
                        { 6, new string[3] },
                        { 7, new string[3] },
                        { 8, new string[3] },
                        { 9, new string[3] },
                        { 10, new string[3] },
                        { 11, new string[3] },
                        { 12, new string[3] },
                        { 13, new string[3] },
                        { 14, new string[3] },
                        { 15, new string[3] },
                        { 16, new string[3] },
                        { 17, new string[3] },
                        { 18, new string[3] },
                        { 19, new string[3] },
                        { 20, new string[3] }
                    };
                }

                /*doctorsAndPatients.Any(x => x.Value.Contains(patient)*/

                if (departments.Any(x => x.Value.Any(y => y.Value.Contains(patient))))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                var nastanenLiE = false;
                foreach (var kvp in departments[department])
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (kvp.Value[i] == null)
                        {
                            kvp.Value[i] = patient;
                            doctorsAndPatients[doctor].Add(patient);
                            nastanenLiE = true;
                            break;
                        }
                    }

                    if (nastanenLiE)
                    {
                        break;
                    }
                }

                inputLine = Console.ReadLine();
            }

            var outputCommand = Console.ReadLine();

            while (outputCommand != "End")
            {
                var outputData = outputCommand.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (outputData.Length > 1)
                {
                    int roomNumber = 0;
                    if (int.TryParse(outputData[1], out roomNumber))
                    {
                        foreach (var department in departments.Where(x => x.Key == outputData[0]))
                        {
                            foreach (var room in department.Value.Where(r => r.Key == roomNumber))
                            {
                                Console.WriteLine(string.Join("\r\n", room.Value.Where(p => p != null).OrderBy(p => p)));
                            }
                        }
                    }
                    else
                    {
                        foreach (var keyValuePair in doctorsAndPatients.Where(d => d.Key == outputData[0] + " " + outputData[1]))
                        {
                            Console.WriteLine(string.Join("\r\n", keyValuePair.Value.OrderBy(p => p)));
                        }
                    }
                }
                else
                {
                    foreach (var keyValuePair in departments.Where(x => x.Key == outputData[0]))
                    {
                        foreach (var patient in keyValuePair.Value)
                        {
                            Console.WriteLine(string.Join("\r\n", patient.Value.Where(p => p != null)));
                        }
                    }
                }

                outputCommand = Console.ReadLine();
            }
        }
    }
}
