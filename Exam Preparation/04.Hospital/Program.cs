//using System;
//using System.Linq;
//using System.Collections.Generic;

//namespace _04.Hospital
//{
//	class Program
//	{
//		static void Main(string[] args)
//		{
//			var departments = new Dictionary<string, List<string>>();
//			var doctors = new Dictionary<string, List<string>>();
//			var input = "";

//			while ((input = Console.ReadLine()) != "Output")
//			{
//				var patientData = input.Split("");
//				var departament = patientData[0];
//				var doctor = patientData[1] + " " + patientData[2];
//				var patient = patientData[3];

//				if (departments.ContainsKey(departament) == false)
//				{
//					departments.Add(departament, new List<string>());
//					departments[departament].Add(patient);
//				}

//				if (doctors.ContainsKey(doctor) == false)
//				{
//					doctors.Add(doctor, new List<string>());
//					doctors[doctor].Add(patient);
//				}
//			}

//			while ((input = Console.ReadLine()) != "End")
//			{
//				var splitCommand = input.Split();

//				if (splitCommand.Length == 1)
//				{
//					foreach (var patient in departments[input])
//					{
//						Console.WriteLine(patient);
//					}
//				}
//				else
//				{
//					int roomNumber = 0;

//					if (int.TryParse(splitCommand[1], out roomNumber))
//					{
//						var skip = 3 * (roomNumber - 1);

//						foreach (var patient in departments[splitCommand[0]].Skip(skip).Take(3).OrderBy(p => p))
//						{
//							Console.WriteLine(patient);
//						}
//					}
//					else
//					{
//						foreach (var patient in doctors[input].OrderBy(p => p))
//						{
//							Console.WriteLine(patient);
//						}
//					}
//				}
//			}
//		}
//	}
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _06.Hospital
{
	class Hospital
	{
		static void Main(string[] args)
		{
			var departments = new Dictionary<string, List<string>>();
			var doctors = new Dictionary<string, List<string>>();
			var line = Console.ReadLine();

			while (line != "Output")
			{
				var tokens = line.Split().ToArray();
				var dep = tokens[0];
				var dfn = tokens[1] + " " + tokens[2];
				var patient = tokens[3];

				if (!departments.ContainsKey(dep))
				{
					departments[dep] = new List<string>();
				}

				departments[dep].Add(patient);

				if (!doctors.ContainsKey(dfn))
				{
					doctors[dfn] = new List<string>();
				}

				doctors[dfn].Add(patient);
				line = Console.ReadLine();
			}

			line = Console.ReadLine().Trim();

			while (line != "End")
			{
				var token = line.Split().ToArray();

				if (token.Length == 1)
				{
					foreach (var patients in departments[line])
					{
						Console.WriteLine(patients);
					}
				}
				else if (int.TryParse(token[1], out int result))
				{
					if (int.Parse(token[1]) > 20)
					{
						continue;
					}

					var patients = departments[token[0]];
					var room = patients.Skip(3 * (int.Parse(token[1]) - 1)).Take(3).OrderBy(p => p);

					foreach (var patient in room)
					{
						Console.WriteLine(patient);
					}
				}
				else
				{
					var pat = doctors[line];
					pat.Sort();

					foreach (var patient in pat)
					{
						Console.WriteLine(patient);
					}
				}

				line = Console.ReadLine();
			}
		}
	}
}