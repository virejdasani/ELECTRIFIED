using UnityEngine;
using UnityEngine.UI;     

public class DistanceCalculator : MonoBehaviour {

    // Reference to checkpoint position
    [SerializeField]
    private Transform checkpoint;

    // Reference to UI text that shows the distance value
    [SerializeField]
    private Text distanceText;

    // Calculated distance value
    private float distance;

    // Update is called once per frame
    private void Update()
    {

        // Calculate distance value between character and checkpoint
        distance = (checkpoint.transform.position - transform.position).magnitude - 27.3f;

        // Display distance value via UI text
        // distance.ToString("F1") shows value with 1 digit after period
        // so 12.234 will be shown as 12.2 for example
        // distance.ToString("F2") will show 12.23 in this case
        distanceText.text = "Distance: " + distance.ToString("F1") + " m";
    }

}