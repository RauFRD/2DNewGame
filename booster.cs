using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GDGames.Inputs;

public class booster : MonoBehaviour
{
    
    float rotation;
    

    [Header("Rotation Settings")]
    public float rotateSpeed;
    public GameObject Car;

    [Header("Fuel Settings")]
    public float Fuelpercent = 100f;
    public float benzinAzalmasi;
    public Text FuelPercentText;

    [Header("Booster Settings")]
    ConstantForce2D boost;
    public float MaxBoost;
    

    public ParticleSystem SmokeEffekt;
    public Slider sliderBoost;


    public SteeringWheel rulkodu;
    public Camera kamera;

    public GameObject BoosterGameObject;
    Rigidbody2D rigidbodybooster;
    
    public void retry()
    {
        SceneManager.LoadScene(0);
    }
    void Start()
    {
        Application.targetFrameRate = 55;
        rigidbodybooster = BoosterGameObject.GetComponent<Rigidbody2D>();
        //Time.timeScale = 1;
        sliderBoost.maxValue = MaxBoost;
        boost = GetComponent<ConstantForce2D>();
        
    }
    
    private void LateUpdate()
    {
        
        Car.transform.Rotate(0f, 0f, rotation);
    }


    private void FixedUpdate() 
    {
        
        FuelPercentText.text = Mathf.RoundToInt(Fuelpercent) + "%";
        rotation = rulkodu.input * rotateSpeed *-1f;
        boost.relativeForce = new Vector3(sliderBoost.value, 0f, 0f);

        if(sliderBoost.value > sliderBoost.maxValue/2f)
        {
            SmokeEffekt.Play();
            kamera.orthographicSize += 0.03f;

            if (kamera.orthographicSize > 11f)
            {
                kamera.orthographicSize = 11f;
            }
        }
        else
        {
            kamera.orthographicSize -= 0.03f;
            if (kamera.orthographicSize < 8f)
            {
                kamera.orthographicSize = 8f;
            }
            SmokeEffekt.Stop();
        }
        
        
        if (Fuelpercent>0f)
       { 
            Fuelpercent -= sliderBoost.value/benzinAzalmasi * Time.deltaTime;
            //Debug.Log(Fuelpercent);

            
        }


        else if (Fuelpercent < 0f)
        {
            sliderBoost.value = 0f;
            sliderBoost.enabled = false;
        }
        
        
        else
        {
            kamera.orthographicSize -= 0.02f; 
            if (kamera.orthographicSize < 8f)
            {
                kamera.orthographicSize = 8f;
            }
            SmokeEffekt.Stop();
        }


        if (Fuelpercent < 50f && rigidbodybooster.simulated == false)
        {
            rigidbodybooster.simulated = true;
        }
    }
   

    public void addfuel()
    {
        Fuelpercent = 100f;
    }
}
