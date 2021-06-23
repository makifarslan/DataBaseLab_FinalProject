namespace foy5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tOgrenciDers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int odID { get; set; }

        public int? ogrenciID { get; set; }

        public int? dersID { get; set; }

        [StringLength(50)]
        public string yil { get; set; }

        [StringLength(50)]
        public string yariyil { get; set; }

        public int? vize { get; set; }

        public int? final { get; set; }

        public virtual tDers tDers { get; set; }

        public virtual tOgrenci tOgrenci { get; set; }
    }
}
