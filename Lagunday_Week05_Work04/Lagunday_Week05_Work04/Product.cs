namespace Lagunday_Week05_Work04;

public record Product(
    string Barcode,
    string Name,
    string Description,
    string Category,
    string Origin,
    bool IsActive,
    decimal Cost,
    decimal Price,
    decimal Markup);
