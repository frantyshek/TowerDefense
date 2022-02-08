using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] float speed;

    [SerializeField] List<Waypoint> path = new List<Waypoint>();

    void Start()
    {
        StartCoroutine(WritePath());
    }

    IEnumerator WritePath()
    {
        foreach(Waypoint waypoint in path)
        {
            Vector3 startPos = transform.position;
            Vector3 endPos = waypoint.transform.position;
            float travelPercent = 0f;
            
            transform.LookAt(endPos);

            while(travelPercent < 1)
            {
                travelPercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPos,endPos,travelPercent);
                yield return new WaitForEndOfFrame(); 
            }
        }
    }

}
