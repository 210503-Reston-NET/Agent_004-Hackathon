using System;
namespace ARModels
{
    public class Review
    {
        private int _rating;
        /// <summary>
        /// This describes the overall numeric rating of a Associate
        /// </summary>
        /// <value></value>
        public Review(int rating, string desc)
        {
            this.Rating = rating;
            this.Description = desc;
        }
        public Review()
        { }
        public int Rating
        {
            get { return _rating; }
            set
            {
                if (_rating < 0)
                {
                    throw new Exception("Rating should be greater tha zero.");
                }
                _rating = value;
            }
        }
        /// <summary>
        /// Verbose description of the dining experience
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        public int AssociateId { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"\t Rating: {Rating} \n\t Description: {Description}";
        }
    }
}