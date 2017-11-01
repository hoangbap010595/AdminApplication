namespace DataModel.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [StringLength(128)]
        public string ProductName { get; set; }

        [StringLength(64)]
        public string Model { get; set; }

        [StringLength(16)]
        public string Size { get; set; }

        [StringLength(64)]
        public string Color { get; set; }

        [StringLength(16)]
        public string Gender { get; set; }

        [StringLength(32)]
        public string QtyPerUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        public short? UnitInStock { get; set; }

        public short? UnitOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool? Discontinued { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        [Column(TypeName = "ntext")]
        public string ProductImage { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual Stock Stock { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
