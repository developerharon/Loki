using System.Text;

namespace Loki.Utilities
{
    public class CssClassBuilder
    {
        private StringBuilder _classNames;

        public CssClassBuilder()
        {
            _classNames = new StringBuilder();
        }

        public CssClassBuilder AddClass(string className)
        {
            _classNames.Append($" {className}");
            return this;
        }

        public CssClassBuilder AddClass(string className, bool when)
        {
            if (when is true)
                _classNames.Append($" {className}");
            return this;
        }

        public string Build()
        {
            return _classNames.ToString().Trim().ToLower();
        }
    }
}