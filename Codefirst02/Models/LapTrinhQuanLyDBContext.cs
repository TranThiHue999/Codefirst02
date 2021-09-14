using Codefirst02.Controllers;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Codefirst02.Models
{
    public partial class LapTrinhQuanLyDBContext : DbContext
    {
        public LapTrinhQuanLyDBContext()

            : base("name=LapTrinhQuanLyDBContext")
        {
        }


        public virtual DbSet<TBLDeTai> TBLDeTais { get; set; }
        public virtual DbSet<TBLGiangVien> TBLGiangViens { get; set; }
        public virtual DbSet<TBLHuongDan> TBLHuongDans { get; set; }
        public virtual DbSet<TBLKhoa> TBLKhoas { get; set; }
        public virtual DbSet<TBLSinhVien> TBLSinhViens { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
  
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBLDeTai>()
                .Property(e => e.Madt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLDeTai>()
                .Property(e => e.Tendt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLDeTai>()
                .Property(e => e.Noithuctap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLGiangVien>()
                .Property(e => e.Hotengv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLGiangVien>()
                .Property(e => e.Luong)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TBLGiangVien>()
                .Property(e => e.Makhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLHuongDan>()
                .Property(e => e.Madt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLHuongDan>()
                .Property(e => e.KetQua)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TBLKhoa>()
                .Property(e => e.Makhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLKhoa>()
                .Property(e => e.Tenkhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLKhoa>()
                .Property(e => e.Dienthoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLSinhVien>()
                .Property(e => e.Hotensv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLSinhVien>()
                .Property(e => e.Makhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TBLSinhVien>()
                .Property(e => e.Quequan)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
