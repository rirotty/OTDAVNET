namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.meeting")]
    public partial class meeting
    {
        public int id { get; set; }

        public int confirmed { get; set; }

        public DateTime? date { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public int enabled { get; set; }

        public int heure { get; set; }

        public int idDispo { get; set; }

        public int id_user { get; set; }

        public int isNotCanceled { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        public int scanned { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        public int? user_id { get; set; }
    }
}
