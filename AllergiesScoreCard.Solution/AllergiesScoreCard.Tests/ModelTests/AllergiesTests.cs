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
    [TestMethod]
    public void AllergyList_AddToAllergyList_List()
    {
      List<string> newList = new List<string> {"eggs"};
      Allergies result = new Allergies("Patrick");
      result.AllergyList.Add("eggs");
      CollectionAssert.AreEqual(newList, result.AllergyList);
    }
    [TestMethod]
    public void AllergyList_RemoveToAllergyList_List()
    {
      List<string> newList = new List<string> {"peanuts"};
      Allergies result = new Allergies("Patrick");
      result.AllergyList.Add("eggs");
      result.AllergyList.Add("peanuts");
      result.AllergyList.Remove("eggs");
      CollectionAssert.AreEqual(newList, result.AllergyList);
    }
    [TestMethod]
    public void GetScore_ReturnsScore_Score()
    {
      Allergies person = new Allergies("Marni");
      int number = 0;
      Assert.AreEqual(number, person.Score);
    }
    [TestMethod]
    public void ExtractKeys_ReturnsAllergyTableKeys_List()
    {
      List<string> result = Allergies.ExtractKeys();
      List<string> newList = new List<string> {"eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats"};
      Assert.AreEqual(newList, result);
    }
  }
}