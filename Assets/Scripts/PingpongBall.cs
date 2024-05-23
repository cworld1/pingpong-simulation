using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingpongBall : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField]
    public Vector3 direction = new Vector3(1, 1, 0);



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameObject.SetActive(true);
        OnCollision(direction);
    }


    Vector3 GetVector3()
    {
        return gameObject.transform.position;
    }

    void OnCollision(Vector3 direction) {

            //gameObject.transform.position = transform.position + direction;
            rb.velocity = new Vector3(direction.x, direction.y, direction.z);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GetVector3());
    }
}
