using System;

namespace PokepayPartnerCsharpSdk.Test
{
    public class Util
    {
        public static string RandomString(int n)
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var result = new char[n];
            var random = new Random();

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = characters[random.Next(characters.Length)];
            }

            return new String(result);
        }
    }
}