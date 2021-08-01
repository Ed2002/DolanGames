using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] Transform playerCamera = null;
    [SerializeField] protected Transform trackingTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(trackingTarget.position.x,
         trackingTarget.position.y, transform.position.z);
    }
}
