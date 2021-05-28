using System.Collections.Generic;
using ARModels;
using ARDL;
using System;

namespace ARBL
{
    /// <summary>
    /// Business logic class for the Associate model
    /// </summary>
    public class AssociateBL : IAssociateBL
    {
        
        private IRepository _repo;
        public AssociateBL(IRepository repo)
        {
            _repo = repo;
        }

        public Associate AddAssociate(Associate Associate)
        {
          
            if (_repo.GetAssociate(Associate) != null)
            {
                throw new Exception("Associate already exists :<");
            }
            return _repo.AddAssociate(Associate);
        }

        public Associate DeleteAssociate(Associate Associate)
        {
            Associate toBeDeleted = _repo.GetAssociate(Associate);
            if (toBeDeleted != null) return _repo.DeleteAssociate(toBeDeleted);
            else throw new Exception("Associate does not exist. Must've been deleted already :>");
        }

        public List<Associate> GetAllAssociates()
        {
            return _repo.GetAllAssociates();
        }

        public Associate GetAssociate(Associate Associate)
        {
            return _repo.GetAssociate(Associate);
        }
        public Associate GetAssociateById(int id)
        {
            return _repo.GetAssociateById(id);
        }
        public Associate UpdateAssociate(Associate associate)
        {
            return _repo.UpdateAssociate(associate);
        }
    }
}