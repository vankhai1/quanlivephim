using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace phanmemquanlibanve.DataBase
{
    public partial class QLRP : DbContext
    {
        public QLRP()
            : base("name=QLRP")
        {
        }

        public virtual DbSet<DinhDangPhim> DinhDangPhims { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LichChieu> LichChieux { get; set; }
        public virtual DbSet<LoaiMH> LoaiMHs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<PhongChieu> PhongChieux { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DinhDangPhim>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<DinhDangPhim>()
                .Property(e => e.MaPhim)
                .IsUnicode(false);

            modelBuilder.Entity<DinhDangPhim>()
                .Property(e => e.IDMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.MaKM)
                .IsUnicode(false);

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.MaThe)
                .IsUnicode(false);

            modelBuilder.Entity<LichChieu>()
                .Property(e => e.MaLC)
                .IsUnicode(false);

            modelBuilder.Entity<LichChieu>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<LichChieu>()
                .Property(e => e.MaPhim)
                .IsUnicode(false);

            modelBuilder.Entity<LichChieu>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<LichChieu>()
                .Property(e => e.GiaVe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LichChieu>()
                .HasMany(e => e.Ves)
                .WithRequired(e => e.LichChieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiMH>()
                .Property(e => e.IDMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiMH>()
                .Property(e => e.TenMH)
                .IsFixedLength();

            modelBuilder.Entity<LoaiMH>()
                .HasMany(e => e.PhongChieux)
                .WithRequired(e => e.LoaiMH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNv)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TaiKhoans)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phim>()
                .Property(e => e.MaPhim)
                .IsUnicode(false);

            modelBuilder.Entity<Phim>()
                .Property(e => e.MaTL)
                .IsUnicode(false);

            modelBuilder.Entity<PhongChieu>()
                .Property(e => e.MaPhong)
                .IsUnicode(false);

            modelBuilder.Entity<PhongChieu>()
                .Property(e => e.TenPhong)
                .IsFixedLength();

            modelBuilder.Entity<PhongChieu>()
                .Property(e => e.IDMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhongChieu>()
                .HasMany(e => e.LichChieux)
                .WithRequired(e => e.PhongChieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.MaThe)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.MaTL)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .HasMany(e => e.Phims)
                .WithRequired(e => e.TheLoai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaLC)
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.GheNgoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaKM)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaNv)
                .IsUnicode(false);
        }
    }
}
