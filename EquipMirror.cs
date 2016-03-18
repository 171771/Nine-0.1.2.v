using UnityEngine;
using System.Collections;

public class EquipMirror : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    static public bool isEquip = false;
    private GameObject childobj1;
    private GameObject childobj2;

    // Use this for initialization
    void Start()
    {
        childobj1 = GameObject.Find("SupportMirror_1");
        childobj2 = GameObject.Find("SupportMirror_2");
        childobj1.SetActive(false);
        childobj2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Circle"))
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            hit = new RaycastHit();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10))
            {
                // box support_1 equip
                if (hit.collider.name == "BoxSupport_1" && SelectMirror.mirrorCount > 0)
                {
                    Debug.Log("wkjeflq");
                    SelectMirror.mirrorCount--;
                    childobj1.SetActive(true);
                }
                // box support_2 equip
                else if (hit.collider.name == "BoxSupport_2" && SelectMirror.mirrorCount > 0)
                {
                    SelectMirror.mirrorCount--;
                    childobj2.SetActive(true);
                }
            }
        }
    }
}