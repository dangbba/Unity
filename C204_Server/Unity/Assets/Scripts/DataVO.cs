[System.Serializable] //����ȭ
public class DataVO
{
    public string type;
    public string payload;

    public DataVO()
    {

    }

    public DataVO(string type, string payload)
    {
        this.type = type;
        this.payload = payload;
    }
}