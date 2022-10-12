using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFloat : MonoBehaviour
{
    public float moveX, moveZ;
    [Space(20)]
    public float bobbingY = 0.1f, bobbingAmplitude = 2f, waterYLevel;
    float recordY;
    public bool IsActive;
    void Update()
    {
        if (IsActive)
        {
            transform.position = new Vector3(
                transform.position.x + moveX * Time.deltaTime,
                recordY + Mathf.Sin(Time.time * bobbingAmplitude) * Time.deltaTime * bobbingY,
                transform.position.z + moveZ * Time.deltaTime
                );
            recordY = transform.position.y;
        }
    }
    /// <summary>
    /// Call when released on water. Make some OnTriggerEnter -check or something else 
    /// to check if this can be called.
    /// </summary>
    public void SetOnWater()
    {
        recordY = waterYLevel; // if this snaps badly, comment out?
        IsActive = true;
    }
    public void PickFromWater() // If you can't pick it out anymore, remove entire function
    {
        IsActive = false;
    }
}
