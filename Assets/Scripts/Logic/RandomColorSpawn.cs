using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class RandomColorSpawn : MonoBehaviour
{
    private void Awake()
    {
        GetComponentInChildren<SkinnedMeshRenderer>().material.color = UnityEngine.Random.ColorHSV(0, 240);
    }
}
