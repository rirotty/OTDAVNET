namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.subcategory")]
    public partial class subcategory
    {
        public int id { get; set; }

        [Column(TypeName = "bit")]
        public bool isActif { get; set; }

        public int point { get; set; }

        [StringLength(255)]
        public string subcategoryName { get; set; }

        public int? category_id { get; set; }
    }
}
