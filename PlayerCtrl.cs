using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerCtrl : MonoBehaviour
{
    public int tongle = 0;
    public Vector3 localScale;

    Vector3 pos;
    Vector3 crouchT;
    Vector3 crouchF;

    public GameObject playerLaser;

    // Use this for initialization
    void Start()
    {        
        crouchT.Set(0, -0.4f, 0);
        crouchF.Set(0, 0.4f, 0);
        pos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            crouchPlayer();
        }
    }

    void crouchPlayer()
    {
        if (tongle == 0)
        {
            transform.localScale += crouchT;
            tongle = 1;
            OVRPlayerController.Damping += 0.5f;
            return;
        }

        if (tongle == 1)
        {
            pos.y += 0.5f;
            transform.localScale += crouchF;
            tongle = 0;
            OVRPlayerController.Damping -= 0.5f;
            return;
        }
    }
}