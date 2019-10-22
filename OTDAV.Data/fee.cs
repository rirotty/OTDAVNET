namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.fee")]
    public partial class fee
    {
        public int id { get; set; }

        public double? Amount { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public DateTime? year { get; set; }
    }
}
