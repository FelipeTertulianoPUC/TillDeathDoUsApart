using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Projectile", menuName = "Weapon/Projectile")]

public class ProjectileData : ScriptableObject
{
    public ItemData item;

    public float startSpeed;
    public float damage;
    public float range;
    public DamageType type;

    public float lifeSpan;
    public ParticleSystem hitEffect;

    public Sprite visualProjectile;
    public Color color = Color.white;
    public Sprite round;

    public MeshParticleData shellParticleData;
    public GameObject muzzleFlashParticle;
    public Material tracerMaterial;

}
