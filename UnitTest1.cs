using Indian_States_Census_Analyzer_Problem;
using static Indian_States_Census_Analyzer_Problem.CensusAnalyzer;
using Indian_States_Census_Analyzer_Problem.DTO;

namespace TestProject1
{

    [TestClass]
    public class UnitTest1
    {
        static string indianStateCensusHeaders = @"State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = @"SrNo,State Name,TIN,StateCode";
        static string indianStateCensusFilePath = @"C:\Users\ganesh\source\repos\Indian_States_Census_Analyzer_Problem\Indian_States_Census_Analyzer_Problem\CSVFiles\IndiaStateCensusData.csv";
        static string wrongHeaderIndianCensusFilePath = @"C:\Users\ganesh\source\repos\Indian_States_Census_Analyzer_Problem\Indian_States_Census_Analyzer_Problem\CSVFiles\WrongIndiaStateCensusData.csv";
        static string delimeterIndianCensusFilePath = @"C:\Users\ganesh\source\repos\Indian_States_Census_Analyzer_Problem\Indian_States_Census_Analyzer_Problem\CSVFiles\DelimiterIndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"C:\Users\ganesh\source\repos\Indian_States_Census_Analyzer_Problem\Indian_States_Census_Analyzer_Problem\CSVFiles\WrongIndiaStateCensusData.csv";
        static string wrongIndianCensusFileType = @"C:\Users\ganesh\source\repos\Indian_States_Census_Analyzer_Problem\Indian_States_Census_Analyzer_Problem\CSVFiles\IndiaStateCensusData.txt";

        static string indianStateCodeFilePath = @"C:\Users\ganesh\source\repos\Indian_States_Census_Analyzer_Problem\Indian_States_Census_Analyzer_Problem\CSVFiles\IndiaStateCode.csv";
        static string wrongIndianStateCodeFileType = @"C:\Users\ganesh\source\repos\Indian_States_Census_Analyzer_Problem\Indian_States_Census_Analyzer_Problem\CSVFiles\IndiaStateCode.txt";
        static string delimeterIndianStateCodeFilePath = @"C:\Users\ganesh\source\repos\Indian_States_Census_Analyzer_Problem\Indian_States_Census_Analyzer_Problem\CSVFiles\DelimiterIndiaStateCode.csv";
        static string wrongHeaderStateCodeFilePath = @"C:\Users\ganesh\source\repos\Indian_States_Census_Analyzer_Problem\Indian_States_Census_Analyzer_Problem\CSVFiles\WrongIndiaStateCode.csv";

        Indian_States_Census_Analyzer_Problem.CensusAnalyzer censusAnalyzer;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [TestMethod]
        public void Setup()
        {
            censusAnalyzer = new CensusAnalyzer();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

        //Use case - 1
        //Happy Test Case 1.1 : the records are checked
        [TestMethod]
        public void GivenIndianCensusDataFile_WhenRead_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyzer.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            System.Console.WriteLine("Indian state records Count : " + totalRecord.Count);
            Assert.AreEqual(29, totalRecord.Count);
        }
        
        //Sad Test Case 1.2 : to verify if the exception is raised.
        [TestMethod]
        public void GivenIndianCensusDataFile_WhenRead_ShouldReturnException()
        {
            totalRecord = censusAnalyzer.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(37, totalRecord.Count);
        }

        //Sad Test Case 1.3 : if the type is incorrect then exception is raised.
        [TestMethod]
        public void GivenIndianCensusDataFileTypeWrong_WhenRead_ShouldReturnException()
        {
            totalRecord = censusAnalyzer.LoadCensusData(Country.INDIA, wrongIndianCensusFileType, indianStateCensusHeaders);

            Assert.AreEqual(29, totalRecord.Count);
        }

        //Sad Test Case 1.4 : if the file delimiter is incorrect then exception is raised.
        [TestMethod]
        public void GivenIndianCensusDataFileDelimeterWrong_WhenRead_ShouldReturnException()
        {
            totalRecord = censusAnalyzer.LoadCensusData(Country.INDIA, delimeterIndianCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }

        //Sad Test Case 1.5 : if the header is incorrect then exception is raised.
        [TestMethod]
        public void GivenIndianCensusDataFileCsvHeaderWrong_WhenRead_ShouldReturnException()
        {
            totalRecord = censusAnalyzer.LoadCensusData(Country.INDIA, wrongHeaderIndianCensusFilePath, wrongHeaderIndianCensusFilePath);
            Assert.AreEqual(29, totalRecord.Count);
        }

        //Use case - 2
        //Happy Test Case 2.1 : the records are checked
        [TestMethod]
        public void GivenIndianStateCodeFile_WhenRead_ShouldReturnCensusDataCount()
        {
            stateRecord = censusAnalyzer.LoadCensusData(Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
            System.Console.WriteLine("State Record Count : " + stateRecord.Count);
            Assert.AreEqual(37, stateRecord.Count);
        }

        //Sad Test Case 2.2 : to verify if the exception is raised.
        [TestMethod]
        public void GivenIndianStateCodeFile_WhenRead_ShouldReturnException()
        {
            stateRecord = censusAnalyzer.LoadCensusData(Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(29, stateRecord.Count);
        }

        //Sad Test Case 2.3 : if the type is incorrect then exception is raised.
        [TestMethod]
        public void GivenIndianStateCode_FileTypeWrong_WhenRead_ShouldReturnException()
        {
            stateRecord = censusAnalyzer.LoadCensusData(Country.INDIA, wrongIndianStateCodeFileType, indianStateCodeHeaders);
            Assert.AreEqual(37, stateRecord.Count);
        }

        //Sad Test Case 2.4 : if the file delimiter is incorrect then exception is raised.
        [TestMethod]
        public void GivenIndianStateCodeFile_DelimeterWrong_WhenRead_ShouldReturnException()
        {
            stateRecord = censusAnalyzer.LoadCensusData(Country.INDIA, delimeterIndianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(37, stateRecord.Count);
        }

        //Sad Test Case 2.5 : if the header is incorrect then exception is raised.
        [TestMethod]
        public void GivenIndianStateCodeFile_CsvHeaderWrong_WhenRead_ShouldReturnException()
        {
            stateRecord = censusAnalyzer.LoadCensusData(Country.INDIA, wrongHeaderStateCodeFilePath, wrongHeaderStateCodeFilePath);
            Assert.AreEqual(37, stateRecord.Count);
        }
    }
}
