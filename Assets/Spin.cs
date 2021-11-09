using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    //float timer;
    public float speed;
    public float speedScale;
    public Quaternion tilt;
    public Quaternion angle;
    // Start is called before the first frame update
    void Start()
    {
        Quaternion angle = Quaternion.identity;
        Quaternion tilt = Quaternion.identity;
        //timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        speed = Mathf.Clamp(speed, 0, 1);
        //timer += Time.deltaTime;
        //speed += Mathf.Sin(timer);

        tilt.eulerAngles = new Vector3(Mathf.Lerp(90, 2, speed), 0, 0);
        angle.eulerAngles = angle.eulerAngles + new Vector3(0, speed * speedScale, 0);
        transform.rotation = angle * tilt;
    }
}
