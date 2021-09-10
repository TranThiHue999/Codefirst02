namespace Codefirst02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLKhoa")]
    public partial class TBLKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKhoa()
        {
            TBLGiangViens = new HashSet<TBLGiangVien>();
            TBLSinhViens = new HashSet<TBLSinhVien>();
        }

        [Key]
        [StringLength(10)]
        public string Makhoa { get; set; }

        [StringLength(30)]
        public string Tenkhoa { get; set; }

        [StringLength(10)]
        public string Dienthoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLGiangVien> TBLGiangViens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSinhVien> TBLSinhViens { get; set; }
    }
}
