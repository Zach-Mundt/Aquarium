using UnityEngine;
using System.Collections;

public class CreateMiniture : MonoBehaviour
{
    public static bool initDone = false;
    private GameObject miniture;
    private float scale = .01f;    //This is the scale that decreases the size of the miniture.

    // Start is called before the first frame update
    void Awake()
    {
        if (!initDone)
        {
            initDone = true;
            miniture = Instantiate(gameObject, new Vector3(transform.position.x * scale, transform.position.y * scale + 20f, transform.position.z * scale), transform.rotation);
            miniture.transform.localScale = miniture.transform.localScale * scale;
            Destroy(GetComponent<Grabbable>());
            initDone = false;
        }
    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (miniture != null)
        {
            transform.position = new Vector3(miniture.transform.position.x / scale, (miniture.transform.position.y - 20) / scale, miniture.transform.position.z / scale);
            transform.rotation = miniture.transform.rotation;
            transform.localScale = miniture.transform.localScale / scale;
        }

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Trash")
        {

            Destroy(miniture);
            Destroy(this.gameObject);
        }
    }
}
