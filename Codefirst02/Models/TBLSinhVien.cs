namespace Codefirst02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLSinhVien")]
    public partial class TBLSinhVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Masv { get; set; }

        [StringLength(40)]
        public string Hotensv { get; set; }

        [StringLength(10)]
        public string Makhoa { get; set; }

        public int? Namsinh { get; set; }

        [StringLength(30)]
        public string Quequan { get; set; }

        public virtual TBLKhoa TBLKhoa { get; set; }
    }
}
