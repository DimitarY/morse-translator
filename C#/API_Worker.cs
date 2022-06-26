using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Morse_Translator
{
    internal class API_Worker
    {
        private static API_Worker instance = null;
        public static API_Worker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new API_Worker();
                }
                return instance;
            }
        }

        private static string apiURL = "http://127.0.0.1:5000";
        private static string languagesPATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Morse Translator/Languages";
        private bool available = false;

        public bool Available { get { return this.available; } }

        public bool isAvailable() //TODO: има лек лаг докато проверява дали може да свали данни от сървъра (когато сървъра не е онлайн или не може да се дотъпи)
        {
            try
            {
                WebClient client = new WebClient();
                if (client.DownloadString(apiURL) != null) return this.available = true;
                else return this.available = false;
            }
            catch (Exception)
            {
                return this.available = false;
                throw;
            }
        }

        public List<String> getLanguages()
        {
            List<String> languages = new List<String>();
            try
            {
                string json = "";
                using (var client = new HttpClient())
                {
                    var endpoint = new Uri(apiURL + "/get/json-languages");
                    var result = client.GetAsync(endpoint).Result;
                    json = result.Content.ReadAsStringAsync().Result;
                }

                return languages = JsonConvert.DeserializeObject<List<String>>(json);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void removeLanguages(List<String> newLanguages)
        {
            foreach (var item in Language.getLanguages())
            {
                if (!newLanguages.Contains(item)) File.Delete(languagesPATH + $"/{item}.json");
            }
        }

        public bool downloadLanguages(List<String> newLanguages)
        {
            try
            {
                if (newLanguages == null)
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile(apiURL + "/download/json_files", languagesPATH + "/languages.zip");
                    }
                }
                else
                {
                    var values = new Dictionary<String, List<String>>
                    {
                        { "languages", newLanguages }
                    };

                    using (var client = new HttpClient())
                    {
                        var endpoint = new Uri(apiURL + "/download/json_files");
                        var newPostJson = JsonConvert.SerializeObject(values);
                        var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");

                        var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsByteArrayAsync().Result;

                        using (var stream = File.Create(languagesPATH + "/languages.zip"))
                        {
                            stream.Write(result, 0, result.Length);
                        }
                    }
                }

                if (newLanguages != null) this.removeLanguages(newLanguages);

                using (var zip = ZipFile.OpenRead(languagesPATH + "/languages.zip"))
                {
                    foreach (var entry in zip.Entries)
                    {
                        if (entry.Name.EndsWith(".json"))
                        {
                            entry.ExtractToFile(languagesPATH + "/" + entry.Name, true);
                        }
                    }
                }
                File.Delete(languagesPATH + "/languages.zip");

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
