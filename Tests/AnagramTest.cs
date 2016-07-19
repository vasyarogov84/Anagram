using Xunit;
using System;
using System.Collections.Generic;

namespace Anagram
{
  public class AnagramTest
  {
    [Fact]
    public void IsAnagram_CompareTwoWordsIfAnagram_true()
    {
      Anagram test = new Anagram() {};
      Assert.Equal(true, test.IsAnagram("bread", "beard"));
    }

    // [Fact]
    // public void IsAnagramMultipleWords_CompareMultipleWordsIfAnagram_true()
    // {
    //   Anagram test = new Anagram() {};
    //   List<string> testList = new List<string>() {"bread", "beard", "rock", "pig"};
    //   List<string> expectedResults = new List<string>() {"bread", "beard", "beard", "bread"};
    //   Assert.Equal(expectedResults, test.IsAnagramMultipleWords(testList));
    // }

    [Fact]
    public void IsAnagramMultipleWords_ReturnAnagramsWithoutDuplicates_true()
    {
      Anagram test = new Anagram() {};
      List<string> testList = new List<string>() {"bread", "beard", "rock", "pig"};
      List<string> expectedResults = new List<string>() {"bread", "beard"};
      Assert.Equal(expectedResults, test.IsAnagramMultipleWords(testList));
    }

    [Fact]
    public void IsAnagramPartial_ComparePartialAnagram_true()
    {
      Anagram test = new Anagram() {};
      Assert.Equal(true, test.IsAnagramPartial("rope", "poorest"));
    }
  }
}
