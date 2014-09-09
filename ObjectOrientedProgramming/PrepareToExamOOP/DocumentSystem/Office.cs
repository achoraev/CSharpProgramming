namespace DocumentSystemName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Office : Encryptable, IDocument
    {
        public long? Version { get; protected set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "version")
            {
                this.Version = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("version", this.Version));
            base.SaveAllProperties(output);
        }
    }
}
