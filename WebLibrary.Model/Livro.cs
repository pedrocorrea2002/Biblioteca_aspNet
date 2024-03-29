﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebLibrary.Model
{
    public partial class Livro
    {
        public Livro()
        {
            LivroClienteEmprestimo = new HashSet<LivroClienteEmprestimo>();
        }

        [Key]
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Required]
        [Column("nome")]
        [StringLength(50)]
        [Unicode(false)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Required]
        [Column("autor")]
        [StringLength(100)]
        [Unicode(false)]
        [Display(Name = "Autor(a)")]
        public string Autor { get; set; }
        [Required]
        [Column("editora")]
        [StringLength(50)]
        [Unicode(false)]
        [Display(Name = "Editor(a)")]
        public string Editora { get; set; }
        public bool Emprestado { get; set; }

        [InverseProperty("IdLivroNavigation")]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
    }
}