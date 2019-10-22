namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.category")]
    public partial class category
    {
        public int id { get; set; }

        [StringLength(255)]
        public string CategoryName { get; set; }

        [StringLength(255)]
        public string icon { get; set; }

        [Column(TypeName = "bit")]
        public bool isActif { get; set; }

        public int point { get; set; }
    }
}
