namespace DesignPatterns.FacadeDP.Models
{
    public class Product
    {
        public void GetProductDetails()
        {
            System.Console.WriteLine("Ürün detayları listeleniyor...");
        }
    }
    public class Payment
    {
        public void MakePayment()
        {
            System.Console.WriteLine("Ödeme işlemi başarılı!!!");
        }
    }

    public class Invoice
    {
        public void SendInvoice()
        {
            System.Console.Write("Fatura adresinize başarıyla gönderildi!!");
        }
    }
    public class Order
    {
        public void PlaceOrder()
        {
            System.Console.WriteLine("Sipariş işleminiz başladı!!!");
           
            Product product = new Product();
            product.GetProductDetails();

            Payment payment = new Payment();
            payment.MakePayment();

            Invoice invoice = new Invoice();
            invoice.SendInvoice();

            System.Console.WriteLine("Sipariş işleminiz başarıyla gerçekleştirildi");
        }
    }
}
