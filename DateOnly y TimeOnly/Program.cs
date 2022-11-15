InvokeDate(DateOnly.FromDateTime(DateTime.Now));
InvokeTime(TimeOnly.FromDateTime(DateTime.Now));

void InvokeDate(DateOnly date)
{
    Console.WriteLine(date.ToString());
}

void InvokeTime(TimeOnly time)
{
    Console.WriteLine(time.ToString());
}