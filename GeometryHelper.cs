using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tap1
{
    public static class GeometryHelper
    {
        public static decimal Triangle(decimal aSide, decimal bSide, decimal cSide)
        {
            decimal semi_perimeter = (aSide + bSide + cSide) / 2;
            return (decimal)Math.Sqrt((double)(semi_perimeter * (semi_perimeter - aSide) * (semi_perimeter - bSide) * (semi_perimeter - cSide)));
        }

        public static decimal CirclePerimeter(decimal radius)
        {
            return (decimal)Math.PI * radius*2;
        }

        public static decimal QuadrilateralArea(decimal leftSide, decimal rightSide, decimal downSide, decimal upSide)
        {
            return leftSide * upSide;
           
        }

    }
}
