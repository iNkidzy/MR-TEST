using MovieRating.Core.AppService.Services;
using MovieRating.Core.DataService;
using MovieRating.Infrastructure.Data;
using System;
using Xunit;

namespace XUnitTest
{
    public class xUnitTest
    {
        private IReviewRepo repo;


        public xUnitTest() 
        {
            repo = new ReviewRepo();
            repo.InitializeData();
            repo.GetAllReviews();
        }

        [Fact]
        public void Test1()
        {
            ReviewService rs = new ReviewService(repo);
            
            DateTime start = DateTime.Now;
            rs.GetNumberOfReviewsFromReviewer(1);
            DateTime end = DateTime.Now;
            double time = (end - start).TotalMilliseconds;
            Assert.True(time <= 4000);
        }
        [Fact]
        public void Test2()
        {
            ReviewService rs = new ReviewService(repo);

            DateTime start = DateTime.Now;
            rs.GetAverageRateFromReviewer(1);
            DateTime end = DateTime.Now;
            double time = (end - start).TotalMilliseconds;
            Assert.True(time <= 4000);
        }
        [Fact]
        public void Test3()
        {
            ReviewService rs = new ReviewService(repo);

            DateTime start = DateTime.Now;
            rs.GetNumberOfRatesByReviewer(1,2);
            DateTime end = DateTime.Now;
            double time = (end - start).TotalMilliseconds;
            Assert.True(time <= 4000);
        }
        [Fact]
        public void Test4()
        {
            ReviewService rs = new ReviewService(repo);

            DateTime start = DateTime.Now;
            rs.GetNumberOfReviews(1);
            DateTime end = DateTime.Now;
            double time = (end - start).TotalMilliseconds;
            Assert.True(time <= 4000);
        }
        [Fact]
        public void Test5()
        {
            ReviewService rs = new ReviewService(repo);

            DateTime start = DateTime.Now;
            rs.GetAverageRateOfMovie(311232);
            DateTime end = DateTime.Now;
            double time = (end - start).TotalMilliseconds;
            Assert.True(time <= 4000);
        }
        [Fact]
        public void Test6()
        {
            ReviewService rs = new ReviewService(repo);

            DateTime start = DateTime.Now;
            rs.GetNumberOfRates(1, 2);
            DateTime end = DateTime.Now;
            double time = (end - start).TotalMilliseconds;
            Assert.True(time <= 4000);
        }
        [Fact]
        public void Test7()
        {
            ReviewService rs = new ReviewService(repo);

            DateTime start = DateTime.Now;
            rs.GetMoviesWithHighestNumberOfTopRates();
            DateTime end = DateTime.Now;
            double time = (end - start).TotalMilliseconds;
            Assert.True(time <= 4000);
        }
    }
}
