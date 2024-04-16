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
namespace AC3_OlivellaArnau_Helper;

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
    public static void XMLGenerator(List<Consum> recConsums)
    {
        const string xmlFilePath = @"..\..\..\XML_Files\Consum_d_aigua_a_Catalunya_per_comarques_20240402.xml";
        var xml = new XElement("Comarques",
        from recConsum in recConsums
        select new XElement("Comarca",
        new XElement("CodiComarca", recConsum.CodiComarca),
        new XElement("Comarca", recConsum.Comarca)));
        xml.Save(xmlFilePath);
    }
    public static Dictionary<int, string> ComponentGenerator()
    {
        const string xmlFilePath = @"..\..\..\XML_Files\Consum_d_aigua_a_Catalunya_per_comarques_20240402.xml";
        var xml = XElement.Load(xmlFilePath);
        var components = new Dictionary<int, string>();
        foreach (var comarca in xml.Elements("Comarca"))
        {
            if (!components.ContainsKey((int)comarca.Element("CodiComarca")))
            {
                components.Add((int)comarca.Element("CodiComarca"), (string)comarca.Element("Comarca"));
            }
        }
        components = components.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        return components;
    }
    public static void AddToCSV(Consum consum)
    {
        const string csvFilePath = @"..\..\..\CSV_Files\Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv";
        using var writer = new StreamWriter(csvFilePath, true);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<ConsumMap>();
        csv.WriteRecord(consum);
        csv.NextRecord();
    }
    public static string PoblacioMida(int poblacio)
    {
        return poblacio > 20000 ? "Si" : "No";
    }
    public static string ConsumDM(float Consum, int Poblacio)
    {
        return (Consum / Poblacio).ToString();
    }
    public static string ConsumDPCMax(List<Consum> recConsums, float CDPC)
    {
        if (CDPC > recConsums.Max(x => x.ConsumDomesticPC))
        {
            return "Si";
        }
        else
        {
            return "No";
        }
    }
    public static string ConsumDPCMin(List<Consum> recConsums, float CDPC)
    {
        if (CDPC < recConsums.Min(x => x.ConsumDomesticPC))
        {
            return "Si";
        }
        else
        {
            return "No";
        }
    }
}
