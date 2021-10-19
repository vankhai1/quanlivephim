namespace phanmemquanlibanve.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ve")]
    public partial class Ve
    {
        [Key]
        public int MaVe { get; set; }

        [Required]
        [StringLength(5)]
        public string MaLC { get; set; }

        public int LoaiVe { get; set; }

        [Required]
        [StringLength(2)]
        public string GheNgoi { get; set; }

        [StringLength(5)]
        public string MaKM { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }

        public virtual LichChieu LichChieu { get; set; }
    }
}
