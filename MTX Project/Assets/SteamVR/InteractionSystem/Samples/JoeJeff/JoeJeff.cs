using UnityEngine;
using System.Collections;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
    public class JoeJeff : MonoBehaviour
    {
        [SerializeField]
        private float m_MovingTurnSpeed = 360;
        [SerializeField]
        private float m_StationaryTurnSpeed = 180;

        public float airControl;
        private bool isGrounded = true;

        private float turnAmount;
        private float forwardAmount;

        private float groundedTime;


        private Vector3 input;

        private bool held;

        private new Rigidbody rigidbody;
        private Interactable interactable;

        [SteamVR_DefaultAction("Move", "platformer")]
        public SteamVR_Action_Vector2 a_move;

        private SteamVR_Input_Sources hand;

        private void Start()
        {

            rigidbody = GetComponent<Rigidbody>();
            interactable = GetComponent<Interactable>();
        }

        private void Update()
        {
            held = interactable.attachedToHand != null;

            rigidbody.freezeRotation = !held;

            if (held == false)
                FixRotation();

            if (held)
            {
                hand = interactable.attachedToHand.handType;
                Vector2 m = a_move.GetAxis(hand);
            }

        }

        private void FixRotation()
        {
            Vector3 eulers = transform.eulerAngles;
            //eulers.x = 0;
            //eulers.z = 0;
            Quaternion targetRotation = Quaternion.Euler(eulers);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * (isGrounded ? 20 : 3));
        }

        public void Move(Vector3 move)
        {
            input = move;
            if (move.magnitude > 1f)
                move.Normalize();

            //move = transform.InverseTransformDirection(move);

            turnAmount = Mathf.Atan2(move.x, move.x);
            forwardAmount = move.z;
          
            // help the character turn faster (this is in addition to root rotation in the animation)
            
            float turnSpeed = Mathf.Lerp(m_StationaryTurnSpeed, m_MovingTurnSpeed, forwardAmount);

            //transform.Rotate(0, 0, turnAmount * 120f * Time.deltaTime);

            
            if (turnAmount < 0)
            {
                transform.Rotate(0, 0, turnAmount * 120f * Time.deltaTime);
            }
            else
            {
                transform.Rotate(0, 0, turnAmount * 360f * Time.deltaTime);
            }
            
        }

    }
}