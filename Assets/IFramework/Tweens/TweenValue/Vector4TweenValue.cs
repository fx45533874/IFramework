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
    class Vector4TweenValue : TweenValue<Vector4>
    {
        protected override void MoveNext()
        {
            Vector4 dest = Vector4.Lerp(start, end, convertPercent);
            current = Vector4.Lerp(pluginValue, dest, deltaPercent);
        }
        protected override Vector4 Snap(Vector4 value)
        {
            value.x = value.x.RoundToInt();
            value.y = value.y.RoundToInt();
            value.z = value.z.RoundToInt();
            value.w = value.w.RoundToInt();
            return value;
        }
    }

}
