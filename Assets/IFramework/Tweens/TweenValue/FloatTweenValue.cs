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
    class FloatTweenValue : TweenValue<float>
    {
        protected override void MoveNext()
        {
            float dest = start.Lerp(end, convertPercent);
            current = pluginValue.Lerp(dest, deltaPercent);
        }

        protected override float Snap(float value)
        {
            return value.RoundToInt();
        }
    }

}
