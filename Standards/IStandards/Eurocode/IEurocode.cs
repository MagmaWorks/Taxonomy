using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public interface IEurocode : IStandard
    {
        Enum Part { get; } 
        NationalAnnex NationalAnnex { get; } 
    }
}
