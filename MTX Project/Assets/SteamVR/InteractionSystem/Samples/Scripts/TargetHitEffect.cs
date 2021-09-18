//======= Copyright (c) Valve Corporation, All rights reserved. ===============

using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem.Sample
{

    public class TargetHitEffect : MonoBehaviour
    {
        public Collider targetCollider;

        public Collider targetCollider2;

        public Collider targetCollider3;

        public Collider targetCollider4;

        

        public GameObject appearingMolecule;

        public GameObject appearingMolecule2;



        public bool test = true;

        public bool colorSpawnedObject = true;

        public bool destroyOnTargetCollision = true;

        private Hand hand;

        

        private void OnCollisionEnter(Collision collision)
        {


            if (collision.collider == targetCollider || collision.collider == targetCollider2 || collision.collider == targetCollider3 || collision.collider == targetCollider4)
            {

                ContactPoint contact = collision.contacts[0];
                float backTrackLength = 1f;
                Ray ray = new Ray(contact.point - (-contact.normal * backTrackLength), -contact.normal);



                if (colorSpawnedObject)
                {

                    if (collision.collider == targetCollider /*&& appearingMolecule != null*/)
                    {
                        appearingMolecule.SetActive(true);
                    } else if (collision.collider == targetCollider2 /*&& appearingMolecule2 != null*/)
                    {
                        appearingMolecule2.SetActive(true);
                    }

                    //I added more collisions to detect more parts of the same molecule in the fourth scene.
                    else if (collision.collider == targetCollider3)
                    {
                        appearingMolecule.SetActive(true);
                    } else if (collision.collider == targetCollider4)
                    {
                        appearingMolecule2.SetActive(true);
                    }


                }

                if (destroyOnTargetCollision){

                    
                    if (collision.collider == targetCollider)
                    {
                        targetCollider.transform.parent.parent.parent = null; //Detach from hand
                        Destroy(targetCollider.transform.parent.parent.gameObject);
                        Destroy(this.gameObject);

                    } else if (collision.collider == targetCollider2)
                    {
                        targetCollider2.transform.parent.parent.parent = null; //Detach from hand
                        Destroy(targetCollider2.transform.parent.parent.gameObject);
                        Destroy(this.gameObject);

                    }

                    //I added more collisions to detect more parts of the same molecule in the fourth scene.
                    else if (collision.collider == targetCollider3)
                    {
                        targetCollider3.transform.parent.parent.parent = null; //Detach from hand
                        Destroy(targetCollider3.transform.parent.parent.gameObject);
                        Destroy(this.gameObject);
                    } else if (collision.collider == targetCollider4)
                    {
                        targetCollider4.transform.parent.parent.parent = null; //Detach from hand
                        Destroy(targetCollider4.transform.parent.parent.gameObject);
                        Destroy(this.gameObject);
                    }

                }
                //Destroys both objects that are colliding

            }
        }
    }
}