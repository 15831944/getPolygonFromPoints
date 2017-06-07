using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 获取点集自由外接多边型
{
    class point2
    {
        public point2() { }
        public point2(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public int id;
        public double X;
        public double Y;
    }
    class point3:point2
    {
        public point3() { }
        public point3(point2 a2dPoint,double z)
        {
            this.X = a2dPoint.X;
            this.Y = a2dPoint.Y;
            this.id = a2dPoint.id;
            this.Z = z;
        }
        public point3(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double Z;
    }
}
