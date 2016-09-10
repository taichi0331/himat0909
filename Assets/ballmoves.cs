using UnityEngine;
using System.Collections;

public class ballmoves : MonoBehaviour
{



    void Update()
    {
        transform.rotation = new Quaternion(0, 0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.1f, 0, 0);
            
        }
        if (Input.GetKey(KeyCode.S)) { 
            transform.Translate(-0.1f, 0, 0);
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, -0.1f);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, 0.1f);
            
        }

        if (transform.position.y < -5)
        {
            transform.position = new Vector3(0, 0.5f, 0);
            transform.Translate(0, 5, 0);
            transform.rotation= new Quaternion(0,0,0,0);
        }
    }

    private void OnCollisionStay(Collision field)
    {
        if (field.gameObject.tag != "filed")
        {
            if (Input.GetKey(KeyCode.Space))
                transform.GetComponent<Rigidbody>().AddForce(0, 250f, 0);

        }
    }
}