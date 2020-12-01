/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.146
 *UnityVersion:   2018.4.17f1
 *Date:           2020-04-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;

namespace IFramework.Tweens
{
    public interface ITween
    {
        bool recyled { get; }
        ValueCurve curve { get; set; }
        TweenDirection direction { get; }
        int loop { get; set; }
        bool autoRecyle { get; set; }
        LoopType loopType { get; set; }
        event Action onCompelete;

        void Complete(bool invoke);
        void ReStart();
        void Rewind(float dur);
        void Run();
    }
    public interface ITween<T> : ITween where T : struct
    {
        T cur { get; set; }
        T end { get; set; }
        T start { get; set; }
    }
}
