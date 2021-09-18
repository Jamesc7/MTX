using UnityEngine;
using System.Collections;
using Valve.VR;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
    public class JoeJeffController : MonoBehaviour
    {
        
        [SteamVR_DefaultActionSet("platformer")]
        public SteamVR_ActionSet actionSet;

        [SteamVR_DefaultAction("Move", "platformer")]
        public SteamVR_Action_Vector2 a_move;


        public JoeJeff character;

        private Vector3 movement;
        private SteamVR_Input_Sources hand;
        private Interactable interactable;

        private void Start()
        {
            interactable = GetComponent<Interactable>();
            interactable.activateActionSetOnAttach = actionSet;
        }

        private void Update()
        {
            if (interactable.attachedToHand)
            {
                hand = interactable.attachedToHand.handType;
                Vector2 m = a_move.GetAxis(hand);
                movement = new Vector3(m.x, 0, m.y);

            }
            else
            {
                movement = Vector2.zero;
            }

            float rot = transform.eulerAngles.y;
            movement = Quaternion.AngleAxis(0, Vector3.up) * movement;
            character.Move(movement * 2);
        }
    }
}