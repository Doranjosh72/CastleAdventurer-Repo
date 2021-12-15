using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    public float forceStrength;
    public Transform target;

    private Rigidbody ourRigidbody;


    // Start is called before the first frame update
    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = ((Vector3)target.position - (Vector3)transform.position).normalized;
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
