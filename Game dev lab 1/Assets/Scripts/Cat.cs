using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
<<<<<<< Updated upstream

=======
    GameObject GameManager;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(pos.x, transform.position.y);
        FlipCat(pos);
    }
    
    private float oldX = 0f;
    
    void FlipCat(Vector2 pos)
    {
        if(oldX < pos.x){
             GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(oldX > pos.x){
             GetComponent<SpriteRenderer>().flipX = false;
        }
        
        oldX = pos.x;
    }
    void OnTriggerEnter2D(Collider2D col){
<<<<<<< Updated upstream
        if (col.gameObject.tag == "diamond") {

=======
        if (col.gameObject.tag == "Diamond") {
>>>>>>> Stashed changes
            Destroy(col.gameObject);
            //method to increase score
            GameManager.IncScore();
        }
    }
}
