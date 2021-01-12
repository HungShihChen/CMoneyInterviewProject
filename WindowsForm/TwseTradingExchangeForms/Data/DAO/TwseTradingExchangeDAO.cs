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
        private static Dictionary<int, List<TwseTradingExchangeModelData>> _YearDataDic;

        private static string dataRootDir = "Files/SavedData/";
        private static string zipFile = dataRootDir + "data.zip";
        public TwseTradingExchangeDAO()
        {
            InitData();
        }

        public void InitData()
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

            _YearDataDic = data;
        }

        private List<TwseTradingExchangeModelData> InitData(string filePath)
        {
            var content = File.ReadAllText(filePath);
            var d = JsonConvert.DeserializeObject<List<TwseTradingExchangeModelData>>(content);
            return d;
        }
        public List<TwseTradingExchangeModelData> GetData(string securitisID, DateTime st, DateTime et)
        {
            return GetData(st, et).Where(x => x.SecuritiesID == securitisID).OrderByDescending(x => x.Time).ToList();
        }

        public List<TwseTradingExchangeModelData> GetData(DateTime st, DateTime et)
        {
            List<TwseTradingExchangeModelData> data = new List<TwseTradingExchangeModelData>();
            for (int y = st.Year; y <= et.Year; y++)
            {
                if (_YearDataDic.ContainsKey(y))
                    data.AddRange(_YearDataDic[y].Where(x => x.SecuritiesID != null && x.Time >= st && x.Time <= et));
            }
            return data;
        }

        public void SaveData()
        {
            var data = _YearDataDic;
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

        public void UpdateData(DateTime st, DateTime et)
        {
            var data = _YearDataDic;
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
