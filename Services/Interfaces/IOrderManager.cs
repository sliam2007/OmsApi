using OmsApi.Data;
using OmsApi.Models;

namespace OmsApi.Services.Interfaces
{
    public interface IOrderManager
    {
        CreateOrderResponse CreateOrder(CreateOrder data);
    }
}
