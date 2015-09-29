using System;

class PointClass
{
    static void Main()
    {
        Point a = new Point() { X = 20, Y = 17 };
        Point b = new Point() { X = 38, Y = 59 };
        Point c = new Point() { X = 19, Y = 30 };
        Point d = new Point() { X = 14, Y = 13 };
        Point e = new Point() { X = 15, Y = 4 };
        a.PrintPoint();
        b.PrintPoint();
        c.PrintPoint();
        d.PrintPoint();
        e.PrintPoint();
    }
}
