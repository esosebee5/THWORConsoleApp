namespace THWOR.src.items.itemBase
{
    abstract class WeaponBase : ItemBase, IWeapon
    {
        private readonly int Damage;
        private readonly string DamageType;
        private readonly string AttackVerb;

        public WeaponBase(
            string name,
            string description,
            int size,
            int damage,
            string damageType,
            string attackVerb)
            : base(name, description, size)
        {
            Damage = damage;
            DamageType = damageType;
            AttackVerb = attackVerb;
        }

        public int GetDamage()
        {
            return Damage;
        }

        public string GetDamageType()
        {
            return DamageType;
        }

        public string GetAttackVerb()
        {
            return AttackVerb;
        }
    }
}
