using OmsApi.Data;
using OmsApi.Models;
using OmsApi.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace OmsApi.Services
{
    public class OrderManager : IOrderManager
    {
        public CreateOrderResponse CreateOrder(CreateOrder data)
        {
            //response
            CreateOrderResponse result = new();

            // valiate serialNumbers
            foreach (var product in data.products)
            {
                if (product.serialNumberType== "SELF_MADE")
                {
                    // an amount of serialNumbers must be equal to quantity
                    if (product.quantity != product.serialNumbers.Length)
                    {
                        result.error = String.Format("Amount of serialNumbers is not equal to product quantity (gtin:{0}).",
                            product.gtin);
                        
                        return result;
                    }

                    // check serialNumbers
                    foreach (var serialNumber in product.serialNumbers)
                    {
                        if (serialNumber.Length == 0)
                        {
                            result.error = String.Format("Serial number has invalid length (gtin:{0}).",
                                product.gtin);

                            return result;
                        }
                    }
                }
            }

            result.omsId = data.omsId;

            // workaround
            // generation of orderId
            result.orderId = Guid.NewGuid().ToString();

            // workaround
            // random generation of expectedCompletionTime
            var rnd = new Random();
            result.expectedCompletionTime = Convert.ToInt16(Math.Round(10000 * rnd.NextDouble()));

            return result;
        }
    }
}
