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
    [ScriptVersion(33)]
    public abstract class Tween : RecyclableObject, ITween
    {
        private TweenDirection _direction = TweenDirection.Forward;
        public TweenDirection direction { get { return _direction; }protected set { _direction = value; } }

        public event Action onCompelete;
        public float dur;
        private bool _autoRecyle = true;
        public bool autoRecyle { get { return _autoRecyle; }set { _autoRecyle = value; } }

        public LoopType loopType { get; set; }
        public abstract int loop { get; set; }
        public abstract ValueCurve curve { get; set; }
        public abstract void Run();
        public abstract void ReStart();
        public abstract void Rewind(float dur);
        public abstract void Complete(bool invoke);

        protected void InvokeCompelete()
        {
            if (onCompelete!=null)
            {
                onCompelete.Invoke();
            }
        }
        protected override void OnDataReset()
        {
            onCompelete = null;
        }
    }
}
