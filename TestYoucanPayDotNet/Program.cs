using YoucanPay.Models;
using YoucanPay.Services;
using YoucanPay.YoucanPayConfig;

Keys.PRIVATE_KEY_SANDBOX_MODE = "pri_sandbox_xxxxxxxxxxxxxxx";

Keys.PUBLIC_KEY_SANDBOX_MODE = "pub_sandbox_xxxxxxxxxxxxxxxx";

YoucanPayApiService service = new YoucanPayApiService();

var task = Task.Run(() => service.Tokenization("236", "600", "USD", true));
var token = await task;

Console.WriteLine(token);

YoucanPayCardInformation cardInformation = new YoucanPayCardInformation("John Doe", "4242424242424242","10", "24", "112");

var taskPay = Task.Run(() => service.pay(cardInformation,token,true));

Console.WriteLine(await taskPay);