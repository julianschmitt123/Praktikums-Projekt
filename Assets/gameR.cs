using UnityEngine;

public class gameR : MonoBehaviour
{


    public Transform stonePrefab;

    public static Transform[] spawnpoints;
    public int tick=0;
    public int tickMax = 10;
    public Color dangerColor;
    
    private Renderer rend;

    void Awake()
    {
        spawnpoints = new Transform[transform.childCount];
        for (int i = 0; i < spawnpoints.Length; i++)
        {
            spawnpoints[i] = transform.GetChild(i);
        }
    }





    void Start()
    {
      
        

    }


    void Update()
    {
        if (tick == 0)
        {


            int index = Random.Range(0, 441);
            tick = tickMax;
            rend = spawnpoints[index].GetComponent<Renderer>();
            rend.material.color = dangerColor;




            Vector3 position = spawnpoints[index].position;
            position += new Vector3(0, 40, 0);
            Instantiate(stonePrefab, position, spawnpoints[index].rotation);

        }

        else tick--;


     









        
    }
}
