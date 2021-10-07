using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IFamilyData
    {
        IList<Family> GetFamily();
        //void AddAdult(Adult adult);
        //void RemovePerson();
        
    }
}