using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 获取点集自由外接多边型
{
    class code
    {
        private List<point3> oriPoints;
        private List<point3> resPoints;
        private double userSet;
        public code(List<point3> points, double userSet)
        {
            this.oriPoints = points;
            this.userSet = userSet;
            resPoints = new List<point3>();
        }

        public void getPolygon()
        {
            int s = int.MaxValue;
            double minX=double.MaxValue;
            //拿到X轴最小的点ID
            for (int i = 0; i < oriPoints.Count; i++)
            {
                s = minX < oriPoints[i].X ? oriPoints[i].id : s;
            }
            resPoints.Add(oriPoints[s]);

        }
        /// <summary>
        /// 返回一个值，表示射线p1p2与x轴正方向的夹角角度
        /// 这个角度是逆时针增长的
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        double getSlopeValue(point2 p1, point2 p2)
        {
            double caX = p2.X - p1.X;
            double caY = p2.Y - p1.Y;
            double slopValue = Math.Atan(caY/caX) * 180 / Math.PI;
            if (caX > 0 && caY >= 0) { return slopValue; }//0-89.9999999
            else if (caX < 0 && caY >= 0) { return 180 + slopValue; }//90.000000001-180
            else if (caX < 0 && caY <= 0) { return 180 + slopValue; }//180-269.999999
            else if (caX > 0 && caY < 0) { return 360 + slopValue; }//270.0000001-359.99999
            else if (caX == 0 && caY > 0) { return 90; }//
            else if (caX == 0 && caY < 0) { return 270; }//
            else { return 0; } //cax = 0 , cay = 0  
        }
    }
}
