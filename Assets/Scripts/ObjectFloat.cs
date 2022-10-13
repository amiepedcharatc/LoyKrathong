using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFloat : MonoBehaviour
{
    public float moveX, moveZ;
    [Space(20)]
    public float bobbingY = 0.05f, bobbingAmplitude = 1f, waterYLevel;
    float recordY;
    public bool IsActive;
    bool isReleased;
    bool isInWater;

    private void Start()
    {
        recordY = waterYLevel;
    }

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
        if (isReleased == true && isInWater)
        {
            Debug.Log(this.gameObject.name + " set on water");
            recordY = waterYLevel; // if this snaps badly, comment out? It's floating above water
            IsActive = true;
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null) rb.isKinematic = true;
            transform.rotation = Quaternion.identity;

        }
        
    }
    //public void PickFromWater() // If you can't pick it out anymore, remove entire function
    //{
    //IsActive = false;
    //}

    public void Release(bool toRelease)
    {
        isReleased = toRelease;

        if (toRelease == true)
        {
            SetOnWater();

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Krathong is picked.");
        }

        if (other.gameObject.tag == "Water") 
        {
            Debug.Log(this.gameObject.name+" is now on the water");
            isInWater = true;
            SetOnWater();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Water")
        {
            Debug.Log("Krathong is out of water");
            isInWater = false;
        }
    }
}
