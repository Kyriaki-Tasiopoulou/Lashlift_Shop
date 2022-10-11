using Lashlift_Shop;
using System;

namespace Lashlift_Shop
{
    public interface IUnitOfWork
    {
        ILashlifterRepository Lashlifters { get; }
        IGirlRepository Girls { get; }
        int Complete();
    }
}