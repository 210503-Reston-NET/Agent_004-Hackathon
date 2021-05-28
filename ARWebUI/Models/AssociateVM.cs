using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ARModels;
using System.Text.RegularExpressions;

namespace ARWebUI.Models
{
    public class AssociateVM
    {
        public AssociateVM(Associate associate)
        {
            Id = associate.Id;
            name = associate.Name;
            City = associate.City;
            State = associate.State;
            RevaPoints = associate.RevaturePoints;
        }
        public AssociateVM()
        { }

        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string name { get; set; }

        [Required]
        
        public string City { get; set; }

        [DisplayName("State or Province")]
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
        public string State { get; set; }

        public int RevaPoints { get; set; }

    }
}
