using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Review
    {
        public int RestaurantId { get; set; }
        public int ReviewId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}