/* Shared classes can be referenced by both the Client and Server */


public class ChatMessage
{
    public string? UserName { get; set; }
    public string? Content { get; set; }
    public bool IsImg { get; set; } = false;
	public ChatMessage()
    {
        
    }
	public ChatMessage(string u, string c, bool isImg = false)
	{
        this.UserName = u;
        this.Content = c;
        this.IsImg = isImg;
	}
}
