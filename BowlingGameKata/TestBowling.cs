using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    [TestFixture]
    public class TestBowling
    {
        [Test]
        public void AllZero()
        {
            List<int> pins = new List<int> 
            {
                0,0,  0,0,  0,0,  0,0,  0,0,
                0,0,  0,0,  0,0,  0,0,  0,0
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(0));
        }

        [Test]
        public void AllOnes()
        {
            List<int> pins = new List<int> 
            {
                1,1,  1,1,  1,1,  1,1,  1,1, 
                1,1,  1,1,  1,1,  1,1,  1,1 
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo((1+1)*10));
        }

        [Test]
        public void OneStrike()
        {
            List<int> pins = new List<int> 
            {
                10,0,  1,1,  1,1,  1,1,  1,1, 
                1,1,   1,1,  1,1,  1,1,  1,1 
            };

            Assert.That(Game.GetScore(pins), Is.EqualTo(
                (10 + 1 + 1) + (1 + 1)* 9));
        }


    }
}
