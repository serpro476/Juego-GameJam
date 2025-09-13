using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float velocity;
    public float MaxTime;
    float timer = 0;
    void Start()
    {
        
    }

    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer < MaxTime)
        {
            transform.Translate(new Vector2(velocity * Time.deltaTime, 0));

        }
        if (timer > MaxTime && timer < MaxTime * 2)
        {
            transform.Translate(new Vector2(-velocity * Time.deltaTime, 0));
        }
        if(timer > MaxTime * 2) 
        {
            timer = 0;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(new Vector2(transform.position.x - velocity * MaxTime  * 0.07f, transform.position.y), new Vector2(transform.position.x + velocity * MaxTime * 0.08f, transform.position.y));
    }
}
