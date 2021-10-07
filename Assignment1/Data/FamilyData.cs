using System.Collections.Generic;
using Models;

namespace FileData
{
    public class FamilyData : IFamilyData
    {
        private FileContext _fileContext = new FileContext();
       
        public IList<Family> GetFamily()
        {
            return _fileContext.Families;
        }

        /*public void AddAdult(Adult adult)
        {
         _fileContext.Families.Add(adult);
        }
        */

        
    }
}