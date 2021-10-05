using System.Collections.Generic;
using Models;

namespace FileData
{
    public interface IFamilyData
    {
        IList<Family> GetFamily();
        //void AddPerson();
        //void RemovePerson();
        
    }
}