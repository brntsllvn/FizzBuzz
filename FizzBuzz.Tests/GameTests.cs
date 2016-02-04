using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class GameTests
    {
        private Game g;

        [SetUp]
        public void Init()
        {
            g = new Game();
        }

        [Test]
        public void One()
        {
            String fizzbuzz = g.FizzBuzzifier(1);
            Assert.That(fizzbuzz, Is.EqualTo("1"));
        }

        [Test]
        public void Two()
        {
            String fizzbuzz = g.FizzBuzzifier(2);
            Assert.That(fizzbuzz, Is.EqualTo("2"));
        }

        [Test]
        public void Three()
        {
            String fizzbuzz = g.FizzBuzzifier(3);
            Assert.That(fizzbuzz, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Four()
        {
            String fizzbuzz = g.FizzBuzzifier(4);
            Assert.That(fizzbuzz, Is.EqualTo("4"));
        }

        [Test]
        public void Five()
        {
            String fizzbuzz = g.FizzBuzzifier(5);
            Assert.That(fizzbuzz, Is.EqualTo("Buzz"));
        }

        [Test]
        public void Fifteen()
        {
            String fizzbuzz = g.FizzBuzzifier(15);
            Assert.That(fizzbuzz, Is.EqualTo("Fizz Buzz"));
        }

        [Test]
        public void OneHundredThree()
        {
            String fizzbuzz = g.FizzBuzzifier(103);
            Assert.That(fizzbuzz, Is.EqualTo("103"));
        }

        [Test]
        public void SevenNinetyFive()
        {
            String fizzbuzz = g.FizzBuzzifier(795);
            Assert.That(fizzbuzz, Is.EqualTo("Fizz Buzz"));
        }

        [Test]
        public void LargeNum()
        {
            String fizzbuzz = g.FizzBuzzifier(10000003);
            Assert.That(fizzbuzz, Is.EqualTo("10000003"));
        }
    }
}
