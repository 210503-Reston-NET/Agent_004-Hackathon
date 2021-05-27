using System.Collections.Generic;
using ARModels;
namespace ARDL
{
    public interface IRepository
    {
        List<Associate> GetAllAssociates();
        Associate AddAssociate(Associate Associate);
        Associate GetAssociate(Associate Associate);

        Associate DeleteAssociate(Associate Associate);
        Review AddReview(Associate Associate, Review review);
        List<Review> GetReviews(Associate Associate);
    }
}