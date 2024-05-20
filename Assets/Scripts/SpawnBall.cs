using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBall : MonoBehaviour
{
    [SerializeField]
    private Slider verticalSlider;

    [SerializeField] 
    private Slider horizontalSlider;

    [SerializeField]
    private Slider angleSlider;

    [SerializeField]
    private Slider forceSlider;

    [SerializeField]
    private GameObject ball;

    [SerializeField]
    private TextMeshProUGUI horizontalText;


    [SerializeField] 
    private TextMeshProUGUI verticalText;

    [SerializeField]
    private TextMeshProUGUI angleText;

    [SerializeField]
    private TextMeshProUGUI forceText;


    public void AdjustVerticalPosition()
    {
        Vector3 yPosition = transform.position;
        yPosition.y = verticalSlider.value;
        transform.position = yPosition;
        verticalText.text = "Vertical (" + yPosition.y.ToString("F2") + ")";
    }

    public void AdjustHorizonalPosition()
    {
        Vector3 zPosition = transform.position;
        zPosition.z = horizontalSlider.value;
        transform.position = zPosition;
        horizontalText.text = "Horizontal (" + zPosition.z.ToString("F2") + ")";
    }

    public void DisplayAngleValue()
    {
        angleText.text = "Angle (" + angleSlider.value.ToString("F2") + ")";
    }

    public void DisplayForceValue()
    {
        forceText.text = "Force (" + forceSlider.value.ToString("F2") + ")";
    }

  
    public void Bounce()
    {
        Instantiate(ball, transform.position, ball.gameObject.transform.rotation);        
    }
}
