using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float startSpeed = 1.0F;

    public int invadersDead;

    public float boostPerWave = 0.2F;

    public int InvadersPerWave {
        get { return 55; }
    }

    public float InvadersSpeed {
        get { return this.startSpeed + (this.invadersDead / this.InvadersPerWave) * this.boostPerWave; }
    }
}