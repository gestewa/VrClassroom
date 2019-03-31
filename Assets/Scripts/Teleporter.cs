using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public float maxDistance = 100f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddListener(UnityEngine.EventSystems.EventTriggerType.PointerClick, Clicked);
            // gameObject.AddListener(EventTriggerType.PointerUp, () => SetClicked(false));
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, maxDistance)) {
            Debug.Log("Updated the raycast");
            Vector3 targetLocation = hit.point;
            targetLocation += new Vector3(0,transform.localScale.y/2,0);
            transform.position = targetLocation;
        }
    }

    private void Clicked()
    {
        Debug.Log("pressed on");
    }
}
