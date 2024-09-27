using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public GameObject StartPoint;
    public GameObject EndPoint;
    public GameObject Ship;
    public float speed = 10f;
    public float delay = 0.5f;

    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        Ship.transform.position = StartPoint.transform.position;
        targetPosition = EndPoint.transform.position;
        StartCoroutine(MoveSpaceShip());
    }

    // Update is called once per frame
    IEnumerator MoveSpaceShip()
    {
        while (true)
        {
            while ((targetPosition - Ship.transform.position).sqrMagnitude > 0.01f)
            {
                Ship.transform.position = Vector3.MoveTowards(Ship.transform.position, targetPosition, speed * Time.deltaTime);
                yield return null;
            }

            targetPosition = targetPosition == StartPoint.transform.position ? EndPoint.transform.position : StartPoint.transform.position;

            yield return null;

            /*if (Ship.position == StartPoint.positon)
            {
                Vector3.MoveTowards(EndPoint.transform.position);
            }
            else if(Ship.transform.position == EndPoint.transform.position)
            {
                Vector3.MoveTowards(StartPoint.transform.position);
            }
            else
            {
                yield return null;
            }*/
        }
    }
}
