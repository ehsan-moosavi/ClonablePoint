using System;
using System.Collections.Generic;
using System.Text;

namespace ClonablePoint
{
    class Point :ICloneable
    {
        public PointDescription desc = new PointDescription();
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }
        public Point(int XPos, int YPos) { X = XPos; Y = YPos; }
        public Point(){}
        public override string ToString() => $"x ={X} ,y={Y} name={desc.PetName} Id={desc.PointID} ";

        public object Clone() {
            Point newPoint = new Point();
            newPoint.X = this.X;
            newPoint.Y = this.Y;
            PointDescription currdesc = new PointDescription();
            newPoint.desc.PetName = this.desc.PetName;
            newPoint.desc = currdesc;
            return newPoint;
        }
      
    }
}
