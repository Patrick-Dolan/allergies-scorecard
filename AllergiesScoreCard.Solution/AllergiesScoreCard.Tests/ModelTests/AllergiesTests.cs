using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllergiesScoreCard.Models;
using System.Collections.Generic;

namespace AllergiesScoreCard.Tests
{
  [TestClass]
  public class AllergiesTests
  {
    [TestMethod]
    public void GetAllergieTable_ReturnsAllergieTable_Dictionary()
    {
      Dictionary<string, int> newDictionary = new Dictionary<string, int>() {{"eggs", 1}, {"peanuts", 2}, {"shellfish", 4}, {"strawberries", 8}, {"tomatoes", 16}, {"chocolate", 32}, {"pollen", 64}, {"cats", 128}};
      Dictionary<string, int> result = Allergies.GetAllergieTable();
      CollectionAssert.AreEqual(newDictionary, result);
    }
  }
}
// Example Test Method Structure
//_________________________
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }