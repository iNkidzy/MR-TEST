using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieRating.Core.AppService.Services;
using MovieRating.Core.DataService;
using MovieReview.Core.Entity;
using System.Collections.Generic;
using System.Linq;

namespace ReviewTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Mock<IReviewRepo> mr = new Mock<IReviewRepo>();

            // change with json file
            Review[] value =
                { new Review  {Reviewer = 1, Movie = 2, Grade = 3 },
                new Review {Reviewer = 2, Movie = 2, Grade = 4 } };

            mr.Setup(mr => mr.GetAllReviews()).Returns(() => value);

            ReviewService rService = new ReviewService(mr.Object);

            int aResult = rService.GetNumberOfReviewsFromReviewer(2);

            mr.Verify(mr => mr.GetAllReviews(), Times.Once);

            Assert.IsTrue(aResult == 1);

        }
        [TestMethod]
        public void Test2()
        {
            Mock<IReviewRepo> mr = new Mock<IReviewRepo>();

            Review[] value =
              { new Review  {Reviewer = 1, Movie = 2, Grade = 3 },
                new Review {Reviewer = 1, Movie = 2, Grade = 4 },
                new Review {Reviewer = 1, Movie = 3, Grade = 2 },
                new Review {Reviewer = 3, Movie = 3, Grade = 2 }
            };

            mr.Setup(mr => mr.GetAllReviews()).Returns(() => value);

            ReviewService rService = new ReviewService(mr.Object);

            double aResult = rService.GetAverageRateFromReviewer(1);

            //  mr.Verify(mr => mr.GetAllReviews(), Times.Once);

            Assert.IsTrue(aResult == 3);
        }

        [TestMethod]
        public void Test3()
        {
            Mock<IReviewRepo> mr = new Mock<IReviewRepo>();

            Review[] value =
              { new Review  {Reviewer = 1, Movie = 2, Grade = 3 },
                new Review {Reviewer = 1, Movie = 1, Grade = 4 },
                new Review {Reviewer = 1, Movie = 3, Grade = 3 },
                new Review {Reviewer = 1, Movie = 4, Grade = 2 },
                new Review {Reviewer = 2, Movie = 3, Grade = 2 },
                new Review {Reviewer = 3, Movie = 3, Grade = 2 }
            };
            mr.Setup(mr => mr.GetAllReviews()).Returns(() => value);

            ReviewService rService = new ReviewService(mr.Object);
            int aResult = rService.GetNumberOfRatesByReviewer(1, 3);
            Assert.IsTrue(aResult == 2);
        }

        [TestMethod]
        public void test4()
        {
            Mock<IReviewRepo> mr = new Mock<IReviewRepo>();

            Review[] value =
             {
                new Review {Reviewer = 1, Movie = 3 },
                 new Review {Reviewer = 2, Movie = 2 },
                  new Review {Reviewer = 4, Movie = 5 },
                 new Review {Reviewer = 3, Movie = 4 }
            };

            mr.Setup(mr => mr.GetAllReviews()).Returns(() => value);
            ReviewService rService = new ReviewService(mr.Object);
            int result = rService.GetNumberOfReviews(3);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void test5()
        {
            Mock<IReviewRepo> mr = new Mock<IReviewRepo>();

            Review[] value =
            { new Review  {Reviewer = 2, Movie = 2, Grade = 5 },
                new Review {Reviewer = 1, Movie = 5, Grade = 4 },
                new Review {Reviewer = 4, Movie = 2, Grade = 6 },
                new Review {Reviewer = 3, Movie = 6, Grade = 3 }
            };

            mr.Setup(mr => mr.GetAllReviews()).Returns(() => value);

            ReviewService rService = new ReviewService(mr.Object);

            double aResult = rService.GetAverageRateOfMovie(2);
           

            Assert.IsTrue(aResult == 5.5);
        }
        [TestMethod]
        public void test6()
        {
        Mock<IReviewRepo> mr = new Mock<IReviewRepo>();

        Review[] value =
         {
                new Review {Reviewer = 1, Movie = 4, Grade = 2},
                 new Review {Reviewer = 2, Movie = 3, Grade = 5 },
                  new Review {Reviewer = 4, Movie = 5, Grade = 3 },
                 new Review {Reviewer = 3, Movie = 4, Grade = 6 }
            };

        mr.Setup(mr => mr.GetAllReviews()).Returns(() => value);
        ReviewService rService = new ReviewService(mr.Object);
        int result = rService.GetNumberOfRates(4, 2);
        Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void test7()
        {
            Mock<IReviewRepo> mr = new Mock<IReviewRepo>();

            Review[] value =
             {
                new Review {Reviewer = 1, Movie = 4, Grade = 3},
                 new Review {Reviewer = 2, Movie = 3, Grade = 5 },
                  new Review {Reviewer = 4, Movie = 2, Grade = 5 },
                 new Review {Reviewer = 3, Movie = 4, Grade = 4 }
            };

            mr.Setup(mr => mr.GetAllReviews()).Returns(() => value);
            ReviewService rService = new ReviewService(mr.Object);
            List<int> result = rService.GetMoviesWithHighestNumberOfTopRates();

             mr.Verify(mr => mr.GetAllReviews(), Times.Once);


            Assert.IsTrue(result.Count == 2);

            // CollectionAssert.AllItemsAreUnique(result);
        }
    }

}
    

