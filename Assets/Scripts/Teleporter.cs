using UnityEngine.InputSystem;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public LineRenderer laserPointer;
    public Material TeleportationTargetMaterial;

    public InputActionProperty axisAction;

    public GameObject XRRig;
    public GameObject Camera;

    public float deadZone = .8f;
    Vector3 newPosition;
    float newDirection;
    Quaternion joyDirection;

    GameObject arrow;
    public GameObject passArrow;

    TeleportationTarget TargetObject;

    Material lineRendererMaterial;
    // Start is called before the first frame update
    void Start()
    {
        laserPointer.enabled = false;
        lineRendererMaterial = laserPointer.material;

        TargetObject = null;
        arrow = null;
        joyDirection = Quaternion.Euler(0, 0, 0);

        newPosition = new Vector3(-0.01f, -0.01f, -0.01f);
        newDirection = 0f;

        axisAction.action.performed += Teleport;
    }
    private void OnDestroy()
    {
        axisAction.action.canceled -= Teleport;
    }

    // Update is called once per frame
    void Update()
    {
        if (laserPointer.enabled)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                laserPointer.SetPosition(1, new Vector3(0, 0, hit.distance));

                if (hit.collider.GetComponent<TeleportationTarget>())
                {
                    laserPointer.material = TeleportationTargetMaterial;
                }
                else
                {
                    laserPointer.material = lineRendererMaterial;
                }
            }
            else
            {
                laserPointer.SetPosition(1, new Vector3(0, 0, 100));
                laserPointer.material = lineRendererMaterial;
            }
        }

    }

    public void Teleport(InputAction.CallbackContext context)
    {
        //RIGHT NOW THIS IS CALLED EVERYTIME THE JOYSTICK IS TOUCHED NOT CONTINUOUSLY
        Vector2 inputAxes = context.action.ReadValue<Vector2>();
        RaycastHit hit;

        if (Mathf.Abs(inputAxes.y) + Mathf.Abs(inputAxes.x) >= deadZone)
        {
            laserPointer.enabled = true;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                if (hit.collider.GetComponent<TeleportationTarget>())
                {

                    TargetObject = hit.collider.GetComponent<TeleportationTarget>();
                    newPosition = new Vector3(hit.point.x, hit.point.y, hit.point.z);

                   
                    newDirection = Mathf.Atan2(inputAxes.x, inputAxes.y) * Mathf.Rad2Deg;
                    joyDirection = Quaternion.Euler(0, newDirection + transform.rotation.y + Camera.transform.rotation.y -120, 0);

                    Quaternion hi = Quaternion.Euler(0, transform.rotation.y, 0);
                    if (arrow == null)
                    {
                        arrow = Instantiate(passArrow, new Vector3(newPosition.x, newPosition.y + 1, newPosition.z), Quaternion.Euler(0, transform.rotation.y, 0));
                        
                    }
                    arrow.transform.rotation = Quaternion.Euler(0.0f, newDirection + transform.TransformDirection(Vector3.forward).y, 0.0f);

                    //This accouts teleportation under objects
                    if (TargetObject.transform.position.y > newPosition.y)
                    {
                    //    newPosition.y += TargetObject.transform.localScale.y;
                    }
                }
            }
        }
        else
        {
            laserPointer.enabled = false;
            if (newPosition != new Vector3(-0.01f, -0.01f, -0.01f))
            {
                XRRig.transform.position = newPosition;
                XRRig.transform.Rotate(0.0f, newDirection, 0.0f, Space.Self);
                Destroy(arrow);
                arrow = null;
                newDirection = 0;
                newPosition = new Vector3(-0.01f, -0.01f, -0.01f);
            }
        }
    }
}
