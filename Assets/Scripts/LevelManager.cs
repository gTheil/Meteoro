using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int stage;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
