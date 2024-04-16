using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CsvHelper;
using AC3_OlivellaArnau.Map;
using AC3_OlivellaArnau.Model;
namespace AC3_OlivellaArnau_Helper
{
    public class Helper
    {
        public static List<Consum> CSVReader()
        {
            const string csvFilePath = @"..\..\..\CSV_Files\Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv";

            List<Consum> recConsums;

            using var reader = new StreamReader(csvFilePath);
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<ConsumMap>();
                return csv.GetRecords<Consum>().ToList();
            }
        }
    }
}
