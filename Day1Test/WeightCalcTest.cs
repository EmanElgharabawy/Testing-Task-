using Day1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Day1Test
{

  
    [TestClass]
    public class WeightCalcTest
    {
        [TestMethod]
        public void GetWight_hight_170_gender_M_return_65()
        {
            
            WeightCalculation weightCalcFemaleTest = new WeightCalculation
            {
                Hight = 170,
                Gender = 'M'
            };
          
            double Result = weightCalcFemaleTest.GetWight();
            double expectedResult = 65;

            Assert.AreEqual(expectedResult, Result);
        }

        [TestMethod]
        public void GetWight_hight_176_gender_F_return_63()
        {
            
            WeightCalculation weightCalcFemaleTest = new WeightCalculation
            {
                Hight = 176,
                Gender = 'F'
            };
        
            double Result = weightCalcFemaleTest.GetWight();
            double expectedResult = 63;

            Assert.AreEqual(expectedResult, Result);
        }

        [TestMethod]
        public void GetWight_hight_170_gender_Z_return_0()
        {
    
            WeightCalculation WeightCalcFemaleTest = new WeightCalculation
            {
                Hight = 176,
                Gender = 'Z'
            };
  
            double Result = WeightCalcFemaleTest.GetWight();
            double expectedResult = 0;

            Assert.AreEqual(expectedResult, Result);
        }

    }
}
