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
    class ColorTweenValue : TweenValue<Color>
    {
        protected override void MoveNext()
        {
            Color dest = Color.Lerp(start, end, convertPercent);
            current = Color.Lerp(pluginValue, dest, deltaPercent);
        }
        protected override Color Snap(Color value)
        {
            value.a = value.a.RoundToInt();
            value.r = value.r.RoundToInt();
            value.g = value.g.RoundToInt();
            value.b = value.b.RoundToInt();
            return value;
        }
    }

}
