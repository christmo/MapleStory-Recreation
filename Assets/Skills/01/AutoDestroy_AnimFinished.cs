using UnityEngine;
using System.Collections;

public class AutoDestroy_AnimFinished : MonoBehaviour {

	public Animator AnimationCntrlr ;

	// Use this for initialization
	void Start () {
		AnimationCntrlr = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("SKILL_01_EFFECT_ANIM")) {
			DestroyObject(gameObject);
		}
	}
}
