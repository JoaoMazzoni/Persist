using Model;
using Repository;
using System.Collections.Generic;
using System;
using System.Text.Json;

namespace Service
{
    public class RadarService
    {
        private RadarRepository radarRepository;

        public RadarService()
        {
            radarRepository = new RadarRepository();
        }

        public bool Insert(Radar radar)
        {
            Console.WriteLine("Camada Service");
            return radarRepository.Insert(radar);
        }

        public bool Update(Radar radar)
        {
            return radarRepository.Update(radar);
        }

        public Radar Get(int id)
        {
            return radarRepository.Get(id);
        }

        public bool Delete(int id)
        {
            return radarRepository.Delete(id);
        }

        public List<Radar> GetAll()
        {
            return radarRepository.GetAll();
        }

        public bool InsertDataFromJson(string jsonContent)
        {
            try
            {
                // Desserializa o conteúdo JSON para uma lista de objetos Radar
                var radars = JsonSerializer.Deserialize<List<Radar>>(jsonContent);

                // Insere os objetos Radar no banco de dados
                foreach (var radar in radars)
                {
                    radarRepository.Insert(radar);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao inserir os dados do JSON no banco de dados: {ex.Message}");
                return false;
            }
        }


    }
}
