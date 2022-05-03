using SLATS_REF;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace SLATS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        #region INSERT
        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "CreateNewTeam",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string CreateNewTeam(REF_Team oREF_Team, DB_Handle oDB_Handle);
        #endregion

        #region SELECT
        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "LoadAllTeams",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string LoadAllTeams();

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "SelectTeamsById",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string SelectTeamsById();

        #endregion
        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "UpdateTeam",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string UpdateTeam(REF_Team oREF_Team);

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "DeleteTeam",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string DeleteTeam(REF_Team oREF_Team);

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "LoadAllSoldiers",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string LoadSoldiers();

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "SaveSoldier",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string SaveSoldier(REF_Soldier oREF_Soldier);

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "UpdateSoldier",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string UpdateSoldier(REF_Soldier oREF_Soldier);

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "DeleteSoldier",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string DeleteSoldier(REF_Soldier oREF_Soldier);

    }



}
