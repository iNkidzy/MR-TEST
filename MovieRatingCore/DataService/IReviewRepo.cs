using MovieReview.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Core.DataService
{
   public interface IReviewRepo
    {
        void InitializeData();
        IEnumerable<Review> GetAllReviews();
    }
}
