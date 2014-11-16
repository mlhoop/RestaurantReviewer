namespace RestaurantReviews.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestaurantReviewsDB : DbContext
    {
        public RestaurantReviewsDB()
            : base("name=RestaurantReviewsDB")
        {
        }

        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<RestaurantType> RestaurantTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Ratings)
                .WithRequired(e => e.Restaurant1)
                .HasForeignKey(e => e.Restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RestaurantType>()
                .HasMany(e => e.Restaurants)
                .WithOptional(e => e.RestaurantType1)
                .HasForeignKey(e => e.RestaurantType);
        }
    }
}
