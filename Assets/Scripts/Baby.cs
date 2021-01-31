using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : MonoBehaviour
{
    public GameObject waypointsObject;
    private int waypointIndex = 0;
    public float movementSpeed;
    Waypoints waypoints;

    void Awake()
    {
        waypoints = waypointsObject.GetComponent<Waypoints>();
    }
    void Update()
    {
        FindWaypoints();
    }

    void FindWaypoints()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints.Wpoints[waypointIndex].position, movementSpeed * Time.deltaTime);
        Vector3 dir = waypoints.Wpoints[waypointIndex].position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        if (Vector2.Distance(transform.position, waypoints.Wpoints[waypointIndex].position) < 0.1f)
        {
            if (waypointIndex < waypoints.Wpoints.Length - 1)
            {
                waypointIndex++;
            }
            else
            {
                return;
                // end the game
            }
        }
    }
    
}
