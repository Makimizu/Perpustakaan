using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Perpustakaan.Models
{
    [Table("Pinjam")]
    public class Pinjam
    {
        [Key]
        public int NoPinjam { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Tanggal { get; set; }
        public string Penyewa { get; set; }
        public string JenisBuku { get; set; }
        public int LamaPinjam { get; set; }
        public DateTime TanggalKembali { get; set; }
        public string Status { get; set; }
    }
}
