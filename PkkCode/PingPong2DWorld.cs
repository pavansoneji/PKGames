using UnityEngine;

namespace PkkCode
{
    public class PingPong2DWorld {
        /*
         params info
            rigidbody: moving object rigidbody
            speed: move speed of object
            axis: can be "Vertical", "Horizontal", e.t.c
         */
        public static void MoveObjectByAxisPong(Rigidbody2D rigidBody, float speed, string axis) {
            float v = Input.GetAxisRaw(axis);
            rigidBody.velocity = new Vector2(0, v) * speed;
        }

        public static void MoveObjectByTouchPong(Touch touch, Transform transform, float moveSpeed) {
            Vector2 pos = Camera.main.ScreenToWorldPoint(new Vector2(0, touch.position.y));
            transform.position = Vector3.MoveTowards(
                transform.position, 
                new Vector2(transform.position.x, pos.y), 
                moveSpeed * Time.deltaTime);
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

