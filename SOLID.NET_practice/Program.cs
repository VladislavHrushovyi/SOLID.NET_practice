//SINGLE RESPONSIBILITY

using SOLID.NET_practice.S;

var amountItemsInvoice = 200;
var dateInvoice = DateTime.Now;
var senders = new List<ISenderMessage>()
{
    new EmailMessage(){EmailFrom = "ddddd1@gmail.com", EmailTo = "ddddd2@gmail.com", EmailSubject = "INVOICE"},
    new MessengerMessage(){SenderName = "TEST1", ReceiverName = "TEST2"}
};
var invoice = new Invoice(senders)
{
    AmountItems = amountItemsInvoice,
    InvoiceDate = dateInvoice
};

invoice.Add();
invoice.Delete();