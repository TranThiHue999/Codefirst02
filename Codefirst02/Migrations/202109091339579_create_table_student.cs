namespace Codefirst02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        StudentName = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.TBLDeTai",
                c => new
                    {
                        Madt = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Tendt = c.String(maxLength: 30, fixedLength: true, unicode: false),
                        Kinhphi = c.Int(),
                        Noithuctap = c.String(maxLength: 30, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Madt);
            
            CreateTable(
                "dbo.TBLHuongDan",
                c => new
                    {
                        Masv = c.Int(nullable: false),
                        Madt = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        Magv = c.Int(),
                        KetQua = c.Decimal(precision: 5, scale: 2),
                    })
                .PrimaryKey(t => t.Masv)
                .ForeignKey("dbo.TBLDeTai", t => t.Madt)
                .ForeignKey("dbo.TBLGiangVien", t => t.Magv)
                .Index(t => t.Madt)
                .Index(t => t.Magv);
            
            CreateTable(
                "dbo.TBLGiangVien",
                c => new
                    {
                        Magv = c.Int(nullable: false),
                        Hotengv = c.String(maxLength: 30, fixedLength: true, unicode: false),
                        Luong = c.Decimal(precision: 5, scale: 2),
                        Makhoa = c.String(maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Magv)
                .ForeignKey("dbo.TBLKhoa", t => t.Makhoa)
                .Index(t => t.Makhoa);
            
            CreateTable(
                "dbo.TBLKhoa",
                c => new
                    {
                        Makhoa = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        Tenkhoa = c.String(maxLength: 30, fixedLength: true, unicode: false),
                        Dienthoai = c.String(maxLength: 10, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Makhoa);
            
            CreateTable(
                "dbo.TBLSinhVien",
                c => new
                    {
                        Masv = c.Int(nullable: false),
                        Hotensv = c.String(maxLength: 40, fixedLength: true, unicode: false),
                        Makhoa = c.String(maxLength: 10, fixedLength: true, unicode: false),
                        Namsinh = c.Int(),
                        Quequan = c.String(maxLength: 30, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Masv)
                .ForeignKey("dbo.TBLKhoa", t => t.Makhoa)
                .Index(t => t.Makhoa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBLSinhVien", "Makhoa", "dbo.TBLKhoa");
            DropForeignKey("dbo.TBLGiangVien", "Makhoa", "dbo.TBLKhoa");
            DropForeignKey("dbo.TBLHuongDan", "Magv", "dbo.TBLGiangVien");
            DropForeignKey("dbo.TBLHuongDan", "Madt", "dbo.TBLDeTai");
            DropIndex("dbo.TBLSinhVien", new[] { "Makhoa" });
            DropIndex("dbo.TBLGiangVien", new[] { "Makhoa" });
            DropIndex("dbo.TBLHuongDan", new[] { "Magv" });
            DropIndex("dbo.TBLHuongDan", new[] { "Madt" });
            DropTable("dbo.TBLSinhVien");
            DropTable("dbo.TBLKhoa");
            DropTable("dbo.TBLGiangVien");
            DropTable("dbo.TBLHuongDan");
            DropTable("dbo.TBLDeTai");
            DropTable("dbo.Students");
        }
    }
}
