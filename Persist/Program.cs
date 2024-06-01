using Controller;
using Model;

var lst = ReadFile.GetData("C:\\Users\\João Mazzoni\\Desktop\\dados_dos_radares.json");

RadarController.InsertJson(lst);

Console.WriteLine("Quantidade de Linhas: " + RadarController.getCountRecords(lst)); ;