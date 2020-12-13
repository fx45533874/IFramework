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

        private T _current;
        private T _end;
        private T _start;
        private IPercentConverter _converter = defaultConverter;
        private Action<T> setter;
        private Func<T> getter;
        private int _loop = 1;
        private T[] _array;
        private int _index;




        public T end { get { return _end; } set { _end = value; } }
        public T start { get { return _start; } set { _start = value; } }

        public T current
        {
            get { return _current; }
            set
            {
                _current = value;
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
        public override IPercentConverter converter
        {
            get { return _converter; }
            set
            {
                _converter = value;
                if (_tv != null && !_tv.recyled)
                {
                    _tv.converter = value;
                }
            }
        }

        public void Config(T[] array, float duration, Func<T> getter, Action<T> setter,bool snap)
        {
            if (array.Length <= 1) throw new Exception("array.lenght  must  >= 2");
            this.snap = snap;
            start = array[0];
            current = start;
            end = array[array.Length - 1];
            this.duration = duration;
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
            _current = _start = _end = default(T);
            duration = 0;
            _index = 0;

            _loop = 1;
            autoRecyle = true;
            if (_converter != defaultConverter)
            {
                _converter.Recyle();
                _converter = defaultConverter;
            }
            loopType = LoopType.ReStart;
            setter = null;
            getter = null;
        }


        private bool IsFinish()
        {
            if (recyled) return true;
            return _tv.compeleted;
        }
        private void OnLoopBegin()
        {
            if (recyled) return;
            _tv = TweenValue.Get<T>(env.envType);
            _tv.converter = converter;
            switch (direction)
            {
                case TweenDirection.Forward:
                    {
                        T _start = _array[_index];
                        T _end = _array[_index + 1];
                        var plugin = Allocate<RecyclablePlugin<T>>(env.envType);
                        plugin.Config(_start, _end, duration / (_array.Length - 1), getter, (value) => { current = value; }, snap);
                        _tv.Config(plugin, null);
                    }
                    break;
                case TweenDirection.Back:
                    {
                        T _end = _array[_index - 1];
                        T _start = _array[_index];
                        var plugin = Allocate<RecyclablePlugin<T>>(env.envType);
                        plugin.Config(_start, _end, duration / (_array.Length - 1), getter, (value) => { current = value; }, snap);

                        _tv.Config(plugin, null);
                    }
                    break;
                default:
                    break;
            }
            _tv.Run();
        }
        private void OnLoopCompele()
        {
            switch (loopType)
            {
                case LoopType.ReStart:
                    _index++;
                    _index = (_index) % (_array.Length - 1);
                    direction = TweenDirection.Forward;
                    break;
                case LoopType.PingPong:
                    switch (direction)
                    {
                        case TweenDirection.Forward:
                            _index++;
                            if (_index >= _array.Length - 1)
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
        }
        private void OnTweenCompelete()
        {
            InvokeCompelete();
            TryRecyleSelf();
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
                                _s
                                    .Until(IsFinish)
                                    .OnBegin(OnLoopBegin)
                                    .OnCompelete(OnLoopCompele);
                            });
                        }, _array.Length-1);
                    });
                }, loop)
                .OnCompelete(OnTweenCompelete)
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

        public override void Rewind(float duration,bool snap=false)
        {
            if (recyled) return;
            direction = TweenDirection.Forward;

            RecycleInner();

            _tv = TweenValue.Get<T>(env.envType);
            _tv.converter = converter;
            var plugin = Allocate<RecyclablePlugin<T>>(env.envType);
            plugin.Config(current, start, duration, getter,(value) => { current = value; },snap);
            _tv.Config(plugin, TryRecyleSelf);
            _tv.Run();
        }
        public override void Complete(bool invoke)
        {
            if (recyled) return;
            direction = TweenDirection.Forward;
            if (invoke) InvokeCompelete();
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
