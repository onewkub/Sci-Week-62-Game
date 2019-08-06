﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneEventFirstFloor : MonoBehaviour
{
    public static SceneEventFirstFloor Instance { get; set; }
    public bool pass = false;
    public GameObject OpenTrigger;
    public GameObject CloseTrigger;
    public GameObject InsideTrigger;

    private void Start()
    {
        OpenTrigger.SetActive(false);
        CloseTrigger.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        pass = true;
        OpenTrigger.SetActive(true);
        CloseTrigger.SetActive(true);
        InsideTrigger.SetActive(false);
    }
}
