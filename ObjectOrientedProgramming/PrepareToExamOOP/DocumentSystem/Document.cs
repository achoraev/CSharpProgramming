namespace DocumentSystemName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Document : IDocument
    {
        public string Name { get; protected set; }

        public string Content { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            if (key == "content")
            {
                this.Content = value;
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            if (this.Name != null)
            {
                output.Append(this.GetType().Name);
                output.Append("Document");
                output.Append('[');
                IList<KeyValuePair<string, object>> attrib = new List<KeyValuePair<string, object>>();
                var ordered = attrib.OrderBy(k => k.Key);
                this.SaveAllProperties(attrib);
                foreach (var atr in ordered)
                {
                    if (atr.Value != null)
                    {
                        output.Append(atr.Key);
                        output.Append("=");
                        output.Append(atr.Value);
                        output.Append(";");
                    }
                }
                output.Length--;
                output.Append(']');

            }
            else
            {
                output.Append("Document has no name");
            }
            return output.ToString();
        }
    }
}
