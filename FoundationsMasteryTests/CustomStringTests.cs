using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery.Interfaces;
using FoundationsMastery;
using System.Collections.Generic;
using System.Linq;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CustomStringTests
    {
        //*******MOST IMPORTANT***********
        // Instance is not null
        // Contents is not null with empty constructor
        // Contents is not null when passing in ienumerable for contents
        // .Length gives accurate count of ienumerable
        // .Clear removes all char from .Content
        // .CLear leaves you with a list/array/ienumberable (NOT NULL) for .Contents
        // Concat makes correct string
        // Interleave makes correct string
        // Print makes corrrect string
        //*******MOST IMPORTANT***********

        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CustomString custring = new CustomString();
            Assert.IsNotNull(custring);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
          
            char[] mychars = new char[] { 'd', 'o', 'c' };
            CustomString myString = new CustomString(mychars);

            int expected_length = 3;
            int actual_length = myString.Length; ;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            //1.Assert that the Contents property is the correct 'type'
            //2.Assert that the returned Contents is the coorect length
            //var expected = typeof(IEnumerable<char>);
            //var actual = myString.Contents.GetType();

            Assert.IsInstanceOfType(myString.Contents, typeof(IEnumerable<char>));
            Assert.AreEqual(myString.Length, mychars.Length);

            Assert.IsNotNull(myString.Contents);//ANOTHER GOOD WAY TO TEST
            CollectionAssert.AreEqual(mychars.ToList(), myString.Contents.ToList());
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            CustomString myString = new CustomString();

            myString.Clear();

            //How do you ensure your clear function works ?
        }

        [TestMethod]
        public void EnsuresLength()
        {
            CustomString myNewString = new CustomString(new List<char> { 'd', 'o', 'c' });

            Assert.AreEqual(3, myNewString.Length);
        }

        [TestMethod]
        public void EnsuresConcat()
        {
            CustomString myNewString = new CustomString(new char[] { 'd', 'o', 'c' });
            
            var expectedResult = "doctor";
            var actualResult = myNewString.Concat(new char[] {'t', 'o', 'r' });

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureInterleave()
        {
            CustomString myNewString = new CustomString(new char[] { 'd', 'o', 'c' });

            var expectedResult = "dtoocr";
            var actualResult = myNewString.Interleave(new char[] { 't', 'o', 'r' });

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureToPrint()
        {
            char[] mychars = new char[] { 'd', 'o', 'c', 't' };
            CustomString myString = new CustomString(mychars);

            var expectedResult = "doct";
            var actualResult = myString.Print();

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
