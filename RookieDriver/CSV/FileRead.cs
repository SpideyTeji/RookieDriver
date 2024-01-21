using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RookieDriver.Models;

namespace RookieDriver.csv
{
    public class FileRead
    {
        public string Filepath = "C:\\Users\\tejis\\source\\repos\\RookieDriver\\RookieDriver\\Data\\QuestionBank.csv";
        public List<Question> ReadQuestions()
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
                        IEnumerable<Question> records = csvReader.GetRecords<Question>();

                        return records.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<Question>();
            }

            return new List<Question>();
        }
    }
}
