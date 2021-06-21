using System.Collections.Generic;
using ClassLibraryEngSoft.UnitOfWork;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication.Prescriptions
{
    public class UpdatePrescription
    {
        private readonly IUnitOfWork _unit = new UnitOfWork.UnitOfWork();
        public void RemoveItems(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                _unit.Items.Remove(item);
            }
            _unit.Complete();
        }

        
    }
}