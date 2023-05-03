using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MapacheWalk : StateMachineBehaviour
{
    private Animator anim;
    private GameObject player;
    private NavMeshAgent navMapache;
    float speed = 2.0f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        anim = animator.GetComponent<Animator>();
        navMapache = animator.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");

    }


    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //Vector3 direction = player.transform.position - animator.transform.position;
        //animator.transform.position = Vector3.MoveTowards(animator.transform.position, player.transform.position, speed * Time.deltaTime);
        navMapache.SetDestination(player.transform.position);
        navMapache.destination = player.transform.position;
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
