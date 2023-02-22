using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqBasicBeginner.Models
{
    public class Movie
    {
        public int Id { get; set; } // Primary key
        public string Title { get; set; } = string.Empty; // Judul film
        public DateTime RelaseDate { get; set; } // Tanggal rilis film
        public string Director { get; set; } = string.Empty; // Nama sutradara
        public int Budget { get; set; } // Anggaran produksi film
        public int BoxOffice { get; set; } // Pendapatan kotor film
        public int Duration { get; set; } // Durasi film dalam menit
        public string Language { get; set; } = string.Empty; // Bahasa film
        public double Rating { get; set; } // Rating film
        public DateTime CreatedAt { get; set; } // Waktu pembuatan data
        public DateTime UpdatedAt { get; set; } // Waktu pembaruan data
    }
}