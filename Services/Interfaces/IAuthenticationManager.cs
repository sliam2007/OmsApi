using System.Threading.Tasks;

namespace OmsApi.Services.Interfaces
{
    public interface IAuthenticationManager
    {
        bool ValidateOmsId(string omsId);

        bool ValidateClientToken(string omsId, string clientToken);
    }
}
