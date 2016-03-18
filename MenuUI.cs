using UnityEngine;
using System.Collections;

public class MenuUI : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    public GameObject UI;

    void Start()
    {
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Start))
            {                
                UI.SetActive(true);
            }
        }
    
}
