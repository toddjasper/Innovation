namespace Innovation.Voice.Win.UI.Query
{
    public interface IUrlParameter
    {
        string PropertyName { get; set; }
        string PropertyValue { get; }
        bool ShouldBeUrlEncoded { get; set; }
    }
}
