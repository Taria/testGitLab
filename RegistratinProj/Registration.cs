using System;
using System.Collections.Generic;
using System.Text;

namespace RegistratinML
{
    public class Registration
    {
        public int Login(string username, string password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || username.Length < 8 || username.Length > 30
                || password.Length < 8 || password.Length > 30)
                throw new ArgumentOutOfRangeException("Incorect input field");

            return 0;
        }
    }
}
