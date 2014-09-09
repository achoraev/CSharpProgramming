namespace OOPPrinciplesPart1
{
    using System;
    using System.Collections.Generic;
    
    public interface IComment
    {
        List<string> Comment { get; set; }
        void AddComment(string comment);
    }
}
