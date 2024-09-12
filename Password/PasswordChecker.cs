using System;

namespace Password
{
    public class PasswordChecker
    {
        public int ValidatePassword(string password)
        {
            int quality = 0;

            if (password.IndexOfAny("0123456789".ToCharArray()) != -1)
                quality++;

            if (password.IndexOfAny("abcdefghijklmnopqrstuvwxyz".ToCharArray()) != -1)
                quality++;

            if (password.IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()) != -1)
                quality++;

            if (password.IndexOfAny("!@#$%^&*()_+-=\\|/?><.,;:'\"".ToCharArray()) != -1)
                quality++;

            if (password.Length > 10)
                quality++;

            return quality;
        }
    }
}
