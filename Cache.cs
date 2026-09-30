static class Cache<T>
{
    static T value;

    public static void Add(T item)
    {
        value = item;
    }

    public static T Get()
    {
        return value;
    }

    public static void Remove()
    {
        value = default(T);
    }
}