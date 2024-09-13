using System;

namespace MagmaWorks.Taxonomy.Standards
{
    public interface IStandard
    {
        StandardBody Body { get; }
        Enum Code { get; }
        string Title { get; }
    }
}
