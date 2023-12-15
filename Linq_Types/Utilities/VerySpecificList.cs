class VerySpecificList<T> : List<T>
{
    public IEnumerable<T> Where(Func<T, bool> predicate)
    {
        throw new InvalidOperationException("I don't support filtering!");
    }
}
