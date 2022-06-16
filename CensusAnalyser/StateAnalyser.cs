using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStates_Codes
{
    public class StateAnalyser
    {
        public int DataAnalyser(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var details = csv.GetRecords<StateModel>().ToList();
                var numberOfRecords = details.Count();
                foreach (var info in details)
                {
                    Console.WriteLine("State: " + info.State + "\nPopulation: " + info.Population + "\nAreaInSqKm: " + info.AreaInSqKm
                        + "\nDensityPerSqKm: " + info.DensityPerSqKm + "\n");
                }
                return numberOfRecords;
            }
        }

    }
}