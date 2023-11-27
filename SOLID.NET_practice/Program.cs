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


// OCP PRINCEPLE
// using SOLID.NET_practice.O;
//
// var price1 = 1000d;
// List<IDiscountStrategy> discountStrategies1 = new List<IDiscountStrategy>()
// {
//     new SimpleDiscount(),
//     new BlackFridayDiscount()
// };
//
// var discountCalculator1 = new DiscountCalculator(discountStrategies1);
// var resultDiscount1 = discountCalculator1.CalculateDiscount(price1);
// Console.WriteLine(resultDiscount1);
//
// var price2 = 2000d;
// List<IDiscountStrategy> discountStrategies2 = new List<IDiscountStrategy>()
// {
//     new SimpleDiscount(),
// };
//
// var discountCalculator2 = new DiscountCalculator(discountStrategies2);
// var resultDiscount2 = discountCalculator2.CalculateDiscount(price2);
// Console.WriteLine(resultDiscount2);

using SOLID.NET_practice.LSP;

BaseBankAccount savingsAccount = new SavingsAccount("CA236722", 1000m, 0.03m);
BaseBankAccount currentAccount = new CurrentAccount("JP335675", 1500m, 500m);

Console.WriteLine("Before transaction:");
Console.WriteLine(savingsAccount);
Console.WriteLine(currentAccount);

savingsAccount.Withdraw(2000m);
currentAccount.Withdraw(3000m);

Console.WriteLine("After transaction:");
Console.WriteLine(savingsAccount);
Console.WriteLine(currentAccount);