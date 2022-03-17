using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GunController : MonoBehaviour
{

	public Transform holdingWeapon;
	public Gun basicGun;
	Gun equippedGun;

	void Start()
	{
		if (basicGun != null)
		{
			EquipGun(basicGun);
		}
	}

	public void EquipGun(Gun gunToEquip)
	{
		if (equippedGun != null)
		{
			Destroy(equippedGun.gameObject);
		}
		equippedGun = Instantiate(gunToEquip, holdingWeapon.position, holdingWeapon.rotation);
		equippedGun.transform.parent = holdingWeapon;
	}

	public void Shoot()
	{
		if (equippedGun != null)
		{
			equippedGun.Shoot();
		}
	}
}
