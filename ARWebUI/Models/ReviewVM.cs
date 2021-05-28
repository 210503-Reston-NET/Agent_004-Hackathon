using ARModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace RRWebUI.Models
{
    public class ReviewVM
    {
        public ReviewVM()
        {
        }

        public ReviewVM(int associateId)
        {
            AssociateId = associateId;
        }

        public ReviewVM(Review review)
        {
            AssociateId = review.AssociateId;
            Rating = review.Rating;
            Description = review.Description;
        }

        public int AssociateId { get; set; }

        [Required]
        [Range(0, 10)]
        public int Rating { get; set; }

        [Required]
        public string Description { get; set; }
    }
}