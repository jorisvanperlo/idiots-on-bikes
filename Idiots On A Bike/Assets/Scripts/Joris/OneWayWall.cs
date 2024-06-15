using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayWall : MonoBehaviour
{
    private Collider wallCollider;
    public Transform player;
    public float detectionDistance; // Distance in front and behind the wall to detect the player

    void Start()
    {
        
    }

    
    void Update()
    {
        // Calculate the vector from the wall to the player
        Vector3 wallToPlayer = player.position - transform.position;

        // Transform this vector to the local space of the wall
        Vector3 localDirection = transform.InverseTransformDirection(wallToPlayer);

        // Determine if the player is in front or behind based on the local Z direction
        if (localDirection.z > detectionDistance)
        {
            // Player is in front of the wall
            wallCollider.isTrigger = true;
        }
        else if (localDirection.z < -detectionDistance)
        {
            // Player is behind the wall
            wallCollider.isTrigger = false;
        }
    }
}
