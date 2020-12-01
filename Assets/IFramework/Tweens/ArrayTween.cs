/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.146
 *UnityVersion:   2018.4.17f1
 *Date:           2020-04-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using IFramework.NodeAction;
using System;

namespace IFramework.Tweens
{
    public class ArrayTween<T> : Tween, IArrayTween<T> where T: struct 
    {
        private TweenValue<T> _tv;
        private IRepeatNode _repeat;
        private ISequenceNode _seq;

        private T _cur;
        private T _end;
        private T _start;
        private ValueCurve _curve = ValueCurve.linecurve;
        private Action<T> setter;
        private Func<T> getter;
        private int _loop = 1;
        private T[] _array;
        private int _index;
        public T end { get { return _end; } set { _end = value; } }
        public T start { get { return _start; } set { _start = value; } }

        public T cur
        {
            get { return _cur; }
            set
            {
                _cur = value;
                if (setter != null)
                {
                    setter(value);
                }
            }
        }
        public override int loop
        {
            get
            {
                if (_repeat != null && !_repeat.recyled)
                    _loop = _repeat.repeat;
                return _loop;
            }
            set
            {
                _loop = value;
                if (_repeat != null && !_repeat.recyled)
                {
                    _repeat.repeat = value;
                }
            }
        }
        public override ValueCurve curve
        {
            get { return _curve; }
            set
            {
                _curve = value;
                if (_tv != null && !_tv.recyled)
                {
                    _tv.curve = value;
                }
            }
        }

        public void Config(T[] array, float dur, Func<T> getter, Action<T> setter)
        {
            if (array.Length <= 1) throw new Exception("array.lenght  must  >= 2");
            start = array[0];
            cur = start;
            end = array[array.Length - 1];
            this.dur = dur;
            this.getter = getter;
            this.setter = setter;
            this._array = array;
            _index = 0;
            SetDataDirty();
        }
        protected override void OnDataReset()
        {
            base.OnDataReset();
            direction = TweenDirection.Forward;
            RecycleInner();
            _array = null;
            _cur = _start = _end = default(T);
            dur = 0;
            _index = 0;

            _loop = 1;
            autoRecyle = true;
            _curve = ValueCurve.linecurve;
            loopType = LoopType.ReStart;
            setter = null;
            getter = null;
        }
        public override void Run()
        {
            if (recyled) return;
            _seq = this.Sequence(env.envType)
                .Repeat((r) =>
                {
                    _repeat = r.Sequence((s) =>
                    {
                        s.Repeat((_r) =>
                        {
                            _r.Sequence((_s) =>
                            {
                                _s.Until(() =>
                                {
                                    if (recyled) return true;
                                    return _tv.compeleted;
                                })
                                .OnBegin(() =>
                                {
                                    if (recyled) return;
                                    _tv = TweenValue.Get<T>(env.envType);
                                    _tv.curve = curve;
                                    switch (direction)
                                    {
                                        case TweenDirection.Forward:
                                            {
                                                T _start = _array[_index];
                                                T _end = _array[_index + 1];
                                                _tv.Config(_start, _end, dur/ (_array.Length - 1), getter, (value) => { cur = value; }, null);
                                            }
                                            break;
                                        case TweenDirection.Back:
                                            {
                                                T _end = _array[_index-1];
                                                T _start = _array[_index];
                                                _tv.Config(_start, _end, dur / (_array.Length-1), getter, (value) => { cur = value; }, null);
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                    _tv.Run();
                                })
                                .OnCompelete(() =>
                                {
                                    switch (loopType)
                                    {
                                        case LoopType.ReStart:
                                            _index++;
                                            _index = (_index) % (_array.Length-1);
                                            direction = TweenDirection.Forward;
                                            break;
                                        case LoopType.PingPong:
                                            switch (direction)
                                            {
                                                case TweenDirection.Forward:
                                                    _index++;
                                                    if (_index >= _array.Length-1)
                                                    {
                                                        direction = TweenDirection.Back;
                                                    }
                                                    break;
                                                case TweenDirection.Back:
                                                    _index--;
                                                    if (_index <= 0)
                                                    {
                                                        direction = TweenDirection.Forward;
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                    if (_tv != null)
                                    {
                                        _tv.Recyle();
                                        _tv = null;
                                    }
                                });


                            });
                        }, _array.Length-1);
                    });
                }, loop)
                .OnCompelete(() =>
                {
                    InvokeCompelete();
                    TryRecyleSelf();
                })
                .Run();
        }



        public override void ReStart()
        {
            if (recyled) return;
            _index = 0;
            direction = TweenDirection.Forward;
            RecycleInner();
            Run();
        }

        public override void Rewind(float dur)
        {
            if (recyled) return;
            direction = TweenDirection.Forward;

            RecycleInner();

            _tv = TweenValue.Get<T>(env.envType);
            _tv.curve = curve;
            _tv.Config(cur, start, dur, getter,
                (value) => { cur = value; },
                () => {
                    TryRecyleSelf();
                });
            _tv.Run();
        }
        public override void Complete(bool invoke)
        {
            if (recyled) return;
            direction = TweenDirection.Forward;
            if (invoke)
            {
                InvokeCompelete();
            }
            TryRecyleSelf();
        }

        private void TryRecyleSelf()
        {
            RecycleInner();
            if (autoRecyle)
            {
                Recyle();
            }
        }
        private void RecycleInner()
        {
            if (_tv != null && !_tv.recyled)
            {
                _tv.Recyle();
                _tv = null;
            }
            if (_seq != null && !_seq.recyled)
            {
                _seq.Recyle();
                _seq = null;
            }
            if (_repeat != null && !_repeat.recyled)
            {
                _repeat.Recyle();
                _repeat = null;
            }
        }

    }
}
