﻿namespace DocumentSystemName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Encryptable : Binary, IEncryptable
    {
        public bool IsEncrypted { get; private set; }
            
        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override string ToString()
        {
            if (this.IsEncrypted)
            {
                return (this.GetType().Name + "Document" + "[encrypted]");
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
