namespace RestaurantReviews.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rating
    {
        public int Id { get; set; }

        public int Restaurant { get; set; }

        [Column("Rating")]
        [Display(Name = "Ratings are 1 to 5")]
        [Range(1, 5)]
        [Required]
        public byte Rating1 { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Comment { get; set; }

        public virtual Restaurant Restaurant1 { get; set; }
    }
}
