namespace ShopTest1.Service
{
    public class MessageResult
    {
        public bool isSuccess { get; set; }
        public String message { get; set; }
    }
    public class ObjectResult<T> : MessageResult
    {
        private T _obj;

        public void setResult(T value)
        {
            _obj = value;
        }

        public T getResult()
        {
            return _obj;
        }

        public T genericMethod(T value)
        {
            return _obj;
        }

        public T genericProperty { get; set; }
    }

    public class ListResult<T> : MessageResult
    {
        private List<T> _obj;

        public void setResult(List<T> value)
        {
            _obj = value;
        }

        public List<T> getResult()
        {
            return _obj;
        }
    }
}
