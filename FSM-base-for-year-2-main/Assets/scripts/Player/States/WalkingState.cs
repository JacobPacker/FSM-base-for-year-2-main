
using UnityEngine;
namespace Player
{
    public class WalkingState : State
    {
        public WalkingState(PlayerScript player, StateMachine sm) : base(player, sm){ }

        public override void Enter()
        {
            base.Enter();
            player.anim.Play("arthur_run", 0, 0);
            //player.xv = player.yv = 0;
        }

        public override void Exit()
        {
            base.Exit();

            player.anim.SetBool("run", false);
        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();

            player.SetMoveDirectionAndVelocity();
            player.SetCrouchState();
            player.CheckForStand();
            player.SetJumpState();

        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}