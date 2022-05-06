namespace figAreaCalc
{
    public static class AreaCalc
    {
        public static double GetArea<T>(T obj) where T : iFigure
        {
            double area = 0;
            if (obj == null) return 0;
            area=obj.GetArea();
            return area;
        }
    }
}