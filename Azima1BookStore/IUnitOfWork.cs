namespace Azima1BookStore
{
    internal interface IUnitOfWork
    {
        object Product { get; }
        object Category { get; }
        object CoverType { get; set; }

        void Save();
    }
}