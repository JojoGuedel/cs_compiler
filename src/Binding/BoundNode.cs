namespace Compiler
{
    internal abstract class BoundNode
    {
        public abstract BoundNodeKind Kind { get; }
    }
}