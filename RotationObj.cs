using UnityEngine;
using System.Collections;

public class RotationObj : MonoBehaviour {

    private Ray ray;
    private RaycastHit hitInfo;
    public float turnSpeed = 50f;
    public GameObject RotationMirror;

    // Use this for initialization
    void Start()
    {
    }

    void Update()
    {
        hitInfo = new RaycastHit();

        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        // rotation up
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (hitInfo.collider.tag == "SUPPORT")
            {
                Debug.Log("171771");
                RotationMirror = hitInfo.transform.gameObject;
                RotationMirror.transform.Rotate(new Vector3(0, -Input.GetAxis("Oculus_GearVR_LIndexTrigger"), 0));
            }
        }
        // rotation down
        else if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            if (hitInfo.collider.tag == "SUPPORT")
            {
                RotationMirror = hitInfo.transform.gameObject;
                RotationMirror.transform.Rotate(new Vector3(0, -Input.GetAxis("Oculus_GearVR_RIndexTrigger"), 0));
            }
        }
    }
}

