using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Exercise_ADONET
{
    public class StartUp
    {
        static async Task Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(Configuartion.CONNECTION_STRING);

            await sqlConnection.OpenAsync();

            await using (sqlConnection)
            {
                //Console.WriteLine("I connected to the database!");

                //SqlCommand createDbCommand = new SqlCommand(Queries.CREATE_DB_QUERY, sqlConnection);

                //await createDbCommand.ExecuteNonQueryAsync();
                //Console.WriteLine("Database [ADONETDB] was created succesfully!");

                await PrintVillainsWithMoreThan3MinionsАsync(sqlConnection);
            }
        }

        //Problem 2
        private static async Task PrintVillainsWithMoreThan3MinionsАsync(SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(Queries.VILLAINS_WITH_MORE_THAN_3_MINIONS, sqlConnection);

            SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();

            await using (sqlDataReader)
            {
                while (await sqlDataReader.ReadAsync())
                {
                    string villainNamne = sqlDataReader.GetString(0);
                    int minionsCount = sqlDataReader.GetInt32(1);

                    Console.WriteLine($"{villainNamne} - {minionsCount}");
                }
            }
        }

        //Problem 3
        private static async Task PrintVillainMinionsInfoByIdAsync(SqlConnection sqlConnection, int villainId)
        {
            SqlCommand sqlCommand = new SqlCommand(Queries.VILLAINS_WITH_MINIONS_INFO, sqlConnection);

            SqlParameter idParameter = new SqlParameter("@Id", SqlDbType.Int);

            idParameter.Value = villainId;
            sqlCommand.Parameters.Add(idParameter);
        }
    }
}
