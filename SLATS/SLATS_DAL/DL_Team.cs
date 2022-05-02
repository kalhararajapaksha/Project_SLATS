using SLATS_REF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLATS_DAL
{
    public class DL_Team
    {
    
        #region INSERT
        public DataTable CreateNewTeam(REF_Team oREF_Team, DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;

            try
            {
                sqlQuery = "SP_ADD_Team";

                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@Team_Name", oREF_Team.Team_Name);
                oSqlCommand.Parameters.AddWithValue("@TargetLocation", oREF_Team.TargetLocation);
                oSqlCommand.Parameters.AddWithValue("@Description", oREF_Team.Description);
                oSqlCommand.Parameters.AddWithValue("@Longitude", oREF_Team.Longitude);
                oSqlCommand.Parameters.AddWithValue("@Latitude", oREF_Team.Latitude);
                oSqlCommand.Parameters.AddWithValue("@IsActive", oREF_Team.IsActive);
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);
                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region SELECT
        public DataTable LoadTeams(DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_SELECT_SelectAllTblTeam";
                oSqlCommand = new SqlCommand();
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectTeamsById(REF_Team oREF_Team, DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_SELECT_SelectByIDTeams";

                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@Team_ID", oREF_Team.Team_ID);
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);
                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
