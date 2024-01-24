using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RookieDriver.Models;

namespace RookieDriver.CSV
{
    public class FileRead
    {
        public string Filepath = "C:\\Users\\tejis\\source\\repos\\RookieDriver\\RookieDriver\\Data\\QuestionBank.csv";
        public List<QuestionCSV> ReadQuestions()
        {
            try
            {
                if (File.Exists(Filepath))
                {

                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = true
                    };
                    using (StreamReader streamReader = new StreamReader(Filepath))
                    using (CsvReader csvReader = new CsvReader(streamReader, config))
                    {

                        // Read records from the CSV file
                        IEnumerable<QuestionCSV> records = csvReader.GetRecords<QuestionCSV>();

                        return records.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<QuestionCSV>();
            }

            return new List<QuestionCSV>();
        }
    }
}
