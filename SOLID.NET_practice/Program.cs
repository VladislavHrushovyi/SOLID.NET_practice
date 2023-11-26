//SINGLE RESPONSIBILITY
// using SOLID.NET_practice.S;
//
// var amountItemsInvoice = 200;
// var dateInvoice = DateTime.Now;
// var senders = new List<ISenderMessage>()
// {
//     new EmailMessage(){EmailFrom = "ddddd1@gmail.com", EmailTo = "ddddd2@gmail.com", EmailSubject = "INVOICE"},
//     new MessengerMessage(){SenderName = "TEST1", ReceiverName = "TEST2"}
// };
// var invoice = new Invoice(senders)
// {
//     AmountItems = amountItemsInvoice,
//     InvoiceDate = dateInvoice
// };
//
// invoice.Add();
// invoice.Delete();

using SOLID.NET_practice.O;

var price1 = 1000d;
List<IDiscountStrategy> discountStrategies1 = new List<IDiscountStrategy>()
{
    new SimpleDiscount(),
    new BlackFridayDiscount()
};

var discountCalculator1 = new DiscountCalculator(discountStrategies1);
var resultDiscount1 = discountCalculator1.CalculateDiscount(price1);
Console.WriteLine(resultDiscount1);

var price2 = 2000d;
List<IDiscountStrategy> discountStrategies2 = new List<IDiscountStrategy>()
{
    new SimpleDiscount(),
};

var discountCalculator2 = new DiscountCalculator(discountStrategies2);
var resultDiscount2 = discountCalculator2.CalculateDiscount(price2);
Console.WriteLine(resultDiscount2);