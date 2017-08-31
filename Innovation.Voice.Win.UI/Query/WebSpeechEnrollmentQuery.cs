using System.Configuration;
using Innovation.Voice.Win.UI.Query;

namespace Turn5.Infrastructure.Rest.Queries
{
    public class WebFitmentQuery : WebBaseQuery
    {
        public override string UriTemplate => "/trucks?[token][skus][vehicleType][year][generationStart][generationEnd][engine][driveTrain][transmission][bodyType][bedLength][submodel][productCategory][productSubCategory][productGenerationStartYear]";

        public WebFitmentQuery()
        {
            BasePath = ConfigurationManager.AppSettings["FitmentBasePath"];

            _token = new WebQueryStringParameter<string>("token");

            Parameters.Add(_token);
        }

        private readonly WebQueryStringParameter<string> _token;
        public string Token
        {
            get { return _token.Value; }
            set { _token.Value = value; }
        }
    }
}
