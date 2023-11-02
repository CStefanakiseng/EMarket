namespace Kernel
{
    public class BaseEntity
    {

    }

    public class BaseEntity<T> : BaseEntity where T : struct
    {
        T Id;
    }
}