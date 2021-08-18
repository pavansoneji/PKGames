using UnityEngine;

namespace PkkCode
{
    public class Jumps2DWorld{
        public static void FlappyBirdJump(Rigidbody2D rigidbody2D, float jumpAmount){            
            rigidbody2D.velocity = Vector2.up * jumpAmount;
        }
    }
    
}
