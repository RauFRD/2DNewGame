using UnityEngine;


public class asteroid : MonoBehaviour
{
    
    public GameObject asteroidGameobject;
    
    GameObject hedefimiz;
    GameObject saxtahedef;
    //bool worked = true;
    public float randomside;


    void Start()    
    {
        randomside = Random.Range(0f, 1f);
        saxtahedef = GameObject.FindGameObjectWithTag("Finish");
        hedefimiz = GameObject.FindGameObjectWithTag("Player");
        if (randomside > .5f) //sagdan sola
        {
            saxtahedef.transform.position = new Vector3(hedefimiz.transform.position.x - Random.Range(2f, 6f), hedefimiz.transform.position.y - Random.Range(1f, 5f));
        }
        else
        {
            saxtahedef.transform.position = new Vector3(hedefimiz.transform.position.x + Random.Range(2f, 6f), hedefimiz.transform.position.y - Random.Range(1f, 5f));
        }
        //saxtahedef.transform.position = new Vector3(hedefimiz.transform.position.x+Random.Range(3,9), hedefimiz.transform.position.y - Random.Range(5, 15));
        Destroy(asteroidGameobject, 2f);

    }

   
    void FixedUpdate()
    {
        //Debug.Log(randomside+"1");

        RotateAndMove();
        
        
    }

    void RotateAndMove()
    {
        
        
        transform.Rotate(0f, 0f, 2f);
        //asteroidGameobject.transform.Translate(-.1f, -.05f, 0f, Space.World);
        transform.position = Vector2.Lerp(asteroidGameobject.transform.position, saxtahedef.transform.position, .05f);
        

        
    }
    





}
