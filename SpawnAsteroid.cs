using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnAsteroid : MonoBehaviour
{
    
    public GameObject SpawnGameobject;
    
    public GameObject Car;
    public int asteroidsayi; //private olacaq
    public asteroid randomasteroid;
    //GameObject asteroid;
    float randomside;
    bool SpawnPermission= true;

    
    private void Update()
    {
        spawnAsteroid();
    }
    public void SpawnerAsteroid()
    {

        randomside = Random.Range(0f, 1f);
        if (randomside > .5f)//sagdan sola spawn
        {
            Instantiate(SpawnGameobject, new Vector3(Car.transform.position.x + Random.Range(15, 20), Car.transform.position.y + Random.Range(25, 30), 0), Quaternion.identity);
        }
        else
        {
            Instantiate(SpawnGameobject, new Vector3(Car.transform.position.x - Random.Range(15, 20), Car.transform.position.y + Random.Range(25, 30), 0), Quaternion.identity);
        }
        
        float a = Random.Range(0.2f, 0.6f);
        SpawnGameobject.transform.localScale = new Vector3(a, a, a);
        
        //Instantiate(SpawnGameobject, new Vector3(Car.transform.position.x + Random.Range(12, 15), Car.transform.position.y + Random.Range(20, 25), 0), Quaternion.identity); 
        
    }
    void spawnAsteroid()
    {
        if (Car.transform.position.y> 200f && SpawnPermission)
        {
            StartCoroutine(Spawnertimer());
            SpawnPermission = false;
        }
        
        
    }

    IEnumerator Spawnertimer()
    {
        for (int i = 0; i < asteroidsayi; i++)
        {

            SpawnerAsteroid();
            yield return new WaitForSeconds(2f);
        }
    }

}

