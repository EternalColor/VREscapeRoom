using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YannickUtlities.Scripts;

namespace UnityUtillities
{
    public class Debugger : Singleton<Debugger>
    {
        public static void DebugSimple<T>(T data)
        {
            Debug.Log(data);
        }
        public static void DebugSimple<T,T1>(T data,T1 data2)
        {
            Debug.LogFormat($"Daten mit DebbuggerSimple {0} und {1}", data, data2);
        }
        
    }
}