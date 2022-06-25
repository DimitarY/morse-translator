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
        private static string jsonPATH = Path.GetFullPath(Directory.GetCurrentDirectory() + "/JSON");

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
                throw;
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
                        client.DownloadFile(apiURL + "/download/json_files", jsonPATH + "/languages.zip");
                    }
                }
                else
                {
                    var values = new Dictionary<string, List<String>>
                    {
                        { "languages", newLanguages }
                    };

                    using (var client = new HttpClient())
                    {
                        var endpoint = new Uri(apiURL + "/download/json_files");
                        var newPostJson = JsonConvert.SerializeObject(values);
                        var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");

                        var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsByteArrayAsync().Result;

                        using (var stream = File.Create(jsonPATH + "/languages.zip"))
                        {
                            stream.Write(result, 0, result.Length);
                        } 
                    }
                }

                using (var zip = ZipFile.OpenRead(jsonPATH + "/languages.zip"))
                {
                    foreach (var entry in zip.Entries)
                    {
                        if (entry.Name.EndsWith(".json"))
                        {
                            entry.ExtractToFile(jsonPATH + "/" + entry.Name, true);
                        }
                    }
                }
                File.Delete(jsonPATH + "/languages.zip");


                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
