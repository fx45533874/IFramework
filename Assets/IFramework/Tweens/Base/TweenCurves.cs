/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.282
 *UnityVersion:   2018.4.24f1
 *Date:           2020-12-14
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System.Collections.Generic;

namespace IFramework.Tweens
{
	public static class TweenCurves
	{
        private static ValueCurve _hugeCCurve_rough = new ValueCurve(new List<Point2>()
        {
            new Point2(0,0),
            new Point2(0.2f,0.8f),
            new Point2(0.3f,0.9f),
            new Point2(0.5f,0.96f),
            new Point2(1,1)
        },0.02f);
        private static ValueCurve _largeCCurve_rough = new ValueCurve(new List<Point2>()
        {
            new Point2(0,0),
            new Point2(0.3f,0.9f),
            new Point2(1,1)
        },0.02f);
        private static ValueCurve _hugeCCurve = new ValueCurve(new List<Point2>()
        {
            new Point2(0,0),
            new Point2(0.2f,0.8f),
            new Point2(0.3f,0.9f),
            new Point2(0.5f,0.96f),
            new Point2(1,1)
        });
        private static ValueCurve _largeCCurve = new ValueCurve(new List<Point2>()
        {
            new Point2(0,0),
            new Point2(0.3f,0.9f),
            new Point2(1,1)
        });

        public static ValueCurve linecurve { get { return ValueCurve.linecurve; } }
        public static ValueCurve ccurve { get { return ValueCurve.ccurve; } }
        public static ValueCurve largeCCurve { get { return _largeCCurve; } }
        public static ValueCurve hugeCCurve { get { return _hugeCCurve; } }
        public static ValueCurve scurve { get { return ValueCurve.scurve; } }



        public static ValueCurve linecurve_rough { get { return ValueCurve.linecurve_rough; } }
        public static ValueCurve scurve_rough { get { return ValueCurve.scurve_rough; } }
        public static ValueCurve ccurve_rough { get { return ValueCurve.ccurve_rough; } }
        public static ValueCurve largeCCurve_rough { get { return _largeCCurve_rough; } }
        public static ValueCurve hugeCCurve_rough { get { return _hugeCCurve_rough; } }

    }
}
