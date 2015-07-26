using UnityEngine;
using System.Collections;

public class LifeSystem : MonoBehaviour {
	public enum PLAYER_STATE {
		Attacking, Idle, Walking
	}

	[System.Serializable]
	public class PLAYER_LIFE  {
		public int Health = 100 ;
		public int Armour = 0 ;
		public int Mana = 100 ;
	}

	public PLAYER_STATE PlayerState = PLAYER_STATE.Idle;

	[SerializeField]
	public PLAYER_LIFE PlayerLife ; 

	public float ATK_TIMER = 0;
	public bool ATK_TIMER_ACTIVE = false ;

	// Use this for initialization
	void Start () {
		PlayerLife.Health = 100;
		PlayerLife.Armour = 0;
		PlayerLife.Mana = 0;

		PlayerState = PLAYER_STATE.Idle;
	}
	
	// Update is called once per frame
	void Update () {
		if (ATK_TIMER_ACTIVE == false) {
			if ( PlayerState == PLAYER_STATE.Attacking ){
				ATK_TIMER_ACTIVE = true ;
			}
		} else {
			ATK_TIMER += Time.deltaTime  ;
		}
		if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Idle") && PlayerState == PLAYER_STATE.Attacking && ATK_TIMER > 0.3f ) {
			PlayerState = PLAYER_STATE.Idle;
			ATK_TIMER = 0 ;
			ATK_TIMER_ACTIVE = false;
			Debug.Log (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).fullPathHash);
		}

		switch ( PlayerState ) {
		case PLAYER_STATE.Idle:
				
				break;
				
		case PLAYER_STATE.Walking:
				
				break;
				
		case PLAYER_STATE.Attacking:
				
				break; 
			}
	}
}
