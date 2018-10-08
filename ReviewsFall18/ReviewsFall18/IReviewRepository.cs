using ReviewsFall18.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsFall18
{
    public interface IReviewRepository
    {
        List<Review> GetAll();
        Review FindById(int id);
    }
}
