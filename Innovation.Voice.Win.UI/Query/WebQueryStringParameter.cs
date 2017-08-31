namespace Innovation.Voice.Win.UI.Query
{
    public class WebQueryStringParameter<T> : IUrlParameter
    {
        public virtual T Value { get; set; }
        public string PropertyName { get; set; }
        public bool ShouldBeUrlEncoded { get; set; }

        public WebQueryStringParameter() : this(string.Empty)
        {

        }

        public WebQueryStringParameter(string propertyName, bool urlEncode = true)
        {
            PropertyName = propertyName;
            ShouldBeUrlEncoded = urlEncode;
        }

        public string PropertyValue => Value != null ? Value.ToString() : null;
    }
}
