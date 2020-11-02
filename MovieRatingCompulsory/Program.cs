using MovieRating.Core.AppService;
using MovieRating.Core.AppService.Services;
using MovieRating.Core.DataService;
using MovieRating.Infrastructure.Data;
using System;
using System.Runtime.CompilerServices;

namespace MovieRatingCompulsory
{
    class Program
    {
        static void Main(string[] args)
        {
            IReviewRepo _reviewRepo = new ReviewRepo();
            IReviewService _reviewService = new ReviewService(_reviewRepo);
            //Console.WriteLine(_reviewService.GetNumberOfReviewsFromReviewer(1));
        }
    }
}
