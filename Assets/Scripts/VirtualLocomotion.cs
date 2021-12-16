using UnityEngine;
using UnityEngine.InputSystem;

public class VirtualLocomotion : MonoBehaviour
{
    public Transform moveDirectionR;
    //public Transform moveDirectionL;
    public float deadZone = 0.25f;
    public float maxVelocity = 15.0f;
    public bool flyMode = false;
    private Vector3 velocity;

    public enum TurnMode
    {
        CONTINUOUS_TURN,
        SNAP_TURN,
        NO_TURN
    }
    public TurnMode turnMode = TurnMode.CONTINUOUS_TURN;
    public float maxTurnSpeed = 45.0f;

    public InputActionProperty moveActionR;
    //public InputActionProperty moveActionL;
    public InputActionProperty stopAction;

    bool snapTurnInitiated = false;

    // Start is called before the first frame update
    void Start()
    {
        snapTurnInitiated = false;
        moveActionR.action.performed += MoveR;
        //moveActionL.action.performed += MoveL;
        stopAction.action.performed += Stop;

        velocity = new Vector3(0.0f, 0.0f, 0.0f);
    }

    private void OnDestroy()
    {
        moveActionR.action.performed -= MoveR;
        //moveActionL.action.performed -= MoveL;
        stopAction.action.performed -= Stop;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 drag = -velocity.normalized * velocity.magnitude * Time.deltaTime * .5f;
        velocity += drag;
        if (velocity.magnitude < 0.0f)
        {
            velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }

        this.transform.localPosition += velocity;

    }

    public void MoveR(InputAction.CallbackContext context)
    {
        Vector3 moveVector = moveDirectionR.TransformDirection(Vector3.forward);

        Vector2 inputAxes = context.action.ReadValue<Vector2>();

        if (inputAxes.y >= deadZone || inputAxes.y <= -deadZone)
        {
            if (velocity.magnitude < maxVelocity)
            {
                velocity += .1f * inputAxes.y * moveVector * Time.deltaTime;
            }
        }

    }
    /*
    public void MoveL(InputAction.CallbackContext context)
    {
        Vector3 moveVector = moveDirectionR.TransformDirection(Vector3.forward);

        Vector2 inputAxes = context.action.ReadValue<Vector2>();

        if (inputAxes.y >= deadZone || inputAxes.y <= -deadZone)
        {
            if (velocity.magnitude < maxVelocity)
            {
                velocity += .1f * inputAxes.y * moveVector * Time.deltaTime;
            }
        }

    }
    */

    public void Stop(InputAction.CallbackContext context)
    {
        velocity = new Vector3(0.0f, 0.0f, 0.0f);
    }
}