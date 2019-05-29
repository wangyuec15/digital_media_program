using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    Transform parent;
    public List<Transform> linked;
    public float distance = 10;
    public float g = 4;
    public float noise;
    public float min_distance;

    public Transform lefttop, rightbottom;


    public Vector3 acceleration;
    public Vector3 speed;
    // Use this for initialization
    void Start()
    {
        parent = transform.parent;
        acceleration = Vector3.zero;
        speed = Vector3.zero;
        lefttop = GameObject.Find("lt").transform;
        rightbottom = GameObject.Find("rb").transform;

        //gameObject.GetComponent<Transform>().position = (lefttop.position + rightbottom.position) / 2;
    }

    //draw cameradraw = Camera.main.GetComponent<draw>();

    // Update is called once per frame
    void Update()
    {
        move();
        forceCalculate();
    }
    void forceCalculate()
    {
        acceleration = Vector3.zero;
        foreach (Transform brother in parent)
        {
            if (brother != gameObject.transform&&Vector3.Distance(brother.position,transform.position)<distance*10)
            {
                Vector3 direction = (brother.position - transform.position) / Vector3.Distance(brother.position, transform.position);
                float count = g / Mathf.Pow(Vector3.Distance(brother.position, transform.position)-min_distance, 2);
                acceleration -= direction * count;
                brother.gameObject.GetComponent<force>().acceleration += direction * count;
                if (brother.position == transform.position)
                {
                    gameObject.GetComponent<Transform>().position += new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0) * 10;
                }

                //cameradraw.anylink.Add(brother.position);
                //cameradraw.anylink.Add(transform.position);

            }
        }
        foreach (Transform relation in linked)
        {
            //gameObject.GetComponent<Transform>().position +=((relation.position - transform.position) / Vector3.Distance(relation.position, transform.position))*(Vector3.Distance(relation.position, transform.position) - distance)*0.9f ;


            Vector3 aimPosition = (transform.position - relation.position) / Vector3.Distance(relation.position, transform.position) * distance + relation.position;
            Vector3 direction = (aimPosition - transform.position) / Vector3.Distance(aimPosition, transform.position);
            float count = 2*g / Mathf.Max(Mathf.Pow(Vector3.Distance(aimPosition, transform.position), 2), 0.3f);

            acceleration += direction * count;
            relation.gameObject.GetComponent<force>().acceleration -= direction * count;

            //Debug.Log(speed);

            //cameradraw.anylink.Add(relation.position);
            //cameradraw.anylink.Add(transform.position);
        }
    }
    void move()
    {
        speed += acceleration;
        gameObject.GetComponent<Transform>().position += speed;

        //Debug.Log(transform.position);
        if (transform.position.x < lefttop.position.x)
        {
            //gameObject.GetComponent<Transform>().position = new Vector3(lefttop.position.x, transform.position.y, 0);
            speed = new Vector3(-speed.x, speed.y, 0);
            acceleration = new Vector3(-acceleration.x, acceleration.y, 0);
        }
        if (transform.position.y > lefttop.position.y)
        {
            //gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, lefttop.position.y, 0);
            speed = new Vector3(speed.x, -speed.y, 0);
            acceleration = new Vector3(acceleration.x, -acceleration.y, 0);
        }

        if (transform.position.x > rightbottom.position.x)
        {
            //gameObject.GetComponent<Transform>().position = new Vector3(rightbottom.position.x, transform.position.y, 0);
            speed = new Vector3(-speed.x, speed.y, 0);
            acceleration = new Vector3(-acceleration.x, acceleration.y, 0);
        }
        if (transform.position.y < rightbottom.position.y)
        {
            //gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, rightbottom.position.y, 0);
            speed = new Vector3(speed.x, -speed.y, 0);
            acceleration = new Vector3(acceleration.x, -acceleration.y, 0);
        }
        speed *= 0.9f;
        acceleration *= 0.9f;
        speed += new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0) * noise;
    }

     
    /////
    /// 
    /// 
}
