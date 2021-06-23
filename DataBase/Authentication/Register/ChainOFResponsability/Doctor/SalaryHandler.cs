using System;
using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class SalaryHandler : BaseHandler
    {
        public bool IsDouble(string text)
        {
            Double num = 0;
            bool isDouble = Double.TryParse(text, out num);

            return isDouble;
        }
        public override object Authenticator(Request request)
        {
            if (request.Data is Doctor doctor)
            {
                if (!IsDouble(doctor.salary))
                    request.ErrorMessage.Append("Valor de salário inválido!! \n");
            }

            return base.Authenticator(request);
        }
    }
}