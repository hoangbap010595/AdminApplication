namespace DataModel.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }

        public int? CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Frieght { get; set; }

        [StringLength(64)]
        public string ShipName { get; set; }

        [StringLength(16)]
        public string ShipPhone { get; set; }

        [StringLength(64)]
        public string ShipAddress { get; set; }

        [StringLength(32)]
        public string ShipCity { get; set; }

        [StringLength(32)]
        public string ShipRegion { get; set; }

        [StringLength(32)]
        public string ShipPostalCode { get; set; }

        [StringLength(32)]
        public string ShipCountry { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
