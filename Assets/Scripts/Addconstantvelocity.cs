using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addconstantvelocity : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 v3Force;

    

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity+=v3Force;
    }
}
