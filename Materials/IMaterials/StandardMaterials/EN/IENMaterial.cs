using System;
using MagmaWorks.Taxonomy.Standards.Eurocode;

namespace MagmaWorks.Taxonomy.Materials
{
    public interface IEnMaterial<Grd> : IStandardMaterial<IEurocode, Grd> where Grd : Enum { }
}
