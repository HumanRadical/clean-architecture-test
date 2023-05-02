using System.Globalization;
using clean_architecture_test.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace clean_architecture_test.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
