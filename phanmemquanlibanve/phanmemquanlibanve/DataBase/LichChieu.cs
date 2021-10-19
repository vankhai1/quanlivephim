namespace phanmemquanlibanve.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichChieu")]
    public partial class LichChieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LichChieu()
        {
            Ves = new HashSet<Ve>();
        }

        [Key]
        [StringLength(5)]
        public string MaLC { get; set; }

        public DateTime NgayChieu { get; set; }

        public TimeSpan GioChieu { get; set; }

        [Required]
        [StringLength(5)]
        public string MaPhong { get; set; }

        [StringLength(5)]
        public string MaPhim { get; set; }

        [StringLength(15)]
        public string ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaVe { get; set; }

        public virtual DinhDangPhim DinhDangPhim { get; set; }

        public virtual Phim Phim { get; set; }

        public virtual PhongChieu PhongChieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
