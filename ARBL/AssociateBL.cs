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
        // Some things to note:
        // BL classes are in charge of processing/ sanitizing/ further validating data
        // As the name suggests its in charge of processing logic. For example, how does the ordering process
        // work in a store app. 
        // Any logic that is related to accessing the data stored somewhere, should be relegated to the DL 
        private IRepository _repo;
        public AssociateBL(IRepository repo)
        {
            _repo = repo;
        }

        public Associate AddAssociate(Associate Associate)
        {
            // Todo: call a repo method that adds a Associate
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
            //Note that this method isn't really dependent on any inputs/parameters, I can just directly call the 
            // DL method in charge of getting all Associates
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