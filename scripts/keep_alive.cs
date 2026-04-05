using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keep_alive : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
