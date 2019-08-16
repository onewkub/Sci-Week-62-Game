﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestAndRotate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AutoPlay.Instance.itTrigger();
            PlayerMovement.Instance.RotateToTarget(transform.rotation);
        }
    }
}
