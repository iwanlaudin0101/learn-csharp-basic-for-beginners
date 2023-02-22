using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqBasicBeginner.Models
{
    public class Casts
    {
        public int Id { get; set; } // Primary key
        public int MovieId { get; set; } // Foreign key dari tabel Movies
        public string ActorName { get; set; } = string.Empty; // Nama aktor/aktris
        public string CharacterName { get; set; } = string.Empty; // Nama karakter yang dimainkan
        public DateTime CreatedAt { get; set; } // Waktu pembuatan data
        public DateTime UpdatedAt { get; set; } // Waktu pembaruan data
    }
}