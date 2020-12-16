using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaderController : MonoBehaviour
{

    Vector3 pointA;
    Vector3 pointB;

    private float speed = 0.5f;
    public static bool speedStoped;
    public static bool quaderFallen;
    // Start is called before the first frame update
    void Start()
    {
        createQuader();
        speedStoped = true;
        quaderFallen = false;
    }

    void createQuader()
    {
        pointA = new Vector3(this.transform.position.x , this.transform.position.y, this.transform.position.z);
        pointB = new Vector3(this.transform.position.x, this.transform.position.y, 3f);
    }

    void Update()
    {
        //Moved back and Fort
        if (speedStoped)
        {
            float time = Mathf.PingPong(Time.time * speed, 1);
            transform.position = Vector3.Lerp(pointA, pointB, time);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Collition with the Sockel
        if(other.tag == "Sockel")
        {
            SpawnManager.createQuader = false;
            Destroy(this);
        }
    }
    void FixedUpdate()
    {
        if (quaderFallen)
        {
            this.GetComponent<Rigidbody>().useGravity = true;
            this.GetComponent<Rigidbody>().isKinematic = false;
            speedStoped = false;
        } 
    }
}
