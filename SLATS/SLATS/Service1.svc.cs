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

        public string UpdateTeam(REF_Team oREF_Team)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_Team oBL_Team = new BL_Team();
                
               dt = oBL_Team.UpdateTeam(null, oREF_Team);

                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string DeleteTeam(REF_Team oREF_Team)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_Team oBL_Team = new BL_Team();              
                dt = oBL_Team.DeleteTeam(null, oREF_Team);

                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string LoadSoldiers()
        {
            DataTable dt = new DataTable();
            try
            {
                BL_Soldier oBL_Soldier = new BL_Soldier();

                dt = oBL_Soldier.LoadSoldiers(null);

                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string SaveSoldier(REF_Soldier oREF_Soldier)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_Soldier oBL_Soldier = new BL_Soldier();
               
                dt = oBL_Soldier.SaveSoldier(null, oREF_Soldier);

                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string UpdateSoldier(REF_Soldier oREF_Soldier)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_Soldier oBL_Soldier = new BL_Soldier();
           
                dt = oBL_Soldier.UpdateSoldier(null, oREF_Soldier);

                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string DeleteSoldier(REF_Soldier oREF_Soldier)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_Soldier oBL_Soldier = new BL_Soldier();
                dt = oBL_Soldier.DeleteSoldier(null, oREF_Soldier);

                return JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


    }
}
