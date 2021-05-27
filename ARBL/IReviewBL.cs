using ARModels;
using System;
using System.Collections.Generic;
namespace ARBL
{
    public interface IReviewBL
    {
        Review AddReview(Associate Associate, Review review);
        Tuple<List<Review>, int> GetReviews(Associate Associate);
    }
}