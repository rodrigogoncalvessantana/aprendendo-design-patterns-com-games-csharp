namespace Visitor
{
    public interface IVisitor
    {
        void Identificar(Chefao chefao);
        void Identificar(FaseJogo fasejogo);
    }
}
