using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;



public class OpenDoorTrigger : MonoBehaviour
{
    // Keep track of the animator
    private Animator anim;
    // Keep track of animator state
    //int[] transitioning = new int[4];

    bool doorIsMoving = false;


    // Start is called before the first frame update
    void Start()
    {
        // Detect when the door is clicked on by the player
        gameObject.AddListener(EventTriggerType.PointerDown, UpdateState);
        anim = this.GetComponent<Animator>();
        /*
        anim.SetBool("OpenIt", false);
        transitioning[0] = Animator.StringToHash("RightOpening");
        transitioning[1] = Animator.StringToHash("LeftOpening");
        transitioning[2] = Animator.StringToHash("RightClosing");
        transitioning[3] = Animator.StringToHash("LeftClosing");
        */

        // gameObject.AddListener(EventTriggerType.PointerUp, () => SetClicked(false));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    //  Returns true if the door is not currently changing state
    private bool validateState()
    {
        Debug.Log("VALIDATING");
        for(int i = 0; i < transitioning.Length; i++)
        {
            Debug.Log(transitioning.GetValue(i));
        }
        Debug.Log(anim.GetCurrentAnimatorStateInfo(0).shortNameHash);
        Debug.Log(System.Array.IndexOf(transitioning, anim.GetCurrentAnimatorStateInfo(0).shortNameHash) >= 0);
        return !(System.Array.IndexOf(transitioning, anim.GetCurrentAnimatorStateInfo(0).shortNameHash) >= 0);
    }
    */
    private void UpdateState() {

        if (!doorIsMoving)
        {
            anim.SetTrigger("Open");
        }        
        
        ////anim.SetBool("OpenIt", false);
        ////Debug.Log(anim.GetBool("OpenIt"));
        ////anim.SetLayerWeight(anim.GetLayerIndex("Left Door"), 1);
        ////anim.SetLayerWeight(anim.GetLayerIndex("Right Door"), 0);
        //if (!validateState()) { Debug.Log("ignoring"); return; }

        //if (!anim.GetBool("OpenIt"))
        //{
        //    // Close the door 
        //    //anim.SetTrigger("onClick");
        //    anim.SetBool("OpenIt", true);
            
        //}
        //else {
        //    // Open the door
        //    //anim.SetTrigger("onClick");
        //    anim.SetBool("OpenIt",false);
        //    //anim.GetBool("OpenIt");
            
        //}
        
    }

    public void DoorMoving()
    {
        doorIsMoving = true;
    }
    public void DoorStopped()
    {
        doorIsMoving = false;
    }
    
}
