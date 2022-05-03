using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLATS_REF;
using System.Data;
using System.Data.SqlClient;

namespace SLATS_DAL
{
    public class DL_Soldier
    {
        public DataTable LoadSoldiers(DB_Handle oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_GET_LoadSoldiers";
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

        public DataTable SaveSoldier(DB_Handle oDB_Handle, REF_Soldier oREF_Soldier)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_ADD_Soldier";
                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@Soldier_Name", oREF_Soldier.Soldier_Name);
                oSqlCommand.Parameters.AddWithValue("@Gender", oREF_Soldier.Gender);
                oSqlCommand.Parameters.AddWithValue("@DOB", oREF_Soldier.DOB);
                oSqlCommand.Parameters.AddWithValue("@InMi", oREF_Soldier.InMi);
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

        public DataTable UpdateSoldier(DB_Handle oDB_Handle, REF_Soldier oREF_Soldier)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_UPDATE_Soldier";
                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@Soldier_ID", oREF_Soldier.Soldier_ID);
                 oSqlCommand.Parameters.AddWithValue("@Soldier_Name", oREF_Soldier.Soldier_Name);
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

        public DataTable DeleteSoldier(DB_Handle oDB_Handle, REF_Soldier oREF_Soldier)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_DELETE_Soldier";
                oSqlCommand = new SqlCommand();
               oSqlCommand.Parameters.AddWithValue("@Soldier_ID", oREF_Soldier.Soldier_ID);   
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

    }

    
}
