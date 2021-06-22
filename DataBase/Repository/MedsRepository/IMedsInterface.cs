﻿using System.Collections.Generic;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Repository
{
    public interface IMedsInterface : IRepository<Medicamento>
    {
        IEnumerable<Medicamento> GetMedsByPrescription(int ID);
        IEnumerable<Medicamento> GetMedsPublicByPrescription(int ID);

        IEnumerable<Medicamento> GetPrivateMeds(int ID);
        Medicamento GetMedByName(string name, string title);
    }
}