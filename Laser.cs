using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]

public class Laser : MonoBehaviour
{
    static public LineRenderer lr;
    static public RaycastHit hitInfo;
    static public Ray ray;
    static public int i = 1;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        lr.SetPosition(i, new Vector3(0, 0, 0));

        // press button Y(triangle)
        if (OVRInput.Get(OVRInput.Button.Four))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hitInfo))
            {
                if (hitInfo.collider)
                {
                    //Debug.Log(hitInfo.collider.tag);
                    lr.SetPosition(i, new Vector3(0, 0, hitInfo.distance));
                }
            }
        }
        // unpress button Y(triangle)
        else if (OVRInput.GetUp(OVRInput.Button.Four))
        {
            lr.SetPosition(i, new Vector3(0, 0, 0));
        }
    }
}