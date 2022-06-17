using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    public void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }
}
