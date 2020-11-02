using System;
using System.Collections.Generic;
using System.Text;

namespace MovieReview.Core.Entity
{
    public class Review
    {
        public int Id { get; set; } /// maybe deleted

        public int Reviewer { get; set; }

        public int Movie { get; set; }

        public int Grade { get; set; }

        public DateTime ReviewDate { get; set; }
    }
}
