using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour {
    public TreeController TC;
    public GameObject[] Acorns;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    public float MoveSpeed;
    public float maxSpawnValue;
    public float minSpawnValue;
    int randAcorn;

    private float _highScore;

    private void Awake()
    {
        
    }
    void Start ()
    {
        StartCoroutine(WaitSpawner());
	}

    void SaveHighScore()
    {

       // PlayerPrefs.SetFloat("Name You Want To Use", _highScore);

    }

   // void GetHighScore()
    //{

      //  _highScore = PlayerPrefs.GetFloat("Name You Want To Use");

    //}
	

	void Update ()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);

        transform.position -= new Vector3(0, MoveSpeed, 0) * Time.deltaTime;
    }

    IEnumerator WaitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randAcorn = Random.Range(0, 9);
            //original
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), Random.Range(-spawnValues.z, spawnValues.z));
            //test
            //Transform spawnPosition = TC.AcornList[Random.Range(1, TC.AcornList.Count)];
            //new Vector3(Random.Range(minSpawnValue, maxSpawnValue), Random.Range(-spawnValues.y, spawnValues.y), Random.Range(minSpawnValue, maxSpawnValue));
            //Instantiate(Acorns[randAcorn], spawnPosition.position, gameObject.transform.rotation);
            //Acorns[randAcorn] + transform.TransformPoint(0, 0, 0)

            yield return new WaitForSeconds(spawnWait);
        }
    
    }


}
