namespace RestaurantReviews.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Restaurant
    {
        public Restaurant()
        {
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(250)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        public int? RestaurantType { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual RestaurantType RestaurantType1 { get; set; }
    }
}
