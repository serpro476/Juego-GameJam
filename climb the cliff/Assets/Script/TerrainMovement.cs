using UnityEngine;

public class TerrainMovement : MonoBehaviour
{
    public float Velocity;
    float timer;
    void Update()
    {
        timer = timer + Time.deltaTime;
        transform.Translate(new Vector2(0, -Velocity * Time.deltaTime));
        if(timer > 2)
        {
            Velocity = Velocity + Velocity/10;
            timer = 0;
        }
    }
}
