using UnityEngine;

public class DriveFromScratch : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    void Update()
    {
       float translation = Input.GetAxis("Vertical") * speed;
       float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

       translation *= Time.deltaTime;
       rotation *= Time.deltaTime;

       transform.position = HolisticMath.Translate(new Coords(transform.position),
                                                   new Coords(transform.up),
                                                   new Coords(0, translation, 0)).ToVector();

       transform.up = HolisticMath.Rotate(new Coords(transform.up), rotation * Mathf.Deg2Rad, true).ToVector();
    }
}
