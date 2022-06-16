namespace CensusAnalyserTesting
{
    public class Tests
    {
        [Test]
        public void GivenStatesCensusCSVFile_CheckNumberOfRecordsMatches()
        {
            int expected = 29;
            string filePath = @"C:\BridgeLabz\.Net_Fellowship\CensusAnalyser\CensusAnalyser\StateCensusData.csv";
            IndianStates_Codes.StateAnalyser getMethod = new IndianStates_Codes.StateAnalyser();
            int actual = getMethod.StateDataAnalyser(filePath);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenInvalidFile_ShouldThrowInvalidFileException()
        {
            try
            {
                int expected = 29;
                string filePath = @"C:\BridgeLabz\.Net_Fellowship\CensusAnalyser\CensusAnalyser\StateCode.csv";
                IndianStates_Codes.StateAnalyser getMethod = new IndianStates_Codes.StateAnalyser();
                int actual = getMethod.StateDataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        
        [Test]
        public void GivenInvalidFileType_ShouldThrowInvalidFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabz\IndianStates-CensusAnalyser\IndianStates_Codes\StateCensusData.txt";
                IndianStates_Codes.StateAnalyser getMethod = new IndianStates_Codes.StateAnalyser();
                int actual = getMethod.StateDataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File Type", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidDelimiterFile_ShouldThrowInvalidDelimiterFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"C:\BridgeLabz\.Net_Fellowship\CensusAnalyser\CensusAnalyser\InvalidDelimeterCensusData.csv";
                IndianStates_Codes.StateAnalyser getMethod = new IndianStates_Codes.StateAnalyser();
                int actual = getMethod.StateDataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidHeaderFile_ShouldThrowInvalidHeaderFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"C:\BridgeLabz\.Net_Fellowship\CensusAnalyser\CensusAnalyser\InvalidHeaderCensusData.csv";
                IndianStates_Codes.StateAnalyser getMethod = new IndianStates_Codes.StateAnalyser();
                int actual = getMethod.StateDataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
    }
}
