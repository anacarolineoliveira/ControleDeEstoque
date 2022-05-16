using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeEstoque.Models
{   
    [Table("Tbl_Estoque")]
    public class Alimentos
    {
        [Column("Id"), HiddenInput]
        public int AlimentosId { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [Column("Dt_Validade"), Required, Display(Name = "Data de validade"), DataType(DataType.Date)]
        public DateTime Validade { get; set; }

        [Required]
        public Categoria Categoria { get; set; }
        public float Valor { get; set; }
        public bool Promotor { get; set; }

    }
}
