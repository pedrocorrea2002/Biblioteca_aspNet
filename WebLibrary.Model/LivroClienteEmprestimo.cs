﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebLibrary.Model
{
    [Table("Livro_Cliente_Emprestimo")]
    public partial class LivroClienteEmprestimo
    {
        [Key]
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Column("idLivro")]
        [Display(Name = "Livro")]
        public int IdLivro { get; set; }
        [Column("idCliente")]
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }
        [Column("dataEmprestimo", TypeName = "datetime")]

        [Display(Name = "Data de empréstimo")]
        public DateTime DataEmprestimo { get; set; }
        [Column("dataDevolucao", TypeName = "datetime")]
        [Display(Name = "Data de devolução")]
        public DateTime? DataDevolucao { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("LivroClienteEmprestimo")]
        public virtual Cliente IdClienteNavigation { get; set; }
        [ForeignKey("IdLivro")]
        [InverseProperty("LivroClienteEmprestimo")]
        public virtual Livro IdLivroNavigation { get; set; }
    }
}