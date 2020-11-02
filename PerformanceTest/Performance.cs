using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRating.Core.AppService.Services;
using MovieRating.Core.DataService;
using MovieRating.Infrastructure.Data;

namespace PerformanceTest
{
    [TestClass]
    public class Performance
    {
        private static IReviewRepo repo;

        [ClassInitialize]

        public static void addJson(TestContext tc) 
        {
            repo = new ReviewRepo();
            repo.InitializeData();
            repo.GetAllReviews();
        }



        [TestMethod]
        [Timeout(4000)]
        public void TestMethod1()
        {
            ReviewService rs = new ReviewService(repo);
            rs.GetNumberOfReviewsFromReviewer(1);
           // rs.GetAverageRateFromReviewer(1);
           

        }

        [TestMethod]
        [Timeout(4000)]
        public void TestMethod2()
        {
            ReviewService rs = new ReviewService(repo);
           
            rs.GetAverageRateFromReviewer(1);


        }
        [TestMethod]
        [Timeout(4000)]
        public void TestMethod3()
        {
            ReviewService rs = new ReviewService(repo);
            rs.GetNumberOfRatesByReviewer(1,2);
            


        }
        [TestMethod]
        [Timeout(4000)]
        public void TestMethod4()
        {
            ReviewService rs = new ReviewService(repo);
            rs.GetNumberOfReviews(1);




        }
        [TestMethod]
        [Timeout(4000)]
        public void TestMethod5()
        {
            ReviewService rs = new ReviewService(repo);
            rs.GetAverageRateOfMovie(311232);
           


        }
        [TestMethod]
        [Timeout(4000)]
        public void TestMethod6()
        {
            ReviewService rs = new ReviewService(repo);
            rs.GetNumberOfRates(1,2);
        


        }
        [TestMethod]
        [Timeout(4000)]
        public void TestMethod7()
        {
            ReviewService rs = new ReviewService(repo);
            rs.GetMoviesWithHighestNumberOfTopRates();
           


        }
       
    }
}
