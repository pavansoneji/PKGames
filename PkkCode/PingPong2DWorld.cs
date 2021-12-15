using UnityEngine;

namespace PkkCode
{
    public class PingPong2DWorld {
        public static void MoveObjectByAxisPong(Rigidbody2D rigiedBody2D, float speed, string axis) {
            float v = Input.GetAxisRaw(axis);
            rigiedBody2D.velocity = new Vector2(0, v) * speed;
        }

        public static void BallMovementPong(Rigidbody2D rigiedBody2D, Vector2 direction, float speed){
            // rigiedBody2D.velocity = Vector2.right * speed;
            rigiedBody2D.velocity = direction * speed;
        }

        public static float HitFactorPong(Vector2 ballPos, Vector2 racketPos, float racketHeight) {
            /*
            ||  1 <- at the top of the racket
            ||
            ||  0 <- at the middle of the racket
            ||
            || -1 <- at the bottom of the racket
            */
            return (ballPos.y - racketPos.y) / racketHeight;
        }
    }

}

