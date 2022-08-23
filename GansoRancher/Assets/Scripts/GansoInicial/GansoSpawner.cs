using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GansoSpawner : MonoBehaviour
{

     [SerializeField] private GameObject gansoPrefab;

     [SerializeField] private float gansoInterval = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnGanso(gansoInterval, gansoPrefab));
        Debug.Log("Valor: " + GameObject.Find("GansoSpawner").transform.position[0]);
        Debug.Log("Valor: " + GameObject.Find("GansoSpawner").transform.position[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnGanso(float interval, GameObject ganso)
    {
        yield return new WaitForSeconds(interval);
        GameObject newGanso = Instantiate(ganso, new Vector3(GameObject.Find("GansoSpawner").transform.position[0] + Random.Range(-5f, 5f), GameObject.Find("GansoSpawner").transform.position[1] + Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnGanso(interval, ganso));
    }
}
