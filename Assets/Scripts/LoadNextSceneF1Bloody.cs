﻿using UnityEngine;

public class LoadNextSceneF1Bloody : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (Time.timeSinceLevelLoad > 1f)
        {
            SceneLoadManager.Instance.LoaderAsync("ThirdFloor");
            GameManager.gameManager.Arrive1FloorBloody = true;
            Destroy(gameObject);
        }
    }
}
