using SLATS_DAL;
using SLATS_REF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLATS_BAL
{
    public class BL_Team
    {
        #region INSERT

        public DataTable CreateNewTeam(REF_Team oREF_Team, DB_Handle oDB_Handle)
        {
            DL_Team oDL_Team = new DL_Team();
            DataTable oDataTable = new DataTable();
            DataTable _dt = null;

            try
            {
                bool newDBHandle = false;
                if (oDB_Handle == null)
                {
                    oDB_Handle = new DB_Handle();
                    oDB_Handle.OpenConnection();
                    oDB_Handle.BeginTransaction();
                    newDBHandle = true;
                }
                oDataTable = oDL_Team.CreateNewTeam(oREF_Team, oDB_Handle);
                if (newDBHandle)
                {
                    oDB_Handle.CommitTransaction();
                    oDB_Handle.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    oDB_Handle.RollbackTransaction();
                    oDB_Handle.CloseConnection();
                }
                catch (Exception)
                {
                    return _dt;
                }
            }
            return oDataTable;
        }
        #endregion

        #region SELECT
        public DataTable LoadTeams(DB_Handle oDB_Handle)
        {
            DL_Team oDL_Team = new DL_Team();
            DataTable oDataTable = new DataTable();
            DataTable _dt = null;

            try
            {
                bool newDBHandle = false;
                if (oDB_Handle == null)
                {
                    oDB_Handle = new DB_Handle();
                    oDB_Handle.OpenConnection();
                    oDB_Handle.BeginTransaction();
                    newDBHandle = true;
                }
                oDataTable = oDL_Team.LoadTeams(oDB_Handle);
                if (newDBHandle)
                {
                    oDB_Handle.CommitTransaction();
                    oDB_Handle.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    oDB_Handle.RollbackTransaction();
                    oDB_Handle.CloseConnection();
                }
                catch (Exception)
                {
                    return _dt;
                }
            }
            return oDataTable;
        }
        #endregion
    }
}
