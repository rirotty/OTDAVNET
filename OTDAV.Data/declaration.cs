namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.declaration")]
    public partial class declaration
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? declarationDate { get; set; }

        public int? user_id { get; set; }
    }
}
