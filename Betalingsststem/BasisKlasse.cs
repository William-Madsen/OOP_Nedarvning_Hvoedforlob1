namespace Betalingsststem;

// Basisklasse Payment
public class Payment
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }

    public Payment(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public virtual void ProcessPayment()
    {
        Console.WriteLine("Processing generic payment");
    }
}

// Underklasse CreditCardPayment
public class CreditCardPayment : Payment
{
    public string CardNumber { get; set; }

    public CreditCardPayment(decimal amount, string currency, string cardNumber) 
        : base(amount, currency)
    {
        CardNumber = cardNumber;
    }

    public override void ProcessPayment()
    {
        Console.WriteLine($"Processing credit card payment of {Amount} {Currency} with card number {CardNumber}");
    }
}

// Underklasse PayPalPayment
public class PayPalPayment : Payment
{
    public string Email { get; set; }

    public PayPalPayment(decimal amount, string currency, string email) 
        : base(amount, currency)
    {
        Email = email;
    }

    public override void ProcessPayment()
    {
        Console.WriteLine($"Processing PayPal payment of {Amount} {Currency} for email {Email}");
    }
}
