using clean_architecture_test.Application.Common.Interfaces;

namespace clean_architecture_test.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
