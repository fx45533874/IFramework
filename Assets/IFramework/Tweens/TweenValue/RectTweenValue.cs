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
    class RectTweenValue : TweenValue<Rect>
    {
        protected override void MoveNext()
        {
            Rect dest = start.Lerp(start, end, convertPercent);
            current = start.Lerp(pluginValue, dest, deltaPercent);
        }
        protected override Rect Snap(Rect value)
        {
            value.x = value.x.RoundToInt();
            value.y = value.y.RoundToInt();
            value.width = value.width.RoundToInt();
            value.height = value.height.RoundToInt();
            return value;
        }
    }

}
