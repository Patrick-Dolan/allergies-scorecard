using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllergiesScoreCard.Models;
using System.Collections.Generic;

namespace AllergiesScoreCard.Tests
{
  [TestClass]
  public class AllergiesTests
  {
    [TestMethod]
    public void GetAllergyTable_ReturnsAllergyTable_Dictionary()
    {
      Dictionary<string, int> newDictionary = new Dictionary<string, int>() {{"eggs", 1}, {"peanuts", 2}, {"shellfish", 4}, {"strawberries", 8}, {"tomatoes", 16}, {"chocolate", 32}, {"pollen", 64}, {"cats", 128}};
      Dictionary<string, int> result = Allergies.GetAllergyTable();
      CollectionAssert.AreEqual(newDictionary, result);
    }
    [TestMethod]
    public void AllergyList_ReturnsAllergyList_List()
    {
      List<string> newList = new List<string> {};
      Allergies result = new Allergies("Patrick");
      CollectionAssert.AreEqual(newList, result.AllergyList);
    }
  }
}