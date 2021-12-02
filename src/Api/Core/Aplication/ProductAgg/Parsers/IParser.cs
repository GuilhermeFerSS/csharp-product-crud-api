namespace csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Parsers
{
    public interface IParser<TFrom, TTo>
    {
        TTo Parse(TFrom from);
    }
}