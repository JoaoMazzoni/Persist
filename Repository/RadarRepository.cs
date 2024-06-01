using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Repository
{
    public class RadarRepository
    {
        string strConn = "Server=127.0.0.1; Database=DBRadar; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        SqlConnection conn;

        public RadarRepository()
        {

        }

        public bool Insert(Radar radar)
        {
            bool result = false;
            Console.WriteLine("Camada Repository");

            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open(); // Abre a conexão aqui
                    SqlCommand cmd = new SqlCommand(Radar.INSERT, conn);

                    cmd.Parameters.Add(new SqlParameter("@Id", radar.Id));
                    cmd.Parameters.Add(new SqlParameter("@Concessionaria", radar.Concessionaria));
                    cmd.Parameters.Add(new SqlParameter("@AnoDoPnvSnv", radar.AnoDoPnvSnv));
                    cmd.Parameters.Add(new SqlParameter("@TipoDeRadar", radar.TipoDeRadar));
                    cmd.Parameters.Add(new SqlParameter("@Rodovia", radar.Rodovia));
                    cmd.Parameters.Add(new SqlParameter("@Uf", radar.Uf));
                    cmd.Parameters.Add(new SqlParameter("@KmM", radar.KmM));
                    cmd.Parameters.Add(new SqlParameter("@Municipio", radar.Municipio));
                    cmd.Parameters.Add(new SqlParameter("@TipoPista", radar.TipoPista));
                    cmd.Parameters.Add(new SqlParameter("@Sentido", radar.Sentido));
                    cmd.Parameters.Add(new SqlParameter("@Situacao", radar.Situacao));
                    cmd.Parameters.Add(new SqlParameter("@DataDaInativacao", radar.DataDaInativacao));
                    cmd.Parameters.Add(new SqlParameter("@Latitude", radar.Latitude));
                    cmd.Parameters.Add(new SqlParameter("@Longitude", radar.Longitude));
                    cmd.Parameters.Add(new SqlParameter("@VelocidadeLeve", radar.VelocidadeLeve));
                    

                    cmd.ExecuteNonQuery(); // Executa a consulta

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao inserir no banco de dados: {ex.Message}");
                return false;
            }
        }


        public bool Update(Radar radar)
        {
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand(Radar.UPDATE, conn);

                cmd.Parameters.Add(new SqlParameter("@Id", radar.Id));
                cmd.Parameters.Add(new SqlParameter("@Concessionaria", radar.Concessionaria));
                cmd.Parameters.Add(new SqlParameter("@AnoDoPnvSnv", radar.AnoDoPnvSnv));
                cmd.Parameters.Add(new SqlParameter("@TipoDeRadar", radar.TipoDeRadar));
                cmd.Parameters.Add(new SqlParameter("@Rodovia", radar.Rodovia));
                cmd.Parameters.Add(new SqlParameter("@Uf", radar.Uf));
                cmd.Parameters.Add(new SqlParameter("@KmM", radar.KmM));
                cmd.Parameters.Add(new SqlParameter("@Municipio", radar.Municipio));
                cmd.Parameters.Add(new SqlParameter("@TipoPista", radar.TipoPista));
                cmd.Parameters.Add(new SqlParameter("@Sentido", radar.Sentido));
                cmd.Parameters.Add(new SqlParameter("@Situacao", radar.Situacao));
                cmd.Parameters.Add(new SqlParameter("@DataDaInativacao", radar.DataDaInativacao));
                cmd.Parameters.Add(new SqlParameter("@Latitude", radar.Latitude));
                cmd.Parameters.Add(new SqlParameter("@Longitude", radar.Longitude));
                cmd.Parameters.Add(new SqlParameter("@VelocidadeLeve", radar.VelocidadeLeve));
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                return result;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand(Radar.DELETE, conn);
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                return (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public List<Radar> GetAll()
        {
            List<Radar> radars = new List<Radar>();
            StringBuilder sb = new StringBuilder();
            sb.Append(Radar.GETALL);

            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Radar radar = new Radar
                    {
                        Id = reader.GetInt32(0),
                        Concessionaria = reader.GetString(1),
                        AnoDoPnvSnv = reader.GetString(2),
                        TipoDeRadar = reader.GetString(3),
                        Rodovia = reader.GetString(4),
                        Uf = reader.GetString(5),
                        KmM = reader.GetString(6),
                        Municipio = reader.GetString(7),
                        TipoPista = reader.GetString(8),
                        Sentido = reader.GetString(9),
                        Situacao = reader.GetString(10),
                        DataDaInativacao = reader.GetString(11),
                        Latitude = reader.GetString(12),
                        Longitude = reader.GetString(13),
                        VelocidadeLeve = reader.GetString(14)
                    };

                    radars.Add(radar);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return radars;
        }

        public Radar Get(int id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Radar.GET);
            Radar radar = null;

            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    radar = new Radar
                    {
                        Id = reader.GetInt32(0),
                        Concessionaria = reader.GetString(1),
                        AnoDoPnvSnv = reader.GetString(2),
                        TipoDeRadar = reader.GetString(3),
                        Rodovia = reader.GetString(4),
                        Uf = reader.GetString(5),
                        KmM = reader.GetString(6),
                        Municipio = reader.GetString(7),
                        TipoPista = reader.GetString(8),
                        Sentido = reader.GetString(9),
                        Situacao = reader.GetString(10),
                        DataDaInativacao = reader.GetString(11),
                        Latitude = reader.GetString(12),
                        Longitude = reader.GetString(13),
                        VelocidadeLeve = reader.GetString(14)
                    };
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return radar;
        }
    }
}

