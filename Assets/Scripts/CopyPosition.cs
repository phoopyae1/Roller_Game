using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform  transtarget;

    // Update is called once per frame
    void Update()
    {
        transform.position=transtarget.position;
    }
}
