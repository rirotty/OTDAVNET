namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.file")]
    public partial class file
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? declaration_id { get; set; }

        public int? membership_id { get; set; }
    }
}
