using Newtonsoft.Json;
using System.Text;

namespace Model
{
    public class Radar
    {
        public static readonly string INSERT = "INSERT INTO Radar (Concessionaria, AnoDoPnvSnv, TipoDeRadar, Rodovia, Uf, KmM, Municipio, TipoPista, Sentido, Situacao, DataDaInativacao, Latitude, Longitude, VelocidadeLeve) VALUES (@Concessionaria, @AnoDoPnvSnv, @TipoDeRadar, @Rodovia, @Uf, @KmM, @Municipio, @TipoPista, @Sentido, @Situacao, @DataDaInativacao, @Latitude, @Longitude, @VelocidadeLeve)";
        public static readonly string UPDATE = "UPDATE Radar SET Concessionaria = @Concessionaria, AnoDoPnvSnv = @AnoDoPnvSnv, TipoDeRadar = @TipoDeRadar, Rodovia = @Rodovia, Uf = @Uf, KmM = @KmM, Municipio = @Municipio, TipoPista = @TipoPista, Sentido = @Sentido, Situacao = @Situacao, DataDaInativacao = @DataDaInativacao, Latitude = @Latitude, Longitude = @Longitude, VelocidadeLeve = @VelocidadeLeve WHERE Id = @Id";
        public static readonly string DELETE = "DELETE FROM Radar WHERE Id = @Id";
        public static readonly string GETALL = "SELECT Id, Concessionaria, AnoDoPnvSnv, TipoDeRadar, Rodovia, Uf, KmM, Municipio, TipoPista, Sentido, Situacao, DataDaInativacao, Latitude, Longitude, VelocidadeLeve FROM Radar";
        public static readonly string GET = "SELECT Id, Concessionaria, AnoDoPnvSnv, TipoDeRadar, Rodovia, Uf, KmM, Municipio, TipoPista, Sentido, Situacao, DataDaInativacao, Latitude, Longitude, VelocidadeLeve FROM Radar WHERE Id = @Id";

        
        public int Id { get; set; }

        [JsonProperty("concessionaria")]
        public string Concessionaria { get; set; }

        [JsonProperty("ano_do_pnv_snv")]
        public string AnoDoPnvSnv { get; set; }

        [JsonProperty("tipo_de_radar")]
        public string TipoDeRadar { get; set; }

        [JsonProperty("rodovia")]
        public string Rodovia { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("km_m")]
        public string KmM { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("tipo_pista")]
        public string TipoPista { get; set; }

        [JsonProperty("sentido")]
        public string Sentido { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("data_da_inativacao")]
        public object DataDaInativacao { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("velocidade_leve")]
        public string VelocidadeLeve { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Concessionaria: {Concessionaria}");
            sb.AppendLine($"Ano do PNV/SNV: {AnoDoPnvSnv}");
            sb.AppendLine($"Tipo de Radar: {TipoDeRadar}");
            sb.AppendLine($"Rodovia: {Rodovia}");
            sb.AppendLine($"UF: {Uf}");
            sb.AppendLine($"KM/M: {KmM}");
            sb.AppendLine($"Municipio: {Municipio}");
            sb.AppendLine($"Tipo de Pista: {TipoPista}");
            sb.AppendLine($"Sentido: {Sentido}");
            sb.AppendLine($"Situação: {Situacao}");
            sb.AppendLine($"Data da Inativação: {DataDaInativacao}");
            sb.AppendLine($"Latitude: {Latitude}");
            sb.AppendLine($"Longitude: {Longitude}");
            sb.AppendLine($"Velocidade Leve: {VelocidadeLeve}");
            return sb.ToString();
        }
    }
}
