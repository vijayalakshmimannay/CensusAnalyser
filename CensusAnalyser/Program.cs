using System;

namespace IndianStates_Codes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"C:\BridgeLabz\.Net_Fellowship\CensusAnalyser\CensusAnalyser\StateCensusData.csv";
            StateAnalyser getMethod = new StateAnalyser();
            getMethod.DataAnalyser(filePath);
        }
    }
}
