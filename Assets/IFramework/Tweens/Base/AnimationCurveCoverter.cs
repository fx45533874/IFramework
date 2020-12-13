/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.146
 *UnityVersion:   2018.4.17f1
 *Date:           2020-04-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/

using UnityEngine;

namespace IFramework.Tweens
{
    public class AnimationCurveCoverter : RecyclableObject, IPercentConverter<AnimationCurve>
    {
        private AnimationCurve _curve= null;
        protected override void OnDataReset()
        {
            _curve = null;
        }

        public float Convert(float percent, float time, float duration)
        {
            return _curve.Evaluate(percent);
        }
        public IPercentConverter Config(AnimationCurve value)
        {
            this._curve = value;
            SetDataDirty();
            return this;
        }
    }
}
