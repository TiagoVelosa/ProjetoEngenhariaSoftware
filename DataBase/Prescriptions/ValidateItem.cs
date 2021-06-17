using System;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication.Prescriptions
{
    public class ValidateItem
    {
        public bool IsDouble(string text)
        {
            Double num = 0;
            bool isDouble = false;

            // Check for empty string.
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            isDouble = Double.TryParse(text, out num);

            return isDouble;
        }

        public bool isValidName(Prescription prescription, string name)
        {
            foreach (var item in prescription.Items)
            {
                if (item.Name == name)
                {
                    return false;
                }
            }

            return true;
        }

        public bool isValidDate(string date)
        {
            TimeSpan time;
            return TimeSpan.TryParse(date, out time);
        }
    }
}