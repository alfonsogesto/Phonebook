namespace Library
{
    public interface IMessageChannel
    {
         void Send(Message message);
         Message sendmessage(Contact from, Contact to);
    }
}