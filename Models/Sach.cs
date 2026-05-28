using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySach.Models
{
    public class Sach
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sách không được để trống")]
        [StringLength(150, ErrorMessage = "Tên sách không được vượt quá 150 ký tự")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tác giả không được để trống")]
        [StringLength(100, ErrorMessage = "Tác giả không được vượt quá 100 ký tự")]
        public string Author { get; set; } = string.Empty;

        [Required(ErrorMessage = "Giá sách không được để trống")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá sách phải lớn hơn 0")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

