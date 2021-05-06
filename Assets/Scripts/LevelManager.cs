using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int stage;

    void Awake()
    {
        GameObject[] manager = GameObject.FindGameObjectsWithTag("Manager");

        if (manager.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
