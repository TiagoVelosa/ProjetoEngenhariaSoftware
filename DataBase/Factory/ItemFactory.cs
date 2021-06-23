
using System;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Factory
{
    public class ItemFactory : IFactory
    {

        public static readonly string Meds = "Meds";
        public static readonly string Exercise = "Exercise";
        public static readonly string Treatment = "Treatment";
        public object Create(string type)
        {
            Item item = null;
            if (type == Meds)
                item = new Medicamento();
            else if (type == Exercise)
                item = new Exercise();
            else if (type == Treatment)
                item = new Treatment();
            else
                throw new Exception("Invalid Type!");

            return item;
        }
    }
}