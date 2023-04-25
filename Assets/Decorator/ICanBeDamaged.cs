namespace Decorator
{
    public interface ICanBeDamaged
    {
        void TakeDamage(DamageType Type, int damage);
    }
}