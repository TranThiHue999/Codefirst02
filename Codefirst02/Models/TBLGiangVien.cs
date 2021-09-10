namespace Codefirst02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLGiangVien")]
    public partial class TBLGiangVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLGiangVien()
        {
            TBLHuongDans = new HashSet<TBLHuongDan>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Magv { get; set; }

        [StringLength(30)]
        public string Hotengv { get; set; }

        public decimal? Luong { get; set; }

        [StringLength(10)]
        public string Makhoa { get; set; }

        public virtual TBLKhoa TBLKhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLHuongDan> TBLHuongDans { get; set; }
    }
}
