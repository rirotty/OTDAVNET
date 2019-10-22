namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.membership")]
    public partial class membership
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expirationDate { get; set; }

        [StringLength(255)]
        public string rejectedFor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? startDate { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        public int? subCategory_id { get; set; }

        public int? user_id { get; set; }
    }
}
