/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.146
 *UnityVersion:   2018.4.17f1
 *Date:           2020-04-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/

namespace IFramework.Tweens
{
    public class ValueCurveCoverter : RecyclableObject, IPercentConverter<ValueCurve>
    {
        private ValueCurve _curve = ValueCurve.linecurve;
        private static ValueCurveCoverter _default = new ValueCurveCoverter();
        public static ValueCurveCoverter Default { get { return _default; } }


        protected override void OnDataReset()
        {
            _curve = ValueCurve.linecurve;
        }


        public float Convert(float percent, float time, float duration)
        {
            var point = _curve.GetPercent(percent);
            return point.y;
        }
        public IPercentConverter Config(ValueCurve value)
        {
            this._curve = value;
            SetDataDirty();
            return this;
        }
    }
}
