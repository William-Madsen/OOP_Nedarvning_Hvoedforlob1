using System;

namespace Betalingsststem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Betalingssystem");

            // Opret de forskellige betalingstyper
            Payment genericPayment = new Payment(100.00m, "DKK");
            CreditCardPayment creditCard = new CreditCardPayment(250.50m, "DKK", "1234-5678-9012-3456");
            PayPalPayment paypal = new PayPalPayment(175.25m, "EUR", "bruger@example.com");

            // Test alle betalingstyper
            Console.WriteLine("\n1. Generic payment:");
            genericPayment.ProcessPayment();

            Console.WriteLine("\n2. Credit card payment:");
            creditCard.ProcessPayment();

            Console.WriteLine("\n3. PayPal payment:");
            paypal.ProcessPayment();
            
            // Polymorfisme - brug array af basisklassen Payment
            Console.WriteLine("\n4. Polymorfisme test:");
            Payment[] payments = { genericPayment, creditCard, paypal };
            
            foreach (Payment payment in payments)
            {
                payment.ProcessPayment();
                Console.WriteLine($"   Beløb: {payment.Amount} {payment.Currency}");
                Console.WriteLine();
            }
        }
    }
}
