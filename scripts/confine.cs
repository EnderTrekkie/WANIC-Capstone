using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class confine : MonoBehaviour
{
    private List<Rigidbody2D> intersectingRigidbodies = new List<Rigidbody2D>();
    private BoxCollider2D coll;
    private void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        CheckIntersectingRigidbodies();
    }
    private void CheckIntersectingRigidbodies()
    {
        // Clear the list of intersecting rigidbodies
        intersectingRigidbodies.Clear();

        // Get all the colliders inside the trigger collider
        Collider2D[] colliders = Physics2D.OverlapBoxAll(((Vector2) transform.position) + coll.offset, coll.size,0);

        // Loop through each collider and check for the Rigidbody component
        foreach (Collider2D collider in colliders)
        {
            Rigidbody2D otherRigidbody = collider.attachedRigidbody;
            if (otherRigidbody != null)
            {
                // Add the Rigidbody to the list of intersecting rigidbodies
                intersectingRigidbodies.Add(otherRigidbody);
                otherRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            foreach (Rigidbody2D RB in intersectingRigidbodies) {
                RB.constraints = RigidbodyConstraints2D.FreezeRotation;
                //add a negligible force to "wake up" the object
                RB.AddForce(new Vector2(0,0.000001f));
            }
        }
    }
}
