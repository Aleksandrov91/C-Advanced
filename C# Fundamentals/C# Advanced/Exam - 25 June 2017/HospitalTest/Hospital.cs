using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hospital
{
    public class Hospital
    {
        public static void Main()
        {
            var departments = new Dictionary<string, Dictionary<int, List<string>>>();
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
                    departments[department] = new Dictionary<int, List<string>>()
                    {
                        {1, new List<string>()},
                        {2, new List<string>()},
                        {3, new List<string>()},
                        {4, new List<string>()},
                        {5, new List<string>()},
                        {6, new List<string>()},
                        {7, new List<string>()},
                        {8, new List<string>()},
                        {9, new List<string>()},
                        {10, new List<string>()},
                        {11, new List<string>()},
                        {12, new List<string>()},
                        {13, new List<string>()},
                        {14, new List<string>()},
                        {15, new List<string>()},
                        {16, new List<string>()},
                        {17, new List<string>()},
                        {18, new List<string>()},
                        {19, new List<string>()},
                        {20, new List<string>()},

                    };
                }

                var nastanenLiE = false;
                foreach (var kvp in departments[department])
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (kvp.Value.Count < 3)
                        {
                            kvp.Value.Add(patient);
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
                                Console.WriteLine(string.Join("\r\n", room.Value.OrderBy(p => p).Distinct()));
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
                            Console.WriteLine(string.Join("\r\n", patient.Value.Where(p => p != null).Distinct()));
                        }
                    }
                }


                outputCommand = Console.ReadLine();
            }



        }
    }
}
