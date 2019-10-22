namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.programme")]
    public partial class programme
    {
        public int id { get; set; }

        [Column(TypeName = "bit")]
        public bool cheked { get; set; }

        public DateTime? date { get; set; }

        public float montant { get; set; }

        [Column(TypeName = "bit")]
        public bool validate { get; set; }

        public int? user_id { get; set; }
    }
}
