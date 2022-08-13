using UnityEngine;

public class SpawnObastacle : MonoBehaviour
{
    /* 1 level max 1000 score olacaq(score 1000 olanda Y da 1000 olur).  baloon, mini plane, plane, sattlelite, asteroid, ufo, 
     */
    public GameObject[] Obstacles;
    bool PermissionSpawn = true;
    public GameObject Car;
    float SpawnBool;
    

    void Update()
    {
        if (Car.transform.position.y - SpawnBool > 30f)
        {
            PermissionSpawn = true;
        }
        
        if (Car.transform.position.y > 15f && Car.transform.position.y < 25f && PermissionSpawn)
        {
            PermissionSpawn = false;
            SpawnerBaloon();
            SpawnBool = Car.transform.position.y;
            
        }

        if (Car.transform.position.y > 65f && Car.transform.position.y <70f && PermissionSpawn)
        {
            PermissionSpawn = false;
            SpawnPlaneDoodo();
            SpawnBool = Car.transform.position.y;
        }
        if (Car.transform.position.y > 120f && Car.transform.position.y < 125f && PermissionSpawn)
        {
            PermissionSpawn = false;
            SpawnJet();
            SpawnBool = Car.transform.position.y;
        }

        if (Car.transform.position.y > 160f && Car.transform.position.y < 165f && PermissionSpawn)
        {
            PermissionSpawn = false;
            SpawnSattlelite();
            SpawnBool = Car.transform.position.y;

        }
        if (Car.transform.position.y > 200f && Car.transform.position.y < 205f && PermissionSpawn)
        {
            PermissionSpawn = false;
            SpawnUfo();
            SpawnBool = Car.transform.position.y;

        }


    }
    void SpawnerBaloon()
    {
        
        for (int i = 0; i < 1; i++)
        {
            Instantiate(Obstacles[0], new Vector3(Car.transform.position.x + Random.Range(-8f, 2f), Car.transform.position.y + Random.Range(11f,14f), 0), Quaternion.identity);
            
        }

    }
    void SpawnPlaneDoodo()
    {
        
        for (int i = 0; i < 1; i++)
        {
            Instantiate(Obstacles[1], new Vector3(Car.transform.position.x + Random.Range(-14f, -2f), Car.transform.position.y + Random.Range(2f,3f), 0), Quaternion.identity); ;
        }
        
    }
    void SpawnJet()
    {

        for (int i = 0; i < 1; i++)
        {
            Instantiate(Obstacles[4], new Vector3(Car.transform.position.x + Random.Range(8f, 14f), Car.transform.position.y + Random.Range(2f, 3f), 0), Quaternion.identity); ;
        }

    }
    void SpawnSattlelite()
    {

        for (int i = 0; i < 3; i++)
        {
            Instantiate(Obstacles[2], new Vector3(Car.transform.position.x + Random.Range(-10f, 13f), Car.transform.position.y + Random.Range(10f,20f), 0), Quaternion.identity);
        }

    }
    void SpawnUfo()
    {

        for (int i = 0; i < 1; i++)
        {
            Instantiate(Obstacles[3], new Vector3(Car.transform.position.x + Random.Range(-12f, -2f), Car.transform.position.y + Random.Range(4f,8f), 0), Quaternion.identity);
        }

    }
}






