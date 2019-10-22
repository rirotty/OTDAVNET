namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.artwork")]
    public partial class artwork
    {
        public int id { get; set; }

        [StringLength(255)]
        public string author { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "bit")]
        public bool isActive { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? declaration_id { get; set; }

        public int? subCategory_id { get; set; }

        public int? user_id { get; set; }
    }
}
