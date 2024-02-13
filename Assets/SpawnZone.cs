using UnityEngine;

public class SpawnZone : MonoBehaviour
{

    [SerializeField]

    private GameObject cubePrefab;

    [SerializeField]

    private Vector3 zoneSize;

    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, zoneSize);
    }
}
