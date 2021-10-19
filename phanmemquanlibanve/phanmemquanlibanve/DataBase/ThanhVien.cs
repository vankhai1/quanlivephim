namespace phanmemquanlibanve.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhVien()
        {
            KhuyenMais = new HashSet<KhuyenMai>();
        }

        [Key]
        [StringLength(10)]
        public string MaThe { get; set; }

        [Required]
        [StringLength(35)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(13)]
        public string SDT { get; set; }

        public DateTime? NgayLap { get; set; }

        public DateTime? NgayHH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhuyenMai> KhuyenMais { get; set; }
    }
}
