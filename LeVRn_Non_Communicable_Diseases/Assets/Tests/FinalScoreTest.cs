using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class FinalScoreTest
    {
        [Test]
        public void SetFinalScoreTo50PercentWhenTotalScoreIs17()
        {
            int displayedScore = FinalResultManager.CalculateFinalScore(17);
            
            Assert.AreEqual(50, displayedScore);
        }
    }
}
