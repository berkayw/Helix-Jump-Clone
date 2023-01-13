using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Rigidbody rb;
    public float jumpForce;

    public GameObject splashPrefab;
    private GameManager gm;

    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.up * jumpForce;
        //rb.AddForce(Vector3.up * jumpForce);

        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -0.18f, 0f), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform); //Set splash on the ring.

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;

        if(materialName == "Safe Color (Instance)")
        {
            // Nothing, you are safe!

        }
        else if(materialName == "Unsafe Color (Instance)")
        {
            // Restart Level
            gm.RestartGame();
        }
        else if(materialName == "Last Ring (Instance)")
        {
            // Next Level
            Debug.Log("Next Level");

        }


    }
    
}
