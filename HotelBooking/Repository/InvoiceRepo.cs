using HotelBooking.Models;

namespace HotelBooking.Repository
{
    public class InvoiceRepo
    {
        private HOTELBOOKINGEntities _dbConnection;

        public InvoiceRepo()
        {
            _dbConnection = new HOTELBOOKINGEntities();
        }

        public Invoice GetInvoice(int invoiceID)
        {
            return _dbConnection.Invoices.Find(invoiceID);
        }

        public int InsertInvoice(Invoice invoice)
        {
            _dbConnection.Invoices.Add(invoice);
            _dbConnection.SaveChanges();

            return invoice.InvoiceID;
        }

        public int UpdateInvoice(Invoice invoice)
        {
            var originalInvoice = GetInvoice(invoice.InvoiceID);

            _dbConnection.Entry(originalInvoice).CurrentValues.SetValues(invoice);
            return _dbConnection.SaveChanges();
        }

        public int DeleteInvoice(int invoiceID)
        {
            _dbConnection.Invoices.Remove(GetInvoice(invoiceID));
            return _dbConnection.SaveChanges();
        }
    }
}
