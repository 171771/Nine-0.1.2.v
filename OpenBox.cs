using UnityEngine;
using System.Collections;

public class OpenBox : MonoBehaviour
{
    private Animator animator;

   // private Ray ray;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       // ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       
        if (Laser.hitInfo.collider.tag == "BOX" )
        {           
            animator.SetBool("IsOpen", true);
            ItemSystem.inventoryArray[1]--;
        }
        
    }
}
