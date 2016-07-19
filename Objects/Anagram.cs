using System.Collections.Generic;
using System;

namespace Anagram
{
  public class Anagram
  {
    public bool IsAnagram(string word1, string word2)
    {
      char[] array1 = word1.ToCharArray();
      char[] array2 = word2.ToCharArray();

      Array.Sort(array1);
      Array.Sort(array2);

      string result1 = string.Join("", array1);
      string result2 = string.Join("", array2);

      if (result1 == result2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public List<string> IsAnagramMultipleWords(List<string> words)
    {
      List<string> results = new List<string>() {};

      for (int i = 0; i < words.Count; i++)
      {
        for (int j = 0; j < words.Count; j++)
        {
          if (i != j)
          {
            Anagram testObject = new Anagram() {};
            if (testObject.IsAnagram(words[i], words[j]))
            {
              results.Add(words[i]);
              results.Add(words[j]);
            }
          }
        }
      }

      for (int i = 0; i < results.Count; i++)
      {
        for(int j = 0; j < results.Count; j++)
        {
          if(i != j)
          {
            if (results[i] == results[j])
            {
              results.RemoveAt(j);
            }
          }
        }
      }
      return results;
    }

    public bool IsAnagramPartial (string word1, string word2)
    {
      char[] array1 = null; //the shorter word
      char[] array2 = null; //the longer word
      char[] matchedWord = null;

      if (word1.Length >= word2.Length)
      {
        array1 = word2.ToCharArray();
        matchedWord = word2.ToCharArray();
        array2 = word1.ToCharArray();
      }
      else if (word2.Length > word1.Length)
      {
        array1 = word1.ToCharArray();
        matchedWord = word1.ToCharArray();
        array2 = word2.ToCharArray();
      }

      for (int i = 0; i < array1.Length; i++)
      {
        for (int j = 0; j < array2.Length; j++)
        {
          if (array1[i] == array2[j])
          {
            matchedWord[i] = '0';
          }
        }
      }

      for (int i = 0; i < matchedWord.Length; i ++)
      {
        if (matchedWord[i] != '0')
        {
          return false;
        }
      }

      return true;
    }
  }
}
