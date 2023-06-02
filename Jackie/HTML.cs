namespace Jackie {
    internal class HTML {
        string style;
        string body;

        public string generateRawHTML() {
            return $@"<!DOCTYPE html>
<html>
<head>
<style>
{style}
</style>
</head>
<body>
{body}
</body>
</html>";
        }

        public void AppendStyle(string input) {
            style += input;
        }

        public void AppendBody(string tag, string content) {
            var input = CreateElement(tag, content);
            body += input;
        }

        public void AppendBody(string input) {
            body += input;
        }

        static public string CreateElement(string tag, object content) {
            return $"<{tag}>{content}</{tag}>";
        }
    }
}
