using System;
using System.Runtime.Serialization;

[DataContract]
public class Ticket
{
    [DataMember]
    public int TicketID { get; set; }
    [DataMember]
    public DateTime Date { get; set; }
    [DataMember]
    public string Description { get; set; }
    [DataMember]
    public Status status { get; set; }
    [DataMember]
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