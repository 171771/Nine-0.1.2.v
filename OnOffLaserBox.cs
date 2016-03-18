using UnityEngine;
using System.Collections;

public class OnOffLaserBox : MonoBehaviour {

    public GameObject Laser;
    RaycastHit hit;
    Ray ray;

	// Use this for initialization
	void Start () {
        Laser.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            hit = new RaycastHit();

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 10))
            {
                Laser.SetActive(true);               
            }
        }
        if (OVRInput.GetUp(OVRInput.RawButton.X))
        {
            Laser.SetActive(false);
        }
    }
}
