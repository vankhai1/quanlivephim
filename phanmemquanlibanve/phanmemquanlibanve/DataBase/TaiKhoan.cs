namespace phanmemquanlibanve.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(13)]
        public string MatKhau { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoaiTK { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string MaNv { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
