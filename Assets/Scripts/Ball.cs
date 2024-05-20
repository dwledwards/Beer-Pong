using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private Slider forceSlider;
    private Slider angleSlider;


    float desiredBallSpeed = 20.0f;
    float desiredBallLaunchAngle = 45.0f;

    [SerializeField]
    private GameObject cup;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        angleSlider = GameObject.Find("AngleSlider").GetComponent<Slider>();
        forceSlider = GameObject.Find("ForceSlider").GetComponent <Slider>();   

        desiredBallLaunchAngle = angleSlider.value;

        desiredBallSpeed = forceSlider.value;

        Quaternion rotation = Quaternion.Euler(0, 0, desiredBallLaunchAngle);

        Vector3 velocity = rotation * (Vector3.left * desiredBallSpeed);

        rb.velocity = velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Panel"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        float randZ = Random.Range(-5.85f, 5.85f);
        float randX = Random.Range(-8.33f, 1.14f);
        Vector3 randomPosition = new Vector3(randX, cup.transform.position.y, randZ);

        Instantiate(cup, randomPosition, cup.transform.rotation);

        Destroy(gameObject);
        Destroy(other.gameObject.transform.parent.gameObject);        
    }
}
