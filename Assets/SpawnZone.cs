using UnityEngine;

public class SpawnZone : MonoBehaviour
{

    [SerializeField]

    private GameObject cubePrefab;

    [SerializeField]

    private Vector3 zoneSize;

    void Spawn(){
        GameObject instantiated = Instantiate(cubePrefab);

        instantiated.transform.position = new Vector3(
            Random.Range(transform.position.x - zoneSize.x / 2, transform.position.x + zoneSize.x / 2),
            Random.Range(transform.position.y - zoneSize.y / 2, transform.position.y + zoneSize.y / 2),
            Random.Range(transform.position.z - zoneSize.z / 2, transform.position.z + zoneSize.z / 2),

        );
    }

    void Start(
        {
            InvokeRepeating("Spawn", 0f, 0.5f);
        }
    )

    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, zoneSize);
    }
}
