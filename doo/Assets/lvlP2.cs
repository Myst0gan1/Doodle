using UnityEngine;

public class lvlP2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject PlatPrefab2;
    public int platformNum=200;
    public float xAxis=2f;
    public float minY=.2f;
    public float maxY=1.5f;
   
    void Start()
    {
        Vector3 spawnP=new Vector3();
        for (int i = 0; i < platformNum; i++)
        {
            spawnP.y+=Random.Range(minY, maxY);
            spawnP.x+=Random.Range(-xAxis, xAxis);
            Instantiate(PlatPrefab2, spawnP, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
