public static class EnumerableExtensions
{
    public static IEnumerable<TResult> OurSelect<Tsource, TResult>(
        this IEnumerable<Tsource> source,
        Func<Tsource, IEnumerable<TResult>> selector)
    {
        var result = new List<TResult>();
        foreach (var item in source)
        {
            var innerCollection = selector(item);
            foreach (var innerItem in innerCollection)
            {
                result.Add(innerItem);
            }
        }
        return result;
    }

}

