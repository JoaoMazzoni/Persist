using Model;
using Service;


namespace Controller
{
    public class RadarController
    {
        private RadarService radarService;

        public RadarController()
        {
            radarService = new RadarService();
        }

        public bool Insert(Radar radar)
        {
            Console.WriteLine("\nCamada Controller");
            return radarService.Insert(radar);
        }

        public bool Delete(int id)
        {
            return radarService.Delete(id);
        }

        public Radar Get(int id)
        {
            return radarService.Get(id);
        }

        public bool Update(Radar radar)
        {
            return radarService.Update(radar);
        }

        public List<Radar> GetAll()
        {
            return radarService.GetAll();
        }

        public static void InsertJson(List<Radar> lista)
        {
            RadarController controller = new RadarController();
            foreach (var item in lista)
            {
                controller.Insert(item);
            }
        }


        public static int getCountRecords(List<Radar> lista) => lista.Count;
    }
}
