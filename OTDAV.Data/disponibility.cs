namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.disponibility")]
    public partial class disponibility
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string etat { get; set; }

        public int heure { get; set; }

        public int id_user { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        public int? user_id { get; set; }
    }
}
