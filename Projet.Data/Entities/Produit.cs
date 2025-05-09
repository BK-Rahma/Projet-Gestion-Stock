using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Data.Entities
{
    public class Produit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdID { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProdName { get; set; }

        [Required]
        [ForeignKey("Categorie")]
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Stock { get; set; }

        [MaxLength(255)]
        public string ImagePath { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }

        public DateTime Date { get; set; }
    }
}
