namespace Decorator
{
    public class Decorator : ItemArmadura
    {
        protected ItemArmadura item_armadura;

        public Decorator(ItemArmadura item)
        {
            this.item_armadura = item;
        }

        public override void Exibe()
        {
            this.item_armadura.Exibe();
        }
    }
}
