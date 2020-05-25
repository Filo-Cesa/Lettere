using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {
        // Convert the string in lower case letters 
        word = word.ToLower(); 
       word = word.Replace("-", "");
       word = word.Replace(" ", "");

        int len = word.Length; 
  
        char[] arr = word.ToCharArray(); 
  
        Array.Sort(arr); 
        for (int i = 0; i < len - 1; i++) { 
            if (arr[i] == arr[i + 1]) 
                return false; 
        } 
        return true;
    } 
}
