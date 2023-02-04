using System.ComponentModel.DataAnnotations.Schema;

namespace EFBasics.Entities
{
    [Table("Order Details")]
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
    }
}
