using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(ProductCode());
    }

    static string ProductCode()
    {
        Random random = new Random();
        string characters = "ACDEFGHKLMNPRTXYZ234579";
        int code_length = 8;
        char[] code = new char[code_length];

        for (int i = 0; i < code_length; i++)
        {
            code[i] = characters[random.Next(characters.Length)];
        }

        if(code != null)
        {
            bool isValid = CheckCode(new string(code), characters, code_length);
            if (isValid)
            {
                return new string(code);
            }
            else
            {
                return "Kod geçerli değil.";
            }
        }

        return "Kod geçerli değil.";


    }

    static bool CheckCode(string code, string characters, int code_length)
    {
        // Kodun uzunluğu kontrolü
        if (code.Length != code_length)
        {
            return false;
        }

        // Kodun karakter kümesindeki karakterleri içerip içermediği kontrolü
        foreach (char c in code)
        {
            if (!characters.Contains(c))
            {
                return false;
            }
        }

        return true;
    }
}
