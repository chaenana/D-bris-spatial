using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject ex;
    public GameObject Explosion;
    public AudioSource audio;


    void OnCollisionEnter(Collision col) //서로 충돌을 하였을 때의 함수
    {

        

        //맨 처음엔 그냥 배운대로 다 붙여서 넣으면 되겠구나 생각하고 했다 근데 잘 되지 않았다.
        //수업 시간에 했었던 것은 원래 있었던 것을 destroy해서 없애 버리는 것이었고. 이건 파티클효과를 추가해서 파티클이 보여야 하는데 보이지가 않았다.
        //파티클을 지정한 게임 오브젝트가 사라지니까 파티클이 보이지 않는 것같았고, 
        //그래서 처음엔 destroy 되는 시간을 딜레이 시켜보았다.

        //Debug.Log("collision object=" + col.gameObject);
        //Destroy(gameObject, 1.5f); //자기 자신을 없앰

        //딜레이는 되어서 파티클이 살짝 보이긴 했지만 당장 부딪히자마자 빵하고 터지는 효과를 원했다.
        //생각을 해보았는데, 게임오브젝트와 파티클이 서로 부속되어 있는 관계가 아니라 평등한 관게로 지정을 해주고
        //이에 똑같이 스크립트를 적용을 시켜주면 되지 않을까? 라고 생각을 해보았다.



        Debug.Log("collision object=" + col.gameObject);
        Destroy(gameObject); //자기 자신을 없앰



        var exp = ex.GetComponent<ParticleSystem>();
        exp.Play();
        Debug.Log("폭발");
        Destroy(col.gameObject); //bullet을 없앰
        ContactPoint contact = col.contacts[0];
        Instantiate(Explosion, contact.point, Quaternion.identity);


        //그래서 빈게임 오브젝트를 만들고 그 안에 프리펩과 파티클 시스템을 같이 동등한 위치로 지정을 해서 각각 스크립트를 적용을 시켜보았다.
        //오 된다된다.

        audio.Play();

        Debug.Log("Play"); //발사해서 충돌시 소리가 실행된다.

        //이제 충돌을 하였을 때 사운드가 나와야 하니까 이를 지정을 해주었다.
        //지정을 해주자마자 바로 사운드가 나왔다.
        //그래서 소리가 바로 시작하지 않게 start에 함수를 지정해주었다.


    }
    // Start is called before the first frame update
    void Start()
    {
        var exp = ex.GetComponent<ParticleSystem>();
        exp.Stop();
        Debug.Log("준비");



        //시작할때는 아직 파티클이 나오면 안되니까 지정을 해줌.
        audio.Stop();
        Debug.Log("stop"); //잘 실행되고 있는가 확인
        //audio.Play();
    }


    // Update is called once per frame
    void Update()
    {




    }
}
