class Validation
{
    public static bool IsValidUsername(string username)
    {
        foreach (char c in username)
        {
            if (!char.IsLetter(c))
                return false;
        }
        return true;
    }

    public static bool IsValidPassword(string password)
    {
        if (password.Length < 8 || password.Length > 20)
            return false;

        bool hasNumber = false;
        bool hasSpecialChar = false;

        foreach (char c in password)
        {
            if (char.IsDigit(c)) hasNumber = true;
            if ("!@#$%^&*".Contains(c)) hasSpecialChar = true;
        }

        return hasNumber && hasSpecialChar;
    }
}
