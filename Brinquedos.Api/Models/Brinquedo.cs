using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brinquedos.Api.Models
{
    [Table("TDS_TB_Brinquedos")]
    public class Brinquedo
    {
        [Key]
        public int Id_brinquedo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome_brinquedo { get; set; } = string.Empty;

        [Required]
        public string Tipo_brinquedo { get; set; } = string.Empty;

        [Required]
        public string Classificacao { get; set; } = string.Empty;

        [Required]
        public string Tamanho { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
    }
}