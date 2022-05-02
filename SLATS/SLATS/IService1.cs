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

    }
}
