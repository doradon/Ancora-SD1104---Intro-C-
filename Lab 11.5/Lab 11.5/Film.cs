using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lab_11._5
{
    class Film
    {
        [Key]
        public int film_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string release_year { get; set; }
        [ForeignKey("language_id")]
        public byte language_id { get; set; }
        [ForeignKey("original_language_id")]
        public byte original_language_id { get; set; }
        public byte rental_duration { get; set; }
        public decimal rental_rate { get; set; }
        public Int16 length { get; set; }
        public decimal replacement_cost { get; set; }
        public string rating { get; set; }
        public string special_features { get; set; }
        public DateTime last_update { get; set; }

        public Film (string title, string description, string release_year, 
                     byte rental_duration, decimal rental_rate, Int16 length, 
                     decimal replacement_cost, string rating)
        {
            this.title = title;
            this.description = description;
            this.release_year = release_year;
            this.rental_duration = rental_duration;
            this.rental_rate = rental_rate;
            this.length = length;
            this.replacement_cost = replacement_cost;
            this.rating = rating;

            this.language_id = 1;
            this.original_language_id = 1;
            this.special_features = "Trailers";
            this.last_update = DateTime.Now;
        }
    }
}
