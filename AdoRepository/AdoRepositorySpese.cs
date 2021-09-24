using RimborsoImpiegati.Core.Entity;
using RimborsoImpiegati.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoRepository
{
   public class AdoRepositorySpese : IRepositorySpese
    {


        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                        "Initial Catalog = AcademyI.EsercitazioneFinale;" +
                                        "Integrated Security = true";
        public List<Spesa> Fetch()
        {
            throw new NotImplementedException();
        }

        public Spesa GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Spesa> GetItemsWithOutApprov()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "select * from dbo.Spese where Approvata is null";

                    SqlDataReader reader = command.ExecuteReader();

                    List<Spesa> spese = new List<Spesa>();

                    while (reader.Read())
                    {
                        Spesa spesa = new Spesa();
                        spesa.Id = (int)reader["Id"];
                        spesa.DataSpesa = Convert.ToDateTime(reader["Data"]); 
                        spesa.ContoSpesa = (double)(reader["Spesa"]);
                        spesa.CategoriA = (_Categoria)(reader["Categoria"]);
                        spesa.Description = (string)(reader["Descrizione"]);
                        spesa.IdDipendente = (int)(reader["Dipendente"]);
                        spesa.Approvata = (bool)(reader["Approvata"]);
                        spesa.Rimborso = (double)(reader["Rimborso"]);
                        spesa.ApprovatorE = (_Approvatore)(reader["Approvatore"]);




                        spese.Add(spesa);
                    }

                    return spese;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
