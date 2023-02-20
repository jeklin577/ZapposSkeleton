using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instnce of the class we want to create
            clsStock AnItem = new clsStock();
            //test to see tht it exists
            Assert.IsNotNull(AnItem); 
        }
    }
}
