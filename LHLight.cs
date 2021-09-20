using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHLight : MonoBehaviour
{
    [SerializeField] GameObject LHObject;
    [SerializeField] float Speed = 0.1f;
    // Update is called once per frame
    // Rotate light house light
    void Update()
    {
        LHObject.transform.Rotate(0.0f, Speed, 0.0f, Space.World);
    }
}
