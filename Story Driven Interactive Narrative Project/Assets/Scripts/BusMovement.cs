using UnityEngine;

public class BusMovement : MonoBehaviour
{
    public GameObject bus;
    private int busX;
    private bool GameStart = false;

    private void Start()
    {
        busX = -5;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && GameStart)
        {
            busX += 6;
            bus.transform.position = new Vector3(busX, 2, 7);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GameStart = true;
            busX = -5;
            bus.transform.position = new Vector3(busX, 2, 7);
        }
    }
}
