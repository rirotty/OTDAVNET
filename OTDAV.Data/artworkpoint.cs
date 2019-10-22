namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.artworkpoint")]
    public partial class artworkpoint
    {
        public int id { get; set; }

        public double? points { get; set; }

        public int? artwork_id { get; set; }

        public int? programme_id { get; set; }
    }
}
