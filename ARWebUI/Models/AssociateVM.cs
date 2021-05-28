using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ARModels;

namespace ARWebUI.Models
{
    public class AssociateVM
    {
        public AssociateVM(Associate associate)
        {
             Id = associate.Id;
             name= associate.Name;
             City= associate.City;
             State= associate.State;
             RevaPoints= associate.RevaturePoints;
        }
        public AssociateVM()
        {  }

        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string City { get; set; }

        [DisplayName("State or Province")]
        [Required]
        public string State { get; set; }

        public int RevaPoints { get; set; }

    }
}
