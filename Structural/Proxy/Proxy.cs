using System;
using System.Collections.Generic;
using System.Text;

namespace GOFDesignPatterns.Structural.Proxy
{
    public class Proxy : SubjectBase
    {
        private SubjectBase _subject;

        public override void Method()
        {
            if (_subject == null)
            {
                _subject = new ConcreteSubject();
            }

            _subject.Method();
        }
    }
}
