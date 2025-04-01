namespace CateringBackend.Domain.Entities.Enums
{
    public enum OrderStatus
    {
        Created,
        WaitingForPayment,
        Paid,
        ToRealized,
        Prepared,
        Delivered,
        Finished,
        Canceled
    }
}
