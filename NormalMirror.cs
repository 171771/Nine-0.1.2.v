using UnityEngine;
using System.Collections;

public class NormalMirror : MonoBehaviour
{
    private Transform goTransform;
    private Vector3 inDirection;
    private RaycastHit hitInfo;
    private Laser laser;
   // private int j = Laser.i + 1;

    void Start()
    {
        goTransform = GetComponent<Transform>();
        laser = GetComponent<Laser>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Four))
        {
            Laser.ray = new Ray(goTransform.position, goTransform.forward);
            Debug.DrawRay(goTransform.position, goTransform.forward * 100, Color.magenta);

            if (Physics.Raycast(transform.position, transform.forward, out Laser.hitInfo, 50))
            {
                if (Laser.hitInfo.collider.tag == "MIRROR")
                {
                    inDirection = Vector3.Reflect(Laser.ray.direction, Laser.hitInfo.normal);
                    Laser.ray = new Ray(hitInfo.point, inDirection);

                    Debug.DrawRay(Laser.hitInfo.point, Laser.hitInfo.normal * 3, Color.blue);
                    Debug.DrawLine(Laser.hitInfo.point, inDirection * 100, Color.cyan);
                }
            }
        }
    }
}

