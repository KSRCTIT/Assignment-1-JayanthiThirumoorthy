public class LoginSystem
{
    public void Run()
    {
        bool usernameValid = true;
        bool passwordValid = false;

        Console.WriteLine("Login successful: " + (usernameValid && passwordValid));
        Console.WriteLine(" Either username or password is invalid: " + (!usernameValid || !passwordValid));
    }
}
