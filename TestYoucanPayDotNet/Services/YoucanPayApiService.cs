using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using YoucanPay.YoucanPayConfig;
using System.Text.Json;
using YoucanPay.Models;
using System.Text.Json.Nodes;
using YoucanPay.Mappers.Tokenize;
using TestYoucanPayDotNet.Models.Response;
using TestYoucanPayDotNet.Models;
using TestYoucanPayDotNet.Mappers.Payement;

namespace YoucanPay.Services
{
    internal class YoucanPayApiService
    {
        public async Task<string> Tokenization(String order_id, String amount, String currency, Boolean sandboxMode)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");

            TokenizeModel tokenizeModel = null;

            String url = null;

            if (sandboxMode == false)
            {
                tokenizeModel = new TokenizeModel(amount, currency, order_id, Keys.PRIVATE_KEY);

                url = YCPayConfig.API_URL + "api/tokenize";
            }
            else
            {
                tokenizeModel = new TokenizeModel(amount, currency, order_id, Keys.PRIVATE_KEY_SANDBOX_MODE);

                url = YCPayConfig.API_URL_SANDBOX + "api/tokenize";
            }

            var tokenizeModelJson = JsonSerializer.Serialize(TokenizeMapper.tokenizeModelToJsonObject(tokenizeModel));

            var content = new StringContent(tokenizeModelJson, Encoding.UTF8, "application/json");
            
            var response = await client.PostAsync(url, content);

            var responseContent =  response.Content.ReadAsStringAsync().Result;
            
            TokenizationResponse data = JsonSerializer.Deserialize<TokenizationResponse>(responseContent)!;
            
            Console.WriteLine(data.token.id);

            return data.token.id;
        }

        public async Task<Boolean> pay(YoucanPayCardInformation cardInformation, String token, Boolean sandboxMode)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");

            PayementModel payementModel = null;

            String url = null;

            if (sandboxMode == false)
            {
                payementModel =  new PayementModel(cardInformation, token, Keys.PUBLIC_KEY);

                url = YCPayConfig.API_URL + "api/pay";
            }
            else
            {
                payementModel = new PayementModel(cardInformation, token, Keys.PUBLIC_KEY_SANDBOX_MODE);

                url = YCPayConfig.API_URL_SANDBOX + "api/pay";
            }

            var payementModelJson = JsonSerializer.Serialize(PayementMapper.payementModelToJsonObject(payementModel));

            var content = new StringContent(payementModelJson, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            var responseContent = response.Content.ReadAsStringAsync().Result;

            PayementResponse data = JsonSerializer.Deserialize<PayementResponse>(responseContent)!;

            return data.success;
        }
    }
}
