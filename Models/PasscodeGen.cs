using System;

namespace RandomPasscode.Models
{
  public class PasscodeGen
  {
    public string result = "";
    static string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    int charactersLength = characters.Length;

    public string Passcode()
    {

      for (int i = 0; i < 14; i++)
      {
        Random rand = new Random();
        result += characters[rand.Next(0, charactersLength)];
      }
      return result;
    }

  }
}