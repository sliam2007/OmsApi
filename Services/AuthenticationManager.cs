using OmsApi.Services.Interfaces;

namespace OmsApi.Services
{
    public class AuthenticationManager : IAuthenticationManager
    {
        public bool ValidateClientToken(string omsId, string clientToken)
        {
            // workaround
            // valid omsId/clientToken pairs
            // 0645848 / 1cecc8fb-fb47-4c8a-af3d-d34c1ead8c4f
            // 0258963 / 1fa7d94a-9c3f-4af6-9924-2ddd0f93353e
            // 0158663 / 41062f80-8fb3-406b-8f9a-4a89035d0fa7

            if ((omsId == "0645848" && clientToken == "1cecc8fb-fb47-4c8a-af3d-d34c1ead8c4f") ||
                (omsId == "0258963" && clientToken == "1fa7d94a-9c3f-4af6-9924-2ddd0f93353e") ||
                (omsId == "0158663" && clientToken == "41062f80-8fb3-406b-8f9a-4a89035d0fa7"))
            {
                return true;
            }
            return false;

        }

        public bool ValidateOmsId(string omsId)
        {
            // workaround
            // valid omsId 
            // 0645848
            // 0258963
            // 0158663

            switch (omsId)
            {
                case "0645848":
                case "0258963":
                case "0158663":
                    return true;
                default: 
                    return false;
            }
        }
    }
}