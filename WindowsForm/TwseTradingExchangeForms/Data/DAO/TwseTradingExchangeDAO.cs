using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TwseTradingExchangeForms.Data.ModelData;
using TwseTradingExchangeForms.WebApi.DAO;

namespace TwseTradingExchangeForms.Data.DAO
{
    public class TwseTradingExchangeDAO
    {
        private static string dataRootDir = "Files/SavedData/";
        private static string zipFile = dataRootDir + "data.zip";

        public Dictionary<int, List<TwseTradingExchangeModelData>> InitData()
        {
            if(!Directory.Exists(dataRootDir))
            {
                Directory.CreateDirectory(dataRootDir);
            }
            foreach (var filePath in Directory.GetFiles(dataRootDir))
            {
                if (filePath != zipFile)
                    File.Delete(filePath);
            }
            if (File.Exists(zipFile))
            {
                var za = ZipFile.OpenRead(zipFile);
                foreach (ZipArchiveEntry e in za.Entries)
                {
                    e.ExtractToFile(dataRootDir + e.Name, true);
                }
                za.Dispose();
                //ZipFileExtensions.ExtractToDirectory(zipFile, dataRootDir);
                File.Delete(zipFile);
            }
            Dictionary<int, List<TwseTradingExchangeModelData>> data = new Dictionary<int, List<TwseTradingExchangeModelData>>();

            foreach (var filePath in Directory.GetFiles(dataRootDir))
            {                
                int year = int.Parse(Path.GetFileNameWithoutExtension(filePath));
                data.Add(year, InitData(filePath));
            }

            return data;
        }

        public List<TwseTradingExchangeModelData> InitData(string filePath)
        {
            var content = File.ReadAllText(filePath);
            var d = JsonConvert.DeserializeObject<List<TwseTradingExchangeModelData>>(content);
            return d;
        }


        public void SaveData(Dictionary<int, List<TwseTradingExchangeModelData>> data)
        {
            string tempDir = dataRootDir + "temp/";
            Directory.CreateDirectory(tempDir);
            foreach (var d in data)
            {
                var content = JsonConvert.SerializeObject(d.Value);
                File.WriteAllText(tempDir + d.Key, content);
            }
            ZipFile.CreateFromDirectory(tempDir, zipFile);
            foreach (var item in Directory.GetFiles(tempDir))
                File.Delete(item);
            Directory.Delete(tempDir);
        }

        public void UpdateData(Dictionary<int, List<TwseTradingExchangeModelData>> data, DateTime st, DateTime et)
        {
            TwseTradingExchangeApiDAO apiDao = new TwseTradingExchangeApiDAO();
            for (DateTime t = st; t <= et; t = t.AddDays(1))
            {
                int year = t.Year;
                if (!data.ContainsKey(year))
                    data.Add(year, new List<TwseTradingExchangeModelData>());
                var d = data[year];
                if(d.Count(x => x.Time == t) == 0)
                {
                    d.AddRange(apiDao.GetTwseTradingExchange(t));
                    Thread.Sleep(50);
                }
            }
        }

        public void DeleteData()
        {
            foreach (var item in Directory.GetFiles(dataRootDir))
                File.Delete(item);
        }
    }
}
