/// <summary>
/// Entity with order
/// </summary>
public interface IOrderedEntity
{
    /// <summary>
    /// Порядок
    /// </summary>
    int Order { get; set; }
}