using NUnit.Framework;

namespace RomanNumerals
{
    
    [TestFixture]
    class Tests
    {
        RomanNumeralConverter rnc;
        public Tests()  {   rnc = new RomanNumeralConverter();  }

        [Test]
        public void Input_1_ShouldReturn_I() { Assert.AreEqual("I", rnc.GetNumerals(1)); }

        [Test]
        public void Input_3_ShouldReturn_III() { Assert.AreEqual("III", rnc.GetNumerals(3)); }

        [Test]
        public void Input_5_ShouldReturn_V() { Assert.AreEqual("V", rnc.GetNumerals(5)); }

        [Test]
        public void Input_4_ShouldReturn_IV() { Assert.AreEqual("IV", rnc.GetNumerals(4)); }

        [Test]
        public void Input_6_ShouldReturn_VI() { Assert.AreEqual("VI", rnc.GetNumerals(6)); }

        [Test]
        public void Input_7_ShouldReturn_VII() { Assert.AreEqual("VII", rnc.GetNumerals(7)); }

        [Test]
        public void Input_8_ShouldReturn_VIII() { Assert.AreEqual("VIII", rnc.GetNumerals(8)); }

        [Test]
        public void Input_9_ShouldReturn_IX() { Assert.AreEqual("IX", rnc.GetNumerals(9)); }

        [Test]
        public void Input_10_ShouldReturn_X() { Assert.AreEqual("X", rnc.GetNumerals(10)); }

        [Test]
        public void Input_11_ShouldReturn_XI() { Assert.AreEqual("XI", rnc.GetNumerals(11)); }

        [Test]
        public void Input_15_ShouldReturn_XV() { Assert.AreEqual("XV", rnc.GetNumerals(15)); }

        [Test]
        public void Input_35_ShouldReturn_XXXVI() { Assert.AreEqual("XXXVI", rnc.GetNumerals(36)); }

        [Test]
        public void Input_846_ShouldReturn_DCCCXLVI() { Assert.AreEqual("DCCCXLVI", rnc.GetNumerals(846)); }

        [Test]
        public void Input_1999_ShouldReturn_MCMXCIX() { Assert.AreEqual("MCMXCIX", rnc.GetNumerals(1999)); }

        [Test]
        public void Input_2420_ShouldReturn_MMCDXX() { Assert.AreEqual("MMCDXX", rnc.GetNumerals(2420)); }
        
    }

}
