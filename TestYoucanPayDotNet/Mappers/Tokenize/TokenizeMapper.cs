using System.Text.Json.Nodes;
using YoucanPay.Models;


namespace YoucanPay.Mappers.Tokenize
{
    internal class TokenizeMapper
    {
        public static JsonObject tokenizeModelToJsonObject(TokenizeModel tokenizeModel)
        {
            return new JsonObject
            {
                ["amount"] = $"{tokenizeModel.amount}",
                ["currency"] = $"{tokenizeModel.currency}",
                ["pri_key"] = $"{tokenizeModel.pri_key}",
                ["order_id"] = $"{tokenizeModel.order_id}",
                ["metadata[cart.id]"] = "uuid",
                ["metadata[type]"] = "checkout"
            };
        }
    }
}
