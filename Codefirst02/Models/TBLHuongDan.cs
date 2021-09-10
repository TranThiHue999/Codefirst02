namespace Codefirst02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLHuongDan")]
    public partial class TBLHuongDan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Masv { get; set; }

        [StringLength(10)]
        public string Madt { get; set; }

        public int? Magv { get; set; }

        public decimal? KetQua { get; set; }

        public virtual TBLDeTai TBLDeTai { get; set; }

        public virtual TBLGiangVien TBLGiangVien { get; set; }
    }
}
