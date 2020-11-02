using MovieRating.Core.DataService;
using MovieReview.Core.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;

namespace MovieRating.Infrastructure.Data
{
   public class ReviewRepo: IReviewRepo
    {

       private IEnumerable<Review> reviewList;

       public IEnumerable<Review> GetAllReviews()
        {
            return reviewList;
        }

        public void InitializeData()
        {
            using (StreamReader r = new StreamReader("C:/Users/WøbbePC/Documents/file/ratings.json"))
            {
                string json = r.ReadToEnd();
                List<Review> reviews = JsonConvert.DeserializeObject<List<Review>>(json);
                reviewList = reviews;
            }
        }

    }
}
