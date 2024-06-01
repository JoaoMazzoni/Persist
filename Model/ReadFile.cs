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
                    var objetoGeral = JsonConvert.DeserializeObject<Radares>(jsonString);

                    if (objetoGeral != null) return objetoGeral.registros;
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
