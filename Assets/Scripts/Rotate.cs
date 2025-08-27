using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Rotate : MonoBehaviour
{
    public Vector3 rot;

    void Update()
    {
        transform.Rotate(rot * Time.deltaTime);
    }
}
