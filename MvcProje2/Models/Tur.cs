using System.ComponentModel.DataAnnotations;

namespace MvcProje2.Models
{
    public class Tur
    {
        [Key]// primary key olarak ayarlandı
        public int Id { get; set; }
        [Required]// boş geçilmemez ibaresi
        public String Ad { get; set; }
    }
}
