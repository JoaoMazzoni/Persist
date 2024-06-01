using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Model
{
    public class ReadFile
    {
        public static List<Radar> GetData(string path)
        {
            try
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string jsonString = r.ReadToEnd();
                    Console.WriteLine("Conteúdo do arquivo JSON:");
                    Console.WriteLine(jsonString); // Imprime o conteúdo do arquivo JSON
                    var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, List<Radar>>>(jsonString);

                    if (jsonObject != null && jsonObject.ContainsKey("radar"))
                    {
                        return jsonObject["radar"];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao ler o arquivo JSON: {ex.Message}");
            }
            return null;
        }
    }
}
