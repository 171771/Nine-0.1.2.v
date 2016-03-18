using UnityEngine;
using System.Collections;

public class PickUpItem : MonoBehaviour
{

    RaycastHit hitInfo;
    Ray ray;
    bool hit;
    bool isPick = false;
    
    // Update is called once per frame
    void Update()
    {
        hitInfo = new RaycastHit();
        hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (OVRInput.GetUp(OVRInput.RawButton.B))
        {
            if (hitInfo.collider.tag == "MIRROR")
            {
                Debug.Log("hihi");
                isPick = true;
                ItemSystem.inventoryArray[0]++;
                Destroy(hitInfo.transform.gameObject);
            }
            else if (hitInfo.transform.gameObject.tag == "KEY")
            {
                isPick = true;
                ItemSystem.inventoryArray[1]++;
                Destroy(hitInfo.transform.gameObject);
            }
        }
    }
}


