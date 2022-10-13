using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Color { }
    interface GeometricalShape
    {
        int X { get; set; }
        int Y { get; set; }
        ConsoleColor Color { get; set; }
        double getArea();
    }
    class Shape
    {
        static public List<int> HeightPool = new List<int> { };
    }
    interface IDrawable
    {
        void Draw();
    }

    interface RoundShapes: GeometricalShape, IDrawable
    {
        int Radius { get; set; }
    }

    class Circle :Shape, RoundShapes
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; }
        public int Radius { get; set; }

        public Circle()
        {
        Random random = new Random();
            X = random.Next(1, 20);
            bool gotHeight = false;
            while (!gotHeight)
            {
                Y = random.Next(5, 20);
                if (!HeightPool.Contains(Y))
                {
                    HeightPool.Add(Y);
                    gotHeight = true;
                }
            }

            Radius = random.Next(1, 20);
            Color = (ConsoleColor)(random.Next(1, 16));
        }
        public virtual double getArea()
        {
            return 3.1415 * Math.Pow((double)Radius,2);
        }
        public virtual void Draw()
        {
            Console.SetCursorPosition(X, Y);
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(Color + " Circle on (" + X + ";" + Y + ") with radius " + Radius);
            Console.ForegroundColor = temp;
        }
    }
    class Elipse : Circle
    {
        public int SecondRadius { get; set; }
        public Elipse()
        {
            Random random = new Random();
            SecondRadius = random.Next(1, 20);
        }
        public override double getArea()
        {
            return 3.1415 * (double)Radius * (double)SecondRadius;
        }
        public override void Draw()
        {
            Console.SetCursorPosition(X, Y);
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(Color + " Elipse on (" + X + ";" + Y + ") with radiuses " + Radius + " and " + SecondRadius);
            Console.ForegroundColor = temp;
        }
    }

    interface AngledShapes : GeometricalShape, IDrawable
    {
    int Side { get; set; }
    }
    class Triangle : Shape, AngledShapes
    {
        public Triangle()
        {
            Random random = new Random();
            Side = random.Next(1, 20);
            SecondSide = random.Next(1, 20);
            ThirdSide = random.Next(1, 20);
            Color = (ConsoleColor)(random.Next(1, 16));
            X = random.Next(1, 20);
            bool gotHeight = false;
            while (!gotHeight)
            {
                Y = random.Next(5, 20);
                if (!HeightPool.Contains(Y))
                {
                    HeightPool.Add(Y);
                    gotHeight = true;
                }
            }
        }
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; }
        public int Side { get; set; }
        public int SecondSide { get; set; }
        public int ThirdSide { get; set; }
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(Color + " Triangle on (" + X + ";" + Y + $") with sides ({Side};{SecondSide};{ThirdSide})");
            Console.ForegroundColor = temp;
        }

        public double getArea()
        {
            double halfPerimeter = ((double)Side + (double)SecondSide + (double)ThirdSide) / 2;
            double res = halfPerimeter * (halfPerimeter - Side) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide);
            return Math.Sqrt(res);
        }
    }
    class Square : Shape, AngledShapes
    {
        public Square()
        {
            Random random = new Random();
            Side = random.Next(1, 20);
            X = random.Next(1, 20);
            bool gotHeight = false;
            while (!gotHeight)
            {
                Y = random.Next(5, 20);
                if (!HeightPool.Contains(Y))
                {
                    HeightPool.Add(Y);
                    gotHeight = true;
                }
            }
            Color = (ConsoleColor)(random.Next(1, 16));
        }
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; }
        public int Side { get; set; }
        public virtual void Draw()
        {
            Console.SetCursorPosition(X, Y);
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(Color + " Square on (" + X + ";" + Y + $") with side {Side}");
            Console.ForegroundColor = temp;
        }
        public virtual double getArea()
        {
            return Math.Pow(Side,2);
        }
    }
    class Rectangle : Square
    {
    public int SecondSide { get; set; }
        public Rectangle()
        {
            Random random = new Random();
            SecondSide = random.Next(1, 20);
            Color = (ConsoleColor)(random.Next(1, 16));
        }
        public override double getArea()
        {
            return Side * SecondSide;
        }
        public override void Draw()
        {
            Console.SetCursorPosition(X, Y);
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(Color + " Rectangle on (" + X + ";" + Y + $") with sides ({Side};{SecondSide})");
            Console.ForegroundColor = temp;
        }
    }
    class Rhombus: Square
    {
        public Rhombus()
        {
            Random random = new Random();
            Color = (ConsoleColor)(random.Next(1, 16));
            Angle = random.Next(1, 90);
        }
        public int Angle { get; set; }
        public override double getArea()
        {
            double angle = (Angle * (Math.PI)) / 180;
            return Math.Pow(Side,2) * Math.Sin(angle);
        }
        public override void Draw()
        {
            Console.WriteLine(Color + " Rhombus on (" + X + ";" + Y + $") with side {Side} and lesser angle {Angle}");
        }
    }
    class Pentagon:Square
    {
        public Pentagon()
        {
            Random random = new Random();
            Color = (ConsoleColor)(random.Next(1, 16));
        }
        public override double getArea()
        {
            return Math.Pow(Side,2) * 1.72048;
        }
        public override void Draw()
        {
            Console.SetCursorPosition(X, Y);
            var temp = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(Color + " Pentagon on (" + X + ";" + Y + $") with side {Side}");
            Console.ForegroundColor = temp;
        }
    }
    class GeometricalShapeCollection: IEnumerable
    {
    List<GeometricalShape> geometricalShapes = new List<GeometricalShape>();
         void Draw()
        {
            foreach (var item in geometricalShapes)
            {
                (item as IDrawable).Draw();
            }
            Console.SetCursorPosition(40, 43);
            Console.ReadKey();
        }
         void Add()
        {
            Console.SetCursorPosition(40, 1);
            Console.WriteLine("Choose shape:");
            GeometricalShape newShape = null;
            int c = PV111_CSharp.ConsoleMenu.SelectVertical(PV111_CSharp.HPosition.Center, PV111_CSharp.VPosition.Center, PV111_CSharp.HorizontalAlignment.Center, "Circle", "Elipse", "Triangle", "Square", "Rectangle", "Rhombus", "Pentagon", "Exit");
            Console.Clear();
            switch (c)
            {
                case 0:
                    newShape = new Circle();
                    break;
                case 1:
                    newShape = new Elipse();
                    break;
                case 2:
                    newShape = new Triangle();
                    break;
                case 3:
                    newShape = new Square();
                    break;
                case 4:
                    newShape = new Rectangle();
                    break;
                case 5:
                    newShape = new Rhombus();
                    break;
                case 6:
                    newShape = new Pentagon();
                    break;
                default:
                    break;
            }
            if (newShape == null)
            {
                return;
            }
            string[] colors = Enum.GetNames(typeof(ConsoleColor));
            Console.SetCursorPosition(40, 1);
            Console.WriteLine("Choose color:");
            c = PV111_CSharp.ConsoleMenu.SelectVertical(PV111_CSharp.HPosition.Center, PV111_CSharp.VPosition.Center, PV111_CSharp.HorizontalAlignment.Center, colors);
            Console.Clear();
            newShape.Color = (ConsoleColor)c;
            geometricalShapes.Add(newShape);
        }
        void Delete()
        {
            List<string> names = new List<string> { };
            foreach (var item in geometricalShapes)
            {
                names.Add(item.GetType().Name + "(" + item.X + ";" + item.Y + ")");
            }
            names.Add("Exit");
            int c = PV111_CSharp.ConsoleMenu.SelectVertical(PV111_CSharp.HPosition.Center, PV111_CSharp.VPosition.Center, PV111_CSharp.HorizontalAlignment.Center, names);
            if (c == names.Count-1)
            {
                return;
            }
            geometricalShapes.RemoveAt(c);
        }
        public void Menu()
        {
            Console.SetWindowSize(170, 45);
            int c = 0;
            while (c < 3)
            {
                Console.Clear();
                c = PV111_CSharp.ConsoleMenu.SelectVertical(PV111_CSharp.HPosition.Left, PV111_CSharp.VPosition.Center, PV111_CSharp.HorizontalAlignment.Center, "Add a shape", "Delete a shape", "Print all shapes", "Exit");
                Console.Clear();
                switch (c)
                {
                    case 0:
                        Add();
                        break;
                    case 1:
                        Delete();
                        break;
                    case 2:
                        Draw();
                        break;
                    default:
                        break;
                }
            }
            
        }

        public IEnumerator GetEnumerator()
        {
            return geometricalShapes.GetEnumerator();
        }
    }
}
