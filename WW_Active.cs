using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace WhiteWolf {

    public class WW_Active : MonoBehaviour {

        public bool _active;

        [Space]

        public bool _activeTime;

        public float timer;

        [Space]

        public float time;
        public GameObject obj;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        bool _time;

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        [System.Obsolete]
        void Update(){

            if ( _time ){

                timer += Time.deltaTime;

            }

            if ( _activeTime ){ Switch( obj, time ); }

        }

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        public void True( GameObject gameObject ) => gameObject.SetActive( true );
        public void T( GameObject gameObject ) => gameObject.SetActive( true );

        public void False( GameObject gameObject ) => gameObject.SetActive( false );
        public void F( GameObject gameObject ) => gameObject.SetActive( false );

        /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

        [System.Obsolete]
        public void Switch( GameObject gameObject, float time ){

            _time = true;
            if ( timer >= time ){ gameObject.SetActive( !gameObject.active ); _active = gameObject.active; timer = 0;  }

        }

    }

}