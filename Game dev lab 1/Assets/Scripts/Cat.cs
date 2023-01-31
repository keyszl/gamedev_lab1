using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(pos.x, transform.position.y);
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Diamond") {
            Destroy(col.gameObject);
            //method to increase score
        }
    }
}
