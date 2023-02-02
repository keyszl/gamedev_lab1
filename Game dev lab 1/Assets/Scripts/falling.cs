using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    //sprite prefab
    public GameObject diamondPrefab;

    public float moveSpeed = 0.07f;
    
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(spawner());
      StartCoroutine(Timeout());
      
    }

    void FixedUpdate()
    {
        
      transform.Translate(0,-moveSpeed,0);

    }

    // thanks to https://answers.unity.com/questions/1850275/how-to-create-object-falling-from-sky-continuously.html
    IEnumerator spawner(){
      while (true){
        float randomPosition = Random.Range(-8.5f,8.5f);
        yield return new WaitForSeconds(1.5f); // WAIT

        Instantiate(diamondPrefab,new Vector3(randomPosition,4f,transform.position.z),Quaternion.identity);
      }
    }

    IEnumerator Timeout()
     {
         yield return new WaitForSeconds(2f);
         Destroy(this.gameObject);
     }

}
