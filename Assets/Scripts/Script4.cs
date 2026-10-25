using UnityEngine;

public class Script4 : MonoBehaviour
{
    public Transform cylinderHitGoal;    
    public GameObject cubeObstacle;      

    
    public float speed = 6f;
    public Material hitGoalColor;        
    public float cubeDistance = 3f;     

    private Rigidbody rb;
    private bool hasHitCube = false;
    private bool moveCube = false;
    private Vector3 cubeTargetPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (cylinderHitGoal != null)
        {
            if (!hasHitCube || !moveCube)
            {
                Vector3 direction = (cylinderHitGoal.position - transform.position).normalized;
                rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
            }
        }
    }

    void Update()
    {
        if (moveCube && cubeObstacle != null)
        {
            cubeObstacle.transform.position = Vector3.MoveTowards(
                cubeObstacle.transform.position, 
                cubeTargetPosition, 
                speed * Time.deltaTime
            );

            
            if (Vector3.Distance(cubeObstacle.transform.position, cubeTargetPosition) < 0.01f)
            {
                moveCube = false; 
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject == cubeObstacle || collision.gameObject.name.Contains("Cube"))
        {
            hasHitCube = true;

            Renderer cubeRenderer = cubeObstacle.GetComponent<Renderer>();
            if (hitGoalColor != null && cubeRenderer != null)
            {
                cubeRenderer.material = hitGoalColor;
            }
            cubeTargetPosition = cubeObstacle.transform.position + (cubeObstacle.transform.forward * cubeDistance);
            moveCube = true;
        }
    }
}