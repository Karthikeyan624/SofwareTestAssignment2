// Author : Karthikeyan Shanmugam
// Student Number : 8740880
// Class : Cad Section1
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    // Rectangle class for get and set method
    public class Rectangle
    {
        private int length;
        private int width;
        private int height;
        public Rectangle()
        {
            length = 1;
            width = 1;
            height = 1;
        }
        public Rectangle(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetHeight()
        {
            return height;
        }
        public int SetHeight(int height)
        {
            this.height = height;
            return this.height;
        }
        public int GetVolume()
        {
            return (length * width * height);
        }
    }
}
