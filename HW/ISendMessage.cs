public interface ISendMessage
{
    void Send();
}

public interface IEmailSending : ISendMessage
{
    new void Send();

}

public interface ISMSSending : ISendMessage
{
    new void Send();

}