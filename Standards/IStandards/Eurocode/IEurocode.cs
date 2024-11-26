using System;

namespace MagmaWorks.Taxonomy.Standards.Eurocode
{
    public interface IEurocode : IStandard
    {
        NationalAnnex NationalAnnex { get; }
        Eurocode Code { get; }
    }
}
