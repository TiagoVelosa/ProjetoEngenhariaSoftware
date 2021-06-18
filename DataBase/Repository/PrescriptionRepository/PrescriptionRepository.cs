﻿using System.Collections.Generic;
using System.Linq;
using DataBase.Modules;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryEngSoft.Repository
{
    public class PrescriptionRepository : Repository<Prescription>, IPrescriptionRepository
    {

        public PrescriptionRepository(DBContext context) : base(context)
        {
        }
        public IEnumerable<Prescription> GetPrescriptionsByName(string name)
        {
            if (Context.Prescricoes != null)
            {
                if (Context.Prescricoes.Include(e => e.Client).Where(e => e.Client.name == name) != null)
                {
                    return Context.Prescricoes.Include(e => e.Client).Where(e => e.Client.name == name).ToList();
                }

            }
            return null;
        }

        public Prescription GetPrescriptionByID(int id)
        {
            return Context.Prescricoes.FirstOrDefault(e => e.ID == id);
        }

        public IEnumerable<Prescription> GetPrescriptionsByDoctor(Doctor doctor)
        {
            return Context.Prescricoes.Where(e => e.Doctor == doctor).ToList();
        }

        public Prescription GetPrescriptionByTitle(string title)
        {
            return Context.Prescricoes.Include(e=>e.Items).FirstOrDefault(e => e.title == title);
        }


        /*public IEnumerable<Item> GetPrescriptionItems(Prescription prescription)
        {
            return Context.Prescricoes.Where(e => e.ID == prescription.ID).Include(e => e.Items).ToList();
        }*/

        
    }
}