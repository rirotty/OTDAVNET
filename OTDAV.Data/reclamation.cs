namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.reclamation")]
    public partial class reclamation
    {
        public int id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? type { get; set; }
    }
}
