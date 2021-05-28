using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/// <summary>
/// Namespace for the models/custom data structures involved in Associate Reviews
/// </summary>
namespace ARModels
{
    /// <summary>
    /// Data structure used to define a Associate 
    /// </summary>
    public class Associate
    {

        private string _city;
        public Associate(string name, string city, string state, int revaturePoints)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
            this.RevaturePoints = revaturePoints;
        }
        public Associate()
        {

        }
        // Constructor chaining
        public Associate(int id, string name, string city, string state, int revaturePoints) : this(name, city, state, revaturePoints) 
        {
            this.Id = id;
        }
        public int Id { get; set; }

        public int RevaturePoints { get; set; }
        /// <summary>
        /// This describes the name of your Associate
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// This describes the location
        /// </summary>
        /// <value></value>
        public string City
        {
            get { return _city; }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$")) throw new Exception("City cannot have numbers!");
                _city = value;
            }
        }
        /// <summary>
        /// This describes the location
        /// </summary>
        /// <value></value>
        public string State { get; set; }
        /// <summary>
        /// This contains the review of a particular Associate
        /// </summary>
        /// <value></value>
        public List<Review> Reviews { get; set; }
        public override string ToString()
        {
            return $" Name: {Name} \n Location: {City}, {State}";
        }
        public bool Equals(Associate Associate)
        {
            return this.Name.Equals(Associate.Name) && this.City.Equals(Associate.City) && this.State.Equals(Associate.State);
        }
    }
}
