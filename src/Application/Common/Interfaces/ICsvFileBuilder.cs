using clean_architecture_test.Application.TodoLists.Queries.ExportTodos;

namespace clean_architecture_test.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
