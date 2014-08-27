namespace DocumentSystemName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Excel : Office, IDocument, IEncryptable
    {
        public long? NumberOfRows { get; protected set; }
        public long? NumberOfCols { get; protected set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "rows")
            {
                this.NumberOfRows = long.Parse(value);
            }
            if (key == "cols")
            {
                this.NumberOfCols = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
            output.Add(new KeyValuePair<string, object>("cols", this.NumberOfCols));
            base.SaveAllProperties(output);
        }
    }
}
