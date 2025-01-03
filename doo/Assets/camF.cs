using UnityEngine;

public class camF : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform targ;
    // Update is called once per frame
    void Update()
    {
        if(targ.position.y>transform.position.y){
            transform.position=new Vector3(0f, targ.position.y, -10f);
        }
    }
}
