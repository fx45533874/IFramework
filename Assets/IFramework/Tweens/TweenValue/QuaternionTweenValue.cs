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
    class QuaternionTweenValue : TweenValue<Quaternion>
    {
        protected override void MoveNext()
        {
            Quaternion dest = Quaternion.Lerp(start, end, convertPercent);
            current = Quaternion.Lerp(pluginValue, dest, deltaPercent);
        }
        protected override Quaternion Snap(Quaternion value)
        {
            value.x = value.x.RoundToInt();
            value.y = value.y.RoundToInt();
            value.z = value.z.RoundToInt();
            value.z = value.z.RoundToInt();
            return value;
        }
    }

}
