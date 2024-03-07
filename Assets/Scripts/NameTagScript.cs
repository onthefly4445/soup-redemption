using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameTagScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 screenResolution, worldUnitResolution;
    void Start() {
        worldUnitResolution = new Vector2(16.0f, 9.0f);
        screenResolution = new Vector2(Screen.width, Screen.height);
    }

    // Update is called once per frame
    void Update() {
        FollowMouse();
    } 
    private void FollowMouse() {
        transform.position = (Input.mousePosition / screenResolution * worldUnitResolution - worldUnitResolution / 2.0f) * 2.0f;
    }
}
