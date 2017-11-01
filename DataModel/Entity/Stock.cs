namespace DataModel.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock")]
    public partial class Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public int? Quantity { get; set; }

        public bool? IsPromotion { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPricePromotion { get; set; }

        public int? PercentPromotion { get; set; }

        public bool? IsSale { get; set; }

        public DateTime? StartSale { get; set; }

        public DateTime? EndSale { get; set; }

        public bool? IsHot { get; set; }

        public bool? IsNew { get; set; }

        public bool? IsVisible { get; set; }

        public DateTime? DateAdd { get; set; }

        public DateTime? DateUpdate { get; set; }
        public string UpdateBy { get; set; }

        public virtual Product Product { get; set; }
    }
}
