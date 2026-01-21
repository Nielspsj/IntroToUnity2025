using UnityEngine;

public class LeftFlipperManager : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = -45f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;

    private HingeJoint curHingeJoint;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        curHingeJoint = GetComponent<HingeJoint>();
        curHingeJoint.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        JointUpdate();
    }

    private void JointUpdate()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            spring.targetPosition = pressedPosition;
            Debug.Log("leftarrow pressed");
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        curHingeJoint.spring = spring;
        curHingeJoint.useLimits = true;
    }
}
