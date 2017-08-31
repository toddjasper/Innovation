using System;
using System.Text;

namespace Innovation.Voice.Win.UI.Query
{
    public abstract class WebBaseQuery
    {
        private string _basePath;
        public abstract string UriTemplate { get; }
        public WebQueryStringParameters Parameters { get; set; }

        protected WebBaseQuery()
        {
            Parameters = new WebQueryStringParameters();
        }

        public virtual string BasePath
        {
            get { return _basePath; }
            set
            {
                if (!_basePath.IsNullOrEmpty() && value.Contains("?"))
                {
                    throw new Exception("Base path cannot contain querystring parameters");
                }
                _basePath = value;
            }
        }

        public string ToString(bool lowercase = true)
        {
            if (_basePath.IsNullOrEmpty()) throw new Exception("Base path is null or empty");

            var output = new StringBuilder();
            if (!_basePath.IsNullOrEmpty() && _basePath.EndsWith("/"))
            {
                _basePath = _basePath.Substring(0, _basePath.Length - 1);
            }

            output.Append(_basePath);
            output.Append(UriTemplate);

            var outputString = output.ToString();

            if (outputString.IndexOf(".aspx") != -1)
            {
                output.Replace(".aspx", string.Empty, outputString.IndexOf(".aspx"), 5);
            }

            if (outputString.IndexOf(".html") != -1)
            {
                output.Replace(".html", string.Empty, outputString.IndexOf(".html"), 5);
            }

            foreach (var param in Parameters)
            {
                var propertyTemplate = "[" + param.PropertyName + "]";
                if (outputString.Contains(propertyTemplate))
                {
                    string charAfterPropertyTemplate = null;
                    if (outputString.IndexOf(propertyTemplate) + propertyTemplate.Length < outputString.Length)
                    {
                        charAfterPropertyTemplate = outputString.Substring(outputString.IndexOf(propertyTemplate) + propertyTemplate.Length, 1);
                    }

                    if (param.PropertyValue == null)
                    {
                        if (charAfterPropertyTemplate == "/")
                        {
                            output = output.Replace(propertyTemplate + "/", string.Empty);
                        }
                        else if (charAfterPropertyTemplate == "?")
                        {
                            output = output.Replace(propertyTemplate + "?", string.Empty);
                        }
                        else
                        {
                            output = output.Replace(propertyTemplate, string.Empty);
                        }
                    }
                    else
                    {
                        var queryStringValue = outputString.Contains("?") && (charAfterPropertyTemplate == null || (charAfterPropertyTemplate != "/" && charAfterPropertyTemplate != "?"));
                        output = queryStringValue ?
                            output.Replace(propertyTemplate, param.PropertyName + "=" + param.PropertyValue + "&") :
                            output.Replace(propertyTemplate, param.PropertyValue);
                    }
                }
            }

            if (output.ToString().Contains("[") && output.ToString().Contains("]"))
            {
                output.Remove(output.ToString().IndexOf("["), output.Length - output.ToString().IndexOf("["));
            }

            output.Replace("?&", "?");
            output.Replace("/?", "?");

            if (output.ToString().EndsWith("?"))
            {
                output.Replace("?", string.Empty, output.Length - 1, 1);
            }

            if (output.ToString().EndsWith("&"))
            {
                output.Replace("&", string.Empty, output.Length - 1, 1);
            }

            return lowercase ? output.ToString().ToLower() : output.ToString();
        }
    }
}
