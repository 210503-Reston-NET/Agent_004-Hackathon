using System.Collections.Generic;
using ARModels;
namespace ARBL
{
    public interface IAssociateBL
    {
        List<Associate> GetAllAssociates();
        Associate AddAssociate(Associate Associate);
        Associate GetAssociate(Associate Associate);
        Associate DeleteAssociate(Associate Associate);
    }
}