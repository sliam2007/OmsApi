using OmsApi.Data;
using OmsApi.Models;
using System.Threading.Tasks;

namespace OmsApi.Services.Interfaces
{
    public interface IOrderManager
    {
        CreateOrderResponse CreateOrder(CreateOrder data);
    }
}
