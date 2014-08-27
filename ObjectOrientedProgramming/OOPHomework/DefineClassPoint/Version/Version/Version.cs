namespace Version
{
    using System;
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Struct)]
    class Version : Attribute
    {
        private int major;
        private int minor;

        public Version(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public string GetVersion
        {
            get
            {
                return String.Format("{0}.{1}", major,minor);
            }
        }
    }
}
