using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float speed = 2f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector3 newPos = new UnityEngine.Vector3(target.position.x, target.position.y, - 10f);
        transform.position = UnityEngine.Vector3.Lerp(transform.position, newPos, speed);
    }
}
