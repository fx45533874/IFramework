/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.2.146
 *UnityVersion:   2018.4.17f1
 *Date:           2020-04-02
 *Description:    IFramework
 *History:        2018.11--
*********************************************************************************/
using System;
using UnityEngine;
using UnityEngine.UI;
namespace IFramework.Tweens
{
    [ScriptVersion(20)]
    [VersionUpdate(20,"增加数组tween")]
    public static partial class TweenEx
    {
        public static ITween SetRecyle(this ITween tween, bool rec)
        {
            if (tween.recyled)
                throw new Exception("The Tween Has Been Recyled,Do not Do anything On it");
            tween.autoRecyle = rec;
            return tween;
        }
        public static ITween OnCompelete(this ITween tween, Action onCompelete)
        {
            if (tween.recyled)
                throw new Exception("The Tween Has Been Recyled,Do not Do anything On it");
            tween.onCompelete += onCompelete;
            return tween;
        }
        public static ITween SetLoop(this ITween tween, int loop, LoopType loopType)
        {
            if (tween.recyled)
                throw new Exception("The Tween Has Been Recyled,Do not Do anything On it");
            tween.loop = loop;
            tween.loopType = loopType;
            return tween;
        }
        public static ITween SetCurve(this ITween tween, ValueCurve curve)
        {
            if (tween.recyled)
                throw new Exception("The Tween Has Been Recyled,Do not Do anything On it");
            tween.curve = curve;
            return tween;
        }

        public static IArrayTween<T> AllocateArrayTween<T>(EnvironmentType env) where T : struct
        {
            return RecyclableObject.Allocate<ArrayTween<T>>(env);
        }
        public static ISingleTween<T> AllocateSingleTween<T>(EnvironmentType env) where T : struct
        {
            return RecyclableObject.Allocate<SingleTween<T>>(env);
        }


        public static ITween<T> DoGoto<T>(T start, T end, float dur, Func<T> getter, Action<T> setter, EnvironmentType env = EnvironmentType.Ev1) where T : struct
        {
            var tween = AllocateSingleTween<T>(env);
            tween.Config(start, end, dur, getter, setter);
            tween.Run();
            return tween;
        }
        public static ITween<T> DoGoto<T>(T[] array, float dur, Func<T> getter, Action<T> setter, EnvironmentType env = EnvironmentType.Ev1) where T : struct
        {
            var tween = AllocateArrayTween<T>(env);
            tween.Config(array, dur, getter, setter);
            tween.Run();
            return tween;
        }
    }
    public static partial class TweenEx
    {
        public static ITween<Vector3> DoMove(this Transform target, Vector3 end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.position, end, dur,
                    () => { return target.position; },
                    (value) => {
                        target.position = value;
                    }
                );
        }
        public static ITween<float> DoMoveX(this Transform target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.position.x, end, dur, () => { return target.position.x; }, (value) => {
                target.position = new Vector3(value, target.position.y, target.position.z);
            });
        }
        public static ITween<float> DoMoveY(this Transform target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.position.y, end, dur, () => { return target.position.y; },
                             (value) => {
                                 target.position = new Vector3(target.position.x, value, target.position.z);
                             });
        }
        public static ITween<float> DoMoveZ(this Transform target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.position.z, end, dur, () => { return target.position.z; }, (value) => {
                target.position = new Vector3(target.position.x, target.position.y, value);
            });
        }
        public static ITween<Vector3> DoLocalMove(this Transform target, Vector3 end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.localPosition, end, dur, () => { return target.localPosition; }, (value) => {
                target.localPosition = value;
            });
        }
        public static ITween<float> DoLocalMoveX(this Transform target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.localPosition.x, end, dur, () => { return target.localPosition.x; }, (value) => {
                target.localPosition = new Vector3(value, target.localPosition.y, target.localPosition.z);
            });
        }
        public static ITween<float> DoLocalMoveY(this Transform target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.localPosition.y, end, dur, () => { return target.localPosition.y; }, (value) => {
                target.localPosition = new Vector3(target.localPosition.x, value, target.localPosition.z);
            });
        }
        public static ITween<float> DoLocalMoveZ(this Transform target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.localPosition.z, end, dur, () => { return target.localPosition.z; }, (value) => {
                target.localPosition = new Vector3(target.localPosition.x, target.localPosition.y, value);
            });
        }


        public static ITween<Vector3> DoScale(this Transform target, Vector3 end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.localScale, end, dur, () => { return target.localScale; }, (value) => {
                target.localScale = value;
            });
        }
        public static ITween<float> DoScaleX(this Transform target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.localScale.x, end, dur, () => { return target.localScale.x; }, (value) => {
                target.localScale = new Vector3(value, target.localScale.y, target.localScale.z);
            });
        }
        public static ITween<float> DoScaleY(this Transform target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.localScale.y, end, dur, () => { return target.localScale.y; }, (value) => {
                target.localScale = new Vector3(target.localScale.x, value, target.localScale.z);
            });
        }
        public static ITween<float> DoScaleZ(this Transform target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.localScale.z, end, dur, () => { return target.localScale.z; }, (value) => {
                target.localScale = new Vector3(target.localScale.x, target.localScale.y, value);
            });
        }


        public static ITween<Quaternion> DoRota(this Transform target, Quaternion end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.rotation, end, dur, () => { return target.rotation; }, (value) => {
                target.rotation = value;
            });
        }
        public static ITween<Vector3> DoRota(this Transform target, Vector3 end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.rotation.eulerAngles, end, dur, () => { return target.rotation.eulerAngles; }, (value) => {
                target.rotation = Quaternion.Euler(value);
            });
        }
        public static ITween<Quaternion> DoRotaFast(this Transform target, Vector3 end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.rotation, Quaternion.Euler(end), dur, () => { return target.rotation; }, (value) => {
                target.rotation = value;
            });
        }

        public static ITween<Quaternion> DoLocalRota(this Transform target, Quaternion end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.localRotation, end, dur, () => { return target.localRotation; }, (value) => {
                target.localRotation = value;
            });
        }
        public static ITween<Quaternion> DoLocalRota(this Transform target, Vector3 end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.localRotation, Quaternion.Euler(end), dur, () => { return target.localRotation; }, (value) => {
                target.localRotation = value;
            });
        }


        public static ITween<Color> DoColor(this Material target, Color end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.color, end, dur, () => { return target.color; }, (value) => {
                target.color = value;
            });
        }
        public static ITween<Color> DoColor(this Graphic target, Color end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.color, end, dur, () => { return target.color; }, (value) => {
                target.color = value;
            });
        }
        public static ITween<Color> DoColor(this Light target, Color end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.color, end, dur, () => { return target.color; }, (value) => {
                target.color = value;
            });
        }
        public static ITween<Color> DoColor(this Camera target, Color end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.backgroundColor, end, dur, () => { return target.backgroundColor; }, (value) => {
                target.backgroundColor = value;
            });
        }


        public static ITween<float> DoAlpha(this Material target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.color.a, end, dur, () => { return target.color.a; }, (value) => {
                target.color = new Color(target.color.a, target.color.g, target.color.b, value);
            });
        }
        public static ITween<float> DoAlpha(this Graphic target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.color.a, end, dur, () => { return target.color.a; }, (value) => {
                target.color = new Color(target.color.a, target.color.g, target.color.b, value);
            });
        }
        public static ITween<float> DoAlpha(this Light target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.color.a, end, dur, () => { return target.color.a; }, (value) => {
                target.color = new Color(target.color.a, target.color.g, target.color.b, value);
            });
        }
        public static ITween<float> DoAlpha(this Camera target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.backgroundColor.a, end, dur, () => { return target.backgroundColor.a; }, (value) => {
                target.backgroundColor = new Color(target.backgroundColor.r, target.backgroundColor.g, target.backgroundColor.b, value);
            });
        }
        public static ITween<float> DoAlpha(this CanvasGroup target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.alpha, end, dur, () => { return target.alpha; }, (value) => {
                target.alpha = value;
            });
        }



        public static ITween<int> DoText(this Text target, int start, int end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(start, end, dur, () => {
                int value;
                if (int.TryParse(target.text, out value))
                    return value;
                return 0;
            }, (value) => {
                target.text = value.ToString();
            });
        }
        public static ITween<int> DoText(this Text target, string end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.text.Length, end.Length, dur, () => { return target.text.Length; }, (value) => {
                target.text = end.Substring(0, value);
            });
        }
        public static ITween<float> DoText(this Text target, float start, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(start, end, dur, () => {
                float value;
                if (float.TryParse(target.text, out value))
                    return value;
                return 0;
            }, (value) => {
                target.text = value.ToString();
            });
        }



        public static ITween<float> DoFillAmount(this Image target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.fillAmount, end, dur, () => { return target.fillAmount; }, (value) => {
                target.fillAmount = value;
            });
        }
        public static ITween<float> DoNormalizedPositionX(this ScrollRect target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.normalizedPosition.x, end, dur, () => { return target.normalizedPosition.x; }, (value) => {
                target.normalizedPosition = new Vector2(value, target.normalizedPosition.y);
            });
        }
        public static ITween<float> DoNormalizedPositionY(this ScrollRect target, float end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.normalizedPosition.y, end, dur, () => { return target.normalizedPosition.y; }, (value) => {
                target.normalizedPosition = new Vector2(target.normalizedPosition.x, value);
            });
        }




        public static ITween<bool> DoActive(this GameObject target, bool end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.activeSelf, end, dur, () => { return target.activeSelf; }, (value) => {
                target.SetActive(value);
            });
        }
        public static ITween<bool> DoEnable(this Behaviour target, bool end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.enabled, end, dur, () => { return target.enabled; }, (value) => {
                target.enabled = value;
            });
        }
        public static ITween<bool> DoToggle(this Toggle target, bool end, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(target.isOn, end, dur, () => { return target.isOn; }, (value) => {
                target.isOn = value;
            });
        }
    }
    public static partial class TweenEx
    {
        public static ITween<Vector3> DoMove(this Transform self,Vector3[] values,float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.position; }, (value) => { self.position = value; }, env);
        }
        public static ITween<float> DoMoveX(this Transform self, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.position.x; }, (value) => { self.position = new Vector3(value,self.position.y,self.position.z); }, env);
        }
        public static ITween<float> DoMoveY(this Transform self, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.position.y; }, (value) => { self.position = new Vector3( self.position.x, value, self.position.z); }, env);
        }
        public static ITween<float> DoMoveZ(this Transform self, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.position.z; }, (value) => { self.position = new Vector3(self.position.x, self.position.y, value); }, env);
        }


        public static ITween<Vector3> DoLocalMove(this Transform self, Vector3[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.localPosition; }, (value) => { self.localPosition = value; }, env);
        }
        public static ITween<float> DoLocalMoveX(this Transform self, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.localPosition.x; }, (value) => { self.localPosition = new Vector3(value, self.localPosition.y, self.localPosition.z); }, env);
        }
        public static ITween<float> DoLocalMoveY(this Transform self, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.localPosition.y; }, (value) => { self.localPosition = new Vector3(self.localPosition.x, value, self.localPosition.z); }, env);
        }
        public static ITween<float> DoLocalMoveZ(this Transform self, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.localPosition.z; }, (value) => { self.localPosition = new Vector3(self.localPosition.x, self.localPosition.y, value); }, env);
        }


        public static ITween<Vector3> DoScale(this Transform self, Vector3[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.localScale; }, (value) => { self.localScale = value; }, env);
        }
        public static ITween<float> DoScaleX(this Transform self, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.localScale.x; }, (value) => { self.localScale = new Vector3(value, self.localScale.y, self.localScale.z); }, env);
        }
        public static ITween<float> DoScaleY(this Transform self, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.localScale.y; }, (value) => { self.localScale = new Vector3(self.localScale.x, value, self.localScale.z); }, env);
        }
        public static ITween<float> DoScaleZ(this Transform self, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return self.localScale.z; }, (value) => { self.localScale = new Vector3(self.localScale.x, self.localScale.y, value); }, env);
        }

        public static ITween<Quaternion> DoRota(this Transform target, Quaternion[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.rotation; }, (value) => {
                target.rotation = value;
            });
        }
        public static ITween<Vector3> DoRota(this Transform target, Vector3[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.rotation.eulerAngles; }, (value) => {
                target.rotation = Quaternion.Euler(value);
            });
        }
        public static ITween<Quaternion> DoLocalRota(this Transform target, Quaternion[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.localRotation; }, (value) => {
                target.localRotation = value;
            });
        }


        public static ITween<Color> DoColor(this Material target, Color[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.color; }, (value) => {
                target.color = value;
            });
        }
        public static ITween<Color> DoColor(this Graphic target, Color[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.color; }, (value) => {
                target.color = value;
            });
        }
        public static ITween<Color> DoColor(this Light target, Color[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.color; }, (value) => {
                target.color = value;
            });
        }
        public static ITween<Color> DoColor(this Camera target, Color[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.backgroundColor; }, (value) => {
                target.backgroundColor = value;
            });
        }

        public static ITween<float> DoAlpha(this Material target, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.color.a; }, (value) => {
                target.color = new Color(target.color.a, target.color.g, target.color.b, value);
            });
        }
        public static ITween<float> DoAlpha(this Graphic target, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.color.a; }, (value) => {
                target.color = new Color(target.color.a, target.color.g, target.color.b, value);
            });
        }
        public static ITween<float> DoAlpha(this Light target, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.color.a; }, (value) => {
                target.color = new Color(target.color.a, target.color.g, target.color.b, value);
            });
        }
        public static ITween<float> DoAlpha(this Camera target, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.backgroundColor.a; }, (value) => {
                target.backgroundColor = new Color(target.backgroundColor.r, target.backgroundColor.g, target.backgroundColor.b, value);
            });
        }
        public static ITween<float> DoAlpha(this CanvasGroup target, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.alpha; }, (value) => {
                target.alpha = value;
            });
        }


        public static ITween<float> DoFillAmount(this Image target, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.fillAmount; }, (value) => {
                target.fillAmount = value;
            });
        }
        public static ITween<float> DoNormalizedPositionX(this ScrollRect target, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.normalizedPosition.x; }, (value) => {
                target.normalizedPosition = new Vector2(value, target.normalizedPosition.y);
            });
        }
        public static ITween<float> DoNormalizedPositionY(this ScrollRect target, float[] values, float dur, EnvironmentType env = EnvironmentType.Ev1)
        {
            return DoGoto(values, dur, () => { return target.normalizedPosition.y; }, (value) => {
                target.normalizedPosition = new Vector2(target.normalizedPosition.x, value);
            });
        }

    }

}
