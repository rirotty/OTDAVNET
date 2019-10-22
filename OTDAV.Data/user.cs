namespace OTDAV.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("otdav.user")]
    public partial class user
    {
        public int id { get; set; }

        [StringLength(255)]
        public string adress { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthDate { get; set; }

        public int? cin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? cinDate { get; set; }

        public int? civilSituation { get; set; }

        public int? fax { get; set; }

        public DateTime? inscriptionDate { get; set; }

        [Column(TypeName = "bit")]
        public bool isEnabled { get; set; }

        [StringLength(255)]
        public string lastName { get; set; }

        [StringLength(255)]
        public string mail { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? nbrChildren { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        public int? phone { get; set; }

        public int? postCode { get; set; }

        public int? rib { get; set; }

        public int? role { get; set; }

        [StringLength(255)]
        public string stageName { get; set; }

        [StringLength(255)]
        public string username { get; set; }
    }
}
