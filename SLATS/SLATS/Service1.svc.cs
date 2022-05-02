using Newtonsoft.Json;
using SLATS_BAL;
using SLATS_REF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLATS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        #region INSERT
        public string CreateNewTeam(REF_Team oREF_Team, DB_Handle oDB_Handle)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_Team oBL_Team = new BL_Team();               
                dt = oBL_Team.CreateNewTeam(oREF_Team, null);
                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #endregion

        #region SELECT
        public string LoadAllTeams()
        {
            DataTable dt = new DataTable();
            try
            {
                BL_Team oBL_Team = new BL_Team();

                dt = oBL_Team.LoadTeams(null);

                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string SelectTeamsById()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
