using clean_architecture_test.Application.Common.Mappings;
using clean_architecture_test.Domain.Entities;

namespace clean_architecture_test.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public string? Title { get; set; }
}
