namespace phanmemquanlibanve.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongChieu")]
    public partial class PhongChieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongChieu()
        {
            LichChieux = new HashSet<LichChieu>();
        }

        [Key]
        [StringLength(5)]
        public string MaPhong { get; set; }

        [Required]
        [StringLength(6)]
        public string TenPhong { get; set; }

        public int SoGhe { get; set; }

        public double DienTich { get; set; }

        public int TinhTrang { get; set; }

        [Required]
        [StringLength(4)]
        public string IDMH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichChieu> LichChieux { get; set; }

        public virtual LoaiMH LoaiMH { get; set; }
    }
}
