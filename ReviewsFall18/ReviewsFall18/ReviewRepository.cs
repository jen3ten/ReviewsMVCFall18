using ReviewsFall18.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsFall18
{
    public class ReviewRepository : IReviewRepository
    {
        List<Review> allReviews = new List<Review>()
        {
            new Review() {ID = 1, Title = "Burg Eltz", ImageUrl = "/Images/berg-eltz.jpg", Location = "nestled in the hills above the Moselle River between Koblenz and Trier, Germany", Content = "" },
            new Review() {ID = 2, Title = "Neuschwanstein", ImageUrl = "/Images/neuschwanstein.jpg", Location = "village of Hohenschwangau near Füssen in southwest Bavaria, Germany", Content = "" },
            new Review() {ID = 3, Title = "Hohenschwangau", ImageUrl = "/Images/hohenschwangau.jpg", Location = "village of Hohenschwangau near Füssen in southwest Bavaria, Germany", Content = "" },
            new Review() {ID = 4, Title = "Rheinfels", ImageUrl = "/Images/rheinfels-castle.jpg", Location = "along the Rhein River in St. Goar, Germany", Content = "" },
        };

        public List<Review> GetAll()
        {
            return allReviews;
        }

        public Review FindById(int id)
        {
            return allReviews[id - 1];
        }
    }
}
