using UnityEngine;
using System.Collections;

public class Skillset : MonoBehaviour {

	[System.Serializable]
	public class SKILL {
		public string Name ;
		public string Description ;
		public int ReqMana ;
		public GameObject SkillPrefab;
	}

	// Use this for initialization
	void Start () {
	
	}

	[SerializeField]
	public SKILL[] Skills ;

	public float SKILL_ANIM_DELAY = 0.4f;
	public float SKILL_ANIM_INDEX = 0.0f ;
	public bool SKILL_ANIM_INPROG = false ;
	// Update is called once per frame
	void Update () {
		if (SKILL_ANIM_INPROG == true) {
			if ( SKILL_ANIM_INDEX < SKILL_ANIM_DELAY ){
				SKILL_ANIM_INDEX += Time.deltaTime ;
			}else{
				SKILL_ANIM_INDEX = 0 ;
				SKILL_ANIM_INPROG = false;
				Instantiate(Skills[0].SkillPrefab, gameObject.transform.localPosition, Quaternion.identity);
			}
		}
	}

	void PerformSkill (){
		SKILL_ANIM_INPROG = true;
	}
}
