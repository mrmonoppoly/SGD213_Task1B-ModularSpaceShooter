using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMoveAndShoot : MonoBehaviour {

    // state
    private Vector2 movementDirection;

    // local references
    private EngineBase EngineBase;
    private WeaponBase weapon;

    void Start() {
        // populate our local references
        EngineBase = GetComponent<EngineBase>();
        weapon = GetComponent<WeaponBase>();

        // get a random direction between South-East and South-West
        float x = Random.Range(-0.5f, 0.5f);
        float y = -0.5f;
        movementDirection = new Vector2(x, y).normalized; // ensure it is normalised
    }

    // Update is called once per frame
    void Update () {
        // move our enemy if we have a EngineBase component attached
        if (EngineBase != null) {
            EngineBase.MoveEnemy(movementDirection);
        }

        // shoot if we have a IWeapon component attached
        if (weapon != null) {
            weapon.Shoot();
        }
    }   
}
