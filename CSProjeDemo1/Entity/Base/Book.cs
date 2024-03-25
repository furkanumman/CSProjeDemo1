using CSProjeDemo1.Enums;

namespace CSProjeDemo1.Entity.Base;

public abstract class Book 
{
    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public int PublishYear { get; set; }

    public string ISBN { get; set; } = null!;

    public Status Status { get; set; }

}
