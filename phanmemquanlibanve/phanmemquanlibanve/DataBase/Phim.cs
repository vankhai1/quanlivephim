namespace phanmemquanlibanve.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phim")]
    public partial class Phim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phim()
        {
            DinhDangPhims = new HashSet<DinhDangPhim>();
            LichChieux = new HashSet<LichChieu>();
        }

        [Key]
        [StringLength(5)]
        public string MaPhim { get; set; }

        [Required]
        [StringLength(10)]
        public string MaTL { get; set; }

        [StringLength(50)]
        public string TenPhim { get; set; }

        [StringLength(30)]
        public string DaoDien { get; set; }

        public DateTime NgaySX { get; set; }

        public double ThoiLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKhoiChieu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        [StringLength(200)]
        public string NoiDung { get; set; }

        [Column(TypeName = "image")]
        public byte[] Anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DinhDangPhim> DinhDangPhims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichChieu> LichChieux { get; set; }

        public virtual TheLoai TheLoai { get; set; }
    }
}
