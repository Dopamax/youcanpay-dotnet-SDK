using System.Text.Json.Nodes;
using TestYoucanPayDotNet.Models;


namespace TestYoucanPayDotNet.Mappers.Payement
{
    internal class PayementMapper
    {
        public static JsonObject payementModelToJsonObject(PayementModel payementModel)
        {
            return new JsonObject
            {
                ["pub_key"] = $"{payementModel.pub_key}",
                ["token_id"] = $"{payementModel.token}",
                ["expire_date"] = $"{payementModel.youcanPayCardInformation.expireDateMonth + '/' + payementModel.youcanPayCardInformation.expireDateYear}",
                ["credit_card"] = $"{payementModel.youcanPayCardInformation.cardNumber}",
                ["cvv"] = $"{payementModel.youcanPayCardInformation.cvv}",
                ["card_holder_name"] = $"{payementModel.youcanPayCardInformation.cardHolderName}"
            };
        }
    }
}
