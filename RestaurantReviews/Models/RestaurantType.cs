namespace RestaurantReviews.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RestaurantType")]
    public partial class RestaurantType
    {
        public RestaurantType()
        {
            Restaurants = new HashSet<Restaurant>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
