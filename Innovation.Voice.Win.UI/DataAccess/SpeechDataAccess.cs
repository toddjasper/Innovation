using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Innovation.Voice.Win.UI.Models;

namespace Innovation.Voice.Win.UI.DataAccess
{
    public class SpeechDataAccess
    {
        private readonly SqlConnection _sqlConnection;

        public SpeechDataAccess()
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SpeechDB"].ConnectionString);
        }

        public ProfileEntity GetProfileIds(string username)
        {
            if (_sqlConnection == null) return null;

            var entity = new ProfileEntity();

            try
            {
                _sqlConnection.Open();

                var sqlCommand = new SqlCommand("[dbo].[Profiles_Get]", _sqlConnection) {CommandType = CommandType.StoredProcedure};
                sqlCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "username",
                    SqlValue = username
                });

                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    entity.Ids.Add(reader["ProfileId"] as string);
                }
            }
            finally
            {
                _sqlConnection.Close();
            }

            return entity;
        }

        public void InsertProfileId(string username, string profileId)
        {
            if (_sqlConnection == null) return;

            try
            {
                _sqlConnection.Open();

                var sqlCommand = new SqlCommand("[dbo].[Profiles_Insert]", _sqlConnection) { CommandType = CommandType.StoredProcedure };
                sqlCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "username",
                    SqlValue = username
                });

                sqlCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "profileId",
                    SqlValue = profileId
                });

                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                _sqlConnection.Close();
            }
        }
    }
}
