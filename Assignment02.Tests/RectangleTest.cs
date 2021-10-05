// Author : Karthikeyan Shanmugam
// Student Number : 8740880
// Class : Cad Section1
using NUnit.Framework;

namespace Assignment02.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        Rectangle rect = new Rectangle();
        [Test]
        public void GettingLength1()
        {
            int a = 1;//arrange
            int result = rect.GetLength(); //act
            Assert.AreEqual(result, a); //assert
        }
        [Test]
        public void SettingLength1()
        {
            int a = 9;//arrange
            int result = rect.SetLength(a); //act
            Assert.AreEqual(result, a); //assert
        }
        [Test]
        public void GettingWidth1()
        {
            int b = 1;//arrange
            int result = rect.GetWidth(); //act
            Assert.AreEqual(result, b); //assert
        }
        [Test]
        public void SettingWidth1()
        {
            int b = 8;//arrange
            int result = rect.SetWidth(b); //act
            Assert.AreEqual(result, b); //assert
        }
        [Test]
        public void GettingHeight1()
        {
            int c = 1;//arrange
            int result = rect.GetHeight(); //act
            Assert.AreEqual(result, c); //assert
        }
        [Test]
        public void SettingHeight1()
        {
            int c = 7;//arrange
            int result = rect.SetHeight(c); //act
            Assert.AreEqual(result, c); //assert
        }
        [Test]
        public void Volume_for_Rectangle1()
        {
            int a = 9, b = 8, c = 7;//arrange
            rect.SetLength(a);//arrange
            rect.SetWidth(b);//arrange
            rect.SetHeight(c);//arrange
            int result = rect.GetVolume(); //act
            Assert.AreEqual(result, 504); //assert
        }
        [Test]
        public void GettingLength2()
        {
            int a = 1;//arrange
            int result = rect.GetLength(); //act
            Assert.AreEqual(result, a); //assert
        }
        [Test]
        public void SettingLength2()
        {
            int a = 6;//arrange
            int result = rect.SetLength(a); //act
            Assert.AreEqual(result, a); //assert
        }
        [Test]
        public void GettingWidth2()
        {
            int b = 1;//arrange
            int result = rect.GetWidth(); //act
            Assert.AreEqual(result, b); //assert
        }
        [Test]
        public void SettingWidth2()
        {
            int b = 5;//arrange
            int result = rect.SetWidth(b); //act
            Assert.AreEqual(result, b); //assert
        }
        [Test]
        public void GettingHeight2()
        {
            int c = 1;//arrange
            int result = rect.GetHeight(); //act
            Assert.AreEqual(result, c); //assert
        }
        [Test]
        public void SettingHeight2()
        {
            int c = 4;//arrange
            int result = rect.SetHeight(c); //act
            Assert.AreEqual(result, c); //assert
        }
        [Test]
        public void Volume_for_Rectangle2()
        {
            int a = 6, b = 5, c = 4;//arrange
            rect.SetLength(a);//arrange
            rect.SetWidth(b);//arrange
            rect.SetHeight(c);//arrange
            int result = rect.GetVolume(); //act
            Assert.AreEqual(result, 120); //assert
        }
        [Test]
        public void GettingLength3()
        {
            int a = 1;//arrange
            int result = rect.GetLength(); //act
            Assert.AreEqual(result, a); //assert
        }
        [Test]
        public void SettingLength3()
        {
            int a = 3;//arrange
            int result = rect.SetLength(a); //act
            Assert.AreEqual(result, a); //assert
        }
        [Test]
        public void GettingWidth3()
        {
            int b = 1;//arrange
            int result = rect.GetWidth(); //act
            Assert.AreEqual(result, b); //assert
        }
        [Test]
        public void SettingWidth3()
        {
            int b = 2;//arrange
            int result = rect.SetWidth(b); //act
            Assert.AreEqual(result, b); //assert
        }
        [Test]
        public void GettingHeight3()
        {
            int c = 1;//arrange
            int result = rect.GetHeight(); //act
            Assert.AreEqual(result, c); //assert
        }
        [Test]
        public void SettingHeight3()
        {
            int c = 2;//arrange
            int result = rect.SetHeight(c); //act
            Assert.AreEqual(result, c); //assert
        }
        [Test]
        public void Volume_for_Rectangle3()
        {
            int a = 3, b = 2, c = 2;//arrange
            rect.SetLength(a);//arrange
            rect.SetWidth(b);//arrange
            rect.SetHeight(c);//arrange
            int result = rect.GetVolume(); //act
            Assert.AreEqual(result, 12); //assert
        }
    }
}
