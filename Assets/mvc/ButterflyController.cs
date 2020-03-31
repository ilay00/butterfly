using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ButterflyF
{
    public class ButterflyController : MonoBehaviour
    {
        private Animator _anim;
        private SpriteRenderer _sr;
        private Rigidbody2D _rb;
        public Vector2 direction;
        [SerializeField] private RotationSpeed _speed;
        [SerializeField] private RotationRightBorder _rightBorder;
      

    
       

        // Start is called before the first frame update

        void Start()
        {

           
            _rb = GetComponent<Rigidbody2D>();
            _sr = GetComponent<SpriteRenderer>();
        }

        void Stop()
        {
            _anim.SetBool("bfiy_stop", false);
            _rb.velocity = new Vector2(0, _rb.velocity.y);

        }

        void FixedUpdate()
        {

            transform.Translate(direction.normalized * _speed.Speed);
            if (transform.position.x > _rightBorder.RightBorder)
            {
                _sr.flipX = true;
                Stop();
            }

          

        }
    }
}