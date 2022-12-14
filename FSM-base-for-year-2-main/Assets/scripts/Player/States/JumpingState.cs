using UnityEngine;
namespace Player
{
    public class JumpingState : State
    {
        // constructor
        public JumpingState(PlayerScript player, StateMachine sm) : base(player, sm) { }

        public override void Enter()
        {
            base.Enter();
            player.anim.Play("arthur_jump_up", 0, 0);
            //player.xv = player.yv = 0;

            Debug.Log("entering jump state");
            player.yv = 10f;

            

        }

        public override void Exit()
        {
            base.Exit();

            //player.anim.SetBool("jump", false);
        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();



        }



        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();

            player.DoJump();
            player.CheckForLand();

        }
    }
}