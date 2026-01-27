using UnityEngine;

public class Rotator : MonoBehaviour
{

 public float speed =1f;
 void Update()
    {
 // Rotate the object on X, Y, and Z axes by specified amounts, adjusted for frame rate.
        transform.Rotate (new Vector3 (0, 34, 0) * Time.deltaTime * speed);
    }
 
}