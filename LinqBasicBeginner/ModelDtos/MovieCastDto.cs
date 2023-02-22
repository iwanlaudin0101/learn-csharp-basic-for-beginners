using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqBasicBeginner.ModelDtos
{
    public class MovieCastDto
    {
        public string Title { get; set; } = string.Empty; // Judul film
        public string Director { get; set; } = string.Empty; // Nama sutradara
        public int Budget { get; set; } // Anggaran produksi film
        public int BoxOffice { get; set; } // Pendapatan kotor film
        public int Duration { get; set; } // Durasi film dalam menit
        public string Language { get; set; } = string.Empty; // Bahasa film
        public double Rating { get; set; } // Rating film
        public string ActorName { get; set; } = string.Empty; // Nama aktor/aktris
        public string CharacterName { get; set; } = string.Empty; // Nama karakter yang dimainkan
        public DateTime RelaseDate { get; set; } // Tanggal rilis film
    }
}