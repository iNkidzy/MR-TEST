using MovieRating.Core.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MovieRating.Core.AppService.Services
{
    public class ReviewService: IReviewService
    {
        IReviewRepo reviewRepo;
        public ReviewService(IReviewRepo rRepo)
        {
            reviewRepo = rRepo;
        }
        // Question 1
        public int GetNumberOfReviewsFromReviewer(int reviewer) 
        {
            int result = reviewRepo.GetAllReviews().Count(r=>r.Reviewer==reviewer);
            return result;
        }
        // Question 2
        public double GetAverageRateFromReviewer(int reviewer) 
        {
            var aRate = (from r in reviewRepo.GetAllReviews().Where
                         (r => r.Reviewer== reviewer)select r.Grade);
            return aRate.Average(r => r);

        }
        // Question 3
        public int GetNumberOfRatesByReviewer(int reviewer, int rate)
        {
            int result = 0;
            foreach (var item in reviewRepo.GetAllReviews())
            {
                if(item.Reviewer==reviewer && item.Grade == rate)
                {
                    result++;
                }
            }
            return result;
        }
        //Question 4
        public int GetNumberOfReviews(int movie)
        {
            int result = 0;
            foreach (var item in reviewRepo.GetAllReviews())
            {
                if (item.Movie==movie)
                {
                    result++;
                }
            }
            return result;
        }
        //Question 5
        public double GetAverageRateOfMovie(int movie)
        {
            var aRate = (from r in reviewRepo.GetAllReviews().Where
                         (r => r.Movie == movie)
                         select r.Grade);
            return aRate.Average(r => r);
        }
        //Question 6
        public int GetNumberOfRates(int movie, int rate)
        {
            int result = 0;
            foreach (var item in reviewRepo.GetAllReviews())
            {
                if (item.Movie == movie && item.Grade==rate)
                {
                    result++;
                }
            }
            return result;
        }
        //Question 7
        public List<int> GetMoviesWithHighestNumberOfTopRates()
        {
            List<int> result = new List<int>();
            foreach (var item in reviewRepo.GetAllReviews())
            {
                if (item.Grade == 5)
                {
                    result.Add(item.Movie);
                }
            }
            return result;
        }
        //Question 8
        public List<int> GetMostProductiveReviewers()
        {
            return null;
        }
        //Question 9
        public List<int> GetTopRatedMovies(int amount)
        {
            return null;
        }
        //Question 10
        public List<int> GetTopMoviesByReviewer(int reviewer)
        {
            return null;
        }
        //Question 11
        public List<int> GetReviewersByMovie(int movie)
        {
            return null;
        }
    }
}
