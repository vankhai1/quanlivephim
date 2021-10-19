namespace phanmemquanlibanve.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DinhDangPhim")]
    public partial class DinhDangPhim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DinhDangPhim()
        {
            LichChieux = new HashSet<LichChieu>();
        }

        [StringLength(15)]
        public string ID { get; set; }

        [StringLength(5)]
        public string MaPhim { get; set; }

        [StringLength(4)]
        public string IDMH { get; set; }

        public virtual Phim Phim { get; set; }

        public virtual LoaiMH LoaiMH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichChieu> LichChieux { get; set; }
    }
}
