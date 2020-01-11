using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{

    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(new Vector3(-0.5f, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(new Vector3(0.5f, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(new Vector3(0,0.5f,0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(new Vector3(0, -0.5f,0));

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            Vector3 pos = gameObject.transform.position;
            pos.y += 0f;
            Instantiate(Bullet, pos, Quaternion.identity);
        }
    }
}
