using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BeastHunter
{
    public class ButterflyController : IAwake, IUpdate
    {
        


            #region Fields

            private readonly GameContext _context;

            #endregion

            #region ClassLifeCycle

            public ButterflyController(GameContext context, Services services)
            {
                _context = context;
            }

            #endregion

            #region Updating

            public void Updating()
            {
                _context._butterflyModel.Initilize();
            }

            #endregion


            #region OnAwake

            public void OnAwake()
            {

            }

            #endregion        
        

        // Start is called before the first frame update

     /*   void Start()
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


    */
        }
    }

