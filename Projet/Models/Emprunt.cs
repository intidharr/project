using Microsoft.EntityFrameworkCore;
using Projet.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet.Models
{
    public class Emprunt
    {
        [Key]
        [Column(Order = 0)]
        public int Inscription_Id { get; set; }
        [Key]
        [Column(Order = 1)]
        public int id_book { get; set; }
        public String deadline { get; set; }

    }
}

