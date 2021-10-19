namespace phanmemquanlibanve.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        [Key]
        [StringLength(5)]
        public string MaNv { get; set; }

        [Required]
        [StringLength(35)]
        public string TenNv { get; set; }

        [Required]
        [StringLength(12)]
        public string CMND { get; set; }

        public DateTime NgaySinh { get; set; }

        [StringLength(35)]
        public string Diachi { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(10)]
        public string ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
