using UnityEngine;

public class Movementobastacle : MonoBehaviour
{
    public float speedx;
    public float speedy;
    private void Start()
    {
        Destroy(this.gameObject, 15f);
    }

    void FixedUpdate()
    {
       
        this.gameObject.transform.Translate(speedx, speedy, 0f);
    }
}
