using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieRating.Core.AppService.Services;
using MovieRating.Core.DataService;
using MovieReview.Core.Entity;
using Xunit.Sdk;

namespace UnitTest
{
    [TestClass]
    public class UnitTestClass
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


    }

}
