using UnityEngine;

public class lvlP1 : MonoBehaviour
{
   public GameObject PlatPrefab1;
    public int platformNum=200;
    public float xAxis=2f;
    public float minY=8f;
    public float maxY=10f;
   
    void Start()
    {
        Vector3 spawnP=new Vector3();
        for (int i = 0; i < platformNum; i++)
        {
            spawnP.y+=Random.Range(minY, maxY);
            spawnP.x+=Random.Range(-xAxis, xAxis);
            Instantiate(PlatPrefab1, spawnP, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
