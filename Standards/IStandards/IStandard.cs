using System;
using MagmaWorks.Taxonomy.Serialization;

namespace MagmaWorks.Taxonomy.Standards
{
    public interface IStandard : ITaxonomySerializable
    {
        StandardBody Body { get; }
        Enum Code { get; }
        string Title { get; }
    }
}
