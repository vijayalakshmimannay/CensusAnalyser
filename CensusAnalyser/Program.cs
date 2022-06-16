using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IndianStates_Codes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StateAnalyser getMethod = new StateAnalyser();
            string filePath = @"C:\BridgeLabz\.Net_Fellowship\CensusAnalyser\CensusAnalyser\StateCensusData.csv";
            string fileofPath = @"C:\BridgeLabz\.Net_Fellowship\CensusAnalyser\CensusAnalyser\StateCode.csv";
            getMethod.StateDataAnalyser(filePath);
            getMethod.StateCodeAnalyser(fileofPath);


        }
    }
}
