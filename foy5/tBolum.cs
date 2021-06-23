namespace foy5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tBolum")]
    public partial class tBolum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tBolum()
        {
            tOgrenci = new HashSet<tOgrenci>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bolumID { get; set; }

        [StringLength(50)]
        public string bolumAd { get; set; }

        public int? fakulteID { get; set; }

        public virtual tFakulte tFakulte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOgrenci> tOgrenci { get; set; }
    }
}
