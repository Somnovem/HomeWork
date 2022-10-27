using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace ClassWork
{
    public class Point : ISerializable
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public Point() { }

        private void OnSerializing(StreamingContext context)
        {
            X = X + 200;
            Y = Y + 200;
        }


        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            X-= 200;
            Y-= 200;
        }


        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator ++(Point temp1)
        {
            temp1.X++;
            temp1.Y++;
            return temp1;
        }
        public override string ToString()
        {
            return $"X = {X}\tY = {Y}";
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Moon", X*10 -15);
            info.AddValue("Sun", Y * 100 + 25);
        }

        Point(SerializationInfo info, StreamingContext context)
        {
        X = (info.GetInt32("Moon") + 15 )/ 10;
        Y = (info.GetInt32("Sun") - 25)/ 10;
        }


        public static Point operator -(Point p)
        {
        return new Point(-p.X, -p.Y);
        }
        public static Point operator -(Point p1,Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }
        public static Point operator *(Point p1, int n)
        {
            return new Point(p1.X *n, p1.Y *n);
        }
        public static Point operator *(int n, Point p1)
        {
            return new Point(p1.X * n, p1.Y * n);
        }
        public static bool operator ==(Point p1, Point p2)
        {
        return p1.X == p2.X && p1.Y == p2.Y;  
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y;
        }
        public static bool operator true(Point p1)
        {
        return p1.X !=0 || p1.Y !=0;
        }
        public static bool operator false(Point p1)
        {
            return p1.X == 0 || p1.Y == 0;
        }
        public  static implicit /*explicit*/ operator float (Point p)
        { 
            return (float)Math.Sqrt(Math.Pow(p.X,2) + Math.Pow(p.Y,2));
        }
    }

    class MyArray
    {
        int[] arr;
        int[,] arr2;
        public MyArray(int size)
        {
            this.arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = new Random().Next(1, 10);
            }
            arr2 = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr2[i,j] = new Random().Next(1, 10);
                }
            }
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i].ToString() + " ";
            }
            return res;
        }
        public int this[int ind]
        {
            get { return arr[ind]; }
            set { arr[ind] = value; }
        }
        public int this[int i,int j]
        {
            get { return arr2[i,j]; }
            set { arr2[i,j] = value; }
        }
    }
}

