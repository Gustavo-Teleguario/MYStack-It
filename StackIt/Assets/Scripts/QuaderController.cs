using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuaderController : MonoBehaviour
{

    Vector3 pointA;
    Vector3 pointB;

    private float speed = 0.5f;
    public static bool speedStoped;
    public static bool quaderFallen;

    void Start()
    {
        createQuader();
        speedStoped = true;
        quaderFallen = false;
    }

    void createQuader()
    {
        pointA = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
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
        if(GameController.counter < 4)
        {
            this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ
                                                            |RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sockel")
        {
            SpawnManager.createQuader = false;
            Destroy(this);
            //score
            GameController.gcInstance.SetCountText();
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
