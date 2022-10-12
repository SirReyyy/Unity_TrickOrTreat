using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject pump1Prefab;
    public GameObject pump2Prefab;

    public GameObject candy1Prefab;
    public GameObject candy2Prefab;
    public GameObject candy3Prefab;
    public GameObject candy4Prefab;
    public GameObject candy5Prefab;

    public GameObject roll1Prefab;
    public GameObject roll2Prefab;
    public GameObject roll3Prefab;
    public GameObject roll4Prefab;
    public GameObject roll5Prefab;

    private float min = -2f;
    private float max = 2f;

    // Start is called before the first frame update
    void Start() {
        StartCoroutine(SpawnTrick());
        StartCoroutine(SpawnTreat());
    }

    IEnumerator SpawnTrick() {
        yield return new WaitForSeconds(5f);

        Instantiate(pump1Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        //Instantiate(pump2Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        StartCoroutine(SpawnTrick());
    }

    IEnumerator SpawnTreat() {
        yield return new WaitForSeconds(Random.Range(1f, 2f));

        Instantiate(candy1Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        Instantiate(candy2Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        //Instantiate(candy3Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        //Instantiate(candy4Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        //Instantiate(candy5Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        Instantiate(roll1Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        Instantiate(roll2Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        //Instantiate(roll3Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        //Instantiate(roll4Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        //Instantiate(roll5Prefab, new Vector2(Random.Range(min, max), transform.position.y), Quaternion.identity);
        StartCoroutine(SpawnTreat());
    }
}
