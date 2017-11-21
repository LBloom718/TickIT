using System;

public class Ticket
{
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public Status status { get; set; }
    public Type type { get; set; }
}

public enum Status
{
    UNOPEN = 1, OPEN = 2, CLOSED = 3
};

public enum Type
{
    HARDWARE = 1, SOFTWARE = 2, OTHER = 3
};