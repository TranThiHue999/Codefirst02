namespace Codefirst02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLDeTai")]
    public partial class TBLDeTai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLDeTai()
        {
            TBLHuongDans = new HashSet<TBLHuongDan>();
        }

        [Key]
        [StringLength(10)]
        public string Madt { get; set; }

        [StringLength(30)]
        public string Tendt { get; set; }

        public int? Kinhphi { get; set; }

        [StringLength(30)]
        public string Noithuctap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLHuongDan> TBLHuongDans { get; set; }
    }
}
