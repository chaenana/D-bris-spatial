using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    //public GameObject ex;
    //public GameObject Explosion;
    //// Start is called before the first frame update
    //void OnCollisionEnter(Collision col) //서로 충돌을 하였을 때의 함수
    //{

    //    Debug.Log("collision object=" + col.gameObject);
    //    Destroy(gameObject); //자기 자신을 없앰



    //    var exp = ex.GetComponent<ParticleSystem>();
    //    exp.Play();
    //    Debug.Log("폭발");
    //    Destroy(col.gameObject); //bullet을 없앰
    //    ContactPoint contact = col.contacts[0];
    //    Instantiate(Explosion, contact.point, Quaternion.identity);
    //}


        void Start()
    {
        Destroy(gameObject,3f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0, 0, 1f));
        
    }
}
