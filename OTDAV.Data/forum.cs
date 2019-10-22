namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.forum")]
    public partial class forum
    {
        public int id { get; set; }

        [StringLength(255)]
        public string commentaire { get; set; }

        public DateTime? date { get; set; }

        public int? user_id { get; set; }
    }
}
