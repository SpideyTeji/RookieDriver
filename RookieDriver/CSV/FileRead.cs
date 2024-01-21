using System.Formats.Asn1;
using System.Globalization;
using System;
using CsvHelper.Configuration;
using CsvHelper;
using RookieDriver.Models;

namespace RookieDriver.CSV
{
    public class FileRead
    {
        public string Filepath = "QuestionBank.csv";
        public void ReadQuestions()
        {
            try
            {
                if (File.Exists(Filepath))
                {

                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = false
                    };
                    using (StreamReader streamReader = new StreamReader(Filepath))
                    using (CsvReader csvReader = new CsvReader(streamReader, config))
                    {

                        // Read records from the CSV file
                        IEnumerable<Question> records = csvReader.GetRecords<Question>();

                        // Process each record
                        foreach (Question question in records)
                        {
                            Console.WriteLine($"Name: {question.Description}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
