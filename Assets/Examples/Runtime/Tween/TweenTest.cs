/*********************************************************************************
 *Author:         OnClick
 *Version:        0.0.1
 *UnityVersion:   2018.4.17f1
 *Date:           2020-04-04
 *Description:    Description
 *History:        2020-04-04--
*********************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IFramework;
using IFramework.Modules.Coroutine;
using IFramework.Tweens;
using UnityEngine.UI;

namespace IFramework_Demo
{
    public class TweenTest : Game
    {
        public Transform cube;
        public Text text;
        ITween tc;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                tc.Rewind(1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                tc.ReStart();
            }
            if (Input.GetKey(KeyCode.Q))
            {
                tc.Complete(false);
            }
        }


        public override void CreateModules()
        {

        }

        public override void Startup()
        {
            tc = cube.DoMove(new Vector3[] {
                Vector3.zero,
                Vector3.one,
                Vector3.one * 2,
                Vector3.one * 3,
                Vector3.one * 4,
                Vector3.one * 5,
                Vector3.one * 6,
            }, 10);



            //tc = cube.DoMove(cube.transform.position + Vector3.right * 5, 2, EnvironmentType.Ev1)
            //      .SetLoop(-1, LoopType.PingPong)
            //      .SetCurve(ValueCurve.scurve)
            //      .SetRecyle(false);
            //cube.DoMove(cube.transform.position + Vector3.up * 2, 2, EnvironmentType.Ev1)
            //         .SetLoop(-1, LoopType.PingPong)
            //         .SetCurve(ValueCurve.scurve)
            //         .SetRecyle(false);



            //cube.DoScale(Vector3.one * 2, 0.5f, EnvironmentType.Ev1)
            //    .SetLoop(3, LoopType.PingPong);
            //cube.DoRota(new Vector3(0, 360, 0), 5f, EnvironmentType.Ev1)
            //    .SetLoop(1, LoopType.PingPong)
            //    .SetCurve(ValueCurve.linecurve)
            //    .SetRecyle(false);
            //cube.GetComponent<Renderer>().material.DoColor(Color.cyan, 0.6f, EnvironmentType.Ev1)
            //     .SetLoop(-1, LoopType.PingPong)
            //     .SetRecyle(false);


            //text.DoText(0, 10, 2f, EnvironmentType.Ev1).SetLoop(-1, LoopType.PingPong);
            //text.DoText("123456789", 2)
            //        .SetLoop(-1, LoopType.PingPong)
            //        .SetCurve(ValueCurve.scurve);
        }
    }
}
