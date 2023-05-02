﻿using clean_architecture_test.Application.Common.Mappings;
using clean_architecture_test.Domain.Entities;

namespace clean_architecture_test.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
