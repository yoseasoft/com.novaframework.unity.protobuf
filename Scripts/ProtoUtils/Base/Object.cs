namespace ProtoBuf.Extension
{
    public abstract class Object
    {
        public override string ToString() => LitJson.JsonMapper.ToJson(this);

        public int ClientIdx { get; set;}

        public int ServerIdx { get; set;}
    }
}