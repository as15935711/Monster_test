using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float speed = 3.5f;
    [Header("攻擊力"), Range(0, 500)]
    public int atk = 100;
    [Range(0, 5000)]
    public float HP = 350;
    [Header("掉落道具"), Tooltip("這是掉落道具")]
    public GameObject Gam;
    [Header("掉落道具機率"), Range(0, 1)]
    public float GOP = 1;
    [Header("掉落道具音效"), Tooltip("這是掉落道具音效")]
    public AudioClip Aud;

    private AudioSource AudS;
    private Rigidbody2D Rig;
    private Animator Aim;
}