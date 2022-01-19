using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOpenDoor : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    
    void OnTriggerEnter(Collider col)
    {
        door.transform.position += new Vector3(0, 7, 0);
    }





}
