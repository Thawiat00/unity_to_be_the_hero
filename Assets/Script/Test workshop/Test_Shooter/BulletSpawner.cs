using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    public Transform firePoint; // Assign a Transform indicating where bullets should spawn (e.g., the tip of a gun)
    public float fireRate = 0.5f; // How often a bullet can be fired (seconds)
    private float nextFireTime = 0f;

    // No need for a public GameObject bulletPrefab here, as the ObjectPool handles it.

    void Update()
    {
        // Example: Fire bullet when the "Fire1" button (default: Left Ctrl or Mouse 0) is pressed
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate; // Set the time for the next allowed shot
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        if (ObjectPool.SharedInstance == null)
        {
            Debug.LogError("ObjectPool.SharedInstance is not initialized! Make sure an ObjectPoolManager with the ObjectPool script is in your scene.");
            return;
        }

        // This is the code from your step 7
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            if (firePoint != null)
            {
                bullet.transform.position = firePoint.position;
                bullet.transform.rotation = firePoint.rotation;
            }
            else
            {
                // Fallback if firePoint is not assigned
                bullet.transform.position = transform.position; // Spawn at the spawner's position
                bullet.transform.rotation = transform.rotation; // Spawn with the spawner's rotation
                Debug.LogWarning("FirePoint not assigned to BulletSpawner. Bullet spawned at Spawner's location.");
            }
            bullet.SetActive(true); // Activate the bullet to make it visible and start its behavior

            // If your bullet has a script like BulletBehavior (see below),
            // its OnEnable() method will be called here.
        }
        else
        {
            Debug.LogWarning("Tried to spawn a bullet, but no pooled objects were available.");
            // Optionally, handle the case where the pool is exhausted
            // (e.g., play a "click" sound, prevent firing temporarily).
        }
    }



}
