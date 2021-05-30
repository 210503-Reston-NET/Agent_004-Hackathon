using System;
using System.Collections.Generic;
using ARDL;
using ARModels;

namespace ARBL
{
    public class ReviewBL : IReviewBL
    {
        private IRepository _repo;
        public ReviewBL(IRepository repo)
        {
            _repo = repo;
        }
        public Review AddReview(Associate Associate, Review review)
        {
     
            _repo.AddReview(Associate, review);
            return review;
        }

        public Tuple<List<Review>, int> GetReviews(Associate Associate)
        {
          
            List<Review> AssociateReviews = _repo.GetReviews(Associate);
            int averageRating = 0;
            AssociateReviews.ForEach(review => averageRating += review.Rating);
            int revs = AssociateReviews.Count;
            if(revs != 0)
            {
                averageRating = averageRating / AssociateReviews.Count;
            }
            return new Tuple<List<Review>, int>(AssociateReviews, averageRating);
        }
    }
}