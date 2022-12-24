# youcan-payment-dotnet-sdk

YouCan Pay SDK for dotnet version 6.

## Installation

Add the project as references into your project (soon available on Nuget)

## Usage

```csharp
// import youcan SDK

using YoucanPay.Models;
using YoucanPay.Services;
using YoucanPay.YoucanPayConfig;

//for sandbox mode

//1) Give values to the keys

Keys.PRIVATE_KEY_SANDBOX_MODE = "pri_sandbox_xxxxxxxxxxxxxxx";

Keys.PUBLIC_KEY_SANDBOX_MODE = "pub_sandbox_xxxxxxxxxxxxxxxx";

//2) instanciate the service

YoucanPayApiService service = new YoucanPayApiService();

//3) Tokenize

var task = Task.Run(() => service.Tokenization("236", "600", "USD", true));
var token = await task;

//4) Pay

YoucanPayCardInformation cardInformation = new YoucanPayCardInformation("John Doe", "4242424242424242","10", "24", "112");

var taskPay = Task.Run(() => service.pay(cardInformation,token,true));


//for normal use

//1) Give values to the keys

Keys.PRIVATE_KEY = "pri_xxxxxxxxxxxxxx";

Keys.PUBLIC_KEY = "pub_xxxxxxxxxxxxxxx";

//2) instanciate the service

YoucanPayApiService service = new YoucanPayApiService();

//3) Tokenize

var task = Task.Run(() => service.Tokenization("236", "600", "USD", false));
var token = await task;

//4) Pay

YoucanPayCardInformation cardInformation = new YoucanPayCardInformation("John Doe", "4242424242424242","10", "24", "112");

var taskPay = Task.Run(() => service.pay(cardInformation,token,false));

//See the if is success
Console.WriteLine(await taskPay);

```

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)
